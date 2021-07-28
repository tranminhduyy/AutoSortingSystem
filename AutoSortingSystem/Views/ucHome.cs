using AutoSortingSystem.Admin.Properties;
using AutoSortingSystem.Application.Service;
using AutoSortingSystem.Data.Entities;
using AutoSortingSystem.Views;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using AutoSortingSystem.Application.ViewModel;

namespace AutoSortingSystem.Admin.Views
{
    public partial class ucHome : UserControl
    {
        private string[] RecipeGate;
        string _recipeID;
        int _id = 0;
        DateTime startTime;
        Series series;
        string[] chTotalPcsXVal = { "Gate Rej", "Gate 1", "Gate 2", "Gate 3", "Gate 4", "Gate 5" };

        public ucHome()
        {
            InitializeComponent();

            RecipeGate = new string[6];

            

            SetDataGridViewProperties(dgvBarcodeList);
            SetDataGridViewLogDataProperties(dgvLogData);
            SetColumnChartProperties();
            PLC.Instance().Open();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert fa = new Form_Alert();
            fa.showAlert(msg, type);
        }     

        private byte[] GetRecipeDataFromDgv()
        {
            try
            {
                byte[] gate1recipe = Encoding.ASCII.GetBytes(dgvBarcodeList.Rows[0].Cells[2].Value.ToString());
                byte[] gate2recipe = Encoding.ASCII.GetBytes(dgvBarcodeList.Rows[1].Cells[2].Value.ToString());
                byte[] gate3recipe = Encoding.ASCII.GetBytes(dgvBarcodeList.Rows[2].Cells[2].Value.ToString());
                byte[] gate4recipe = Encoding.ASCII.GetBytes(dgvBarcodeList.Rows[3].Cells[2].Value.ToString());
                byte[] gate5recipe = Encoding.ASCII.GetBytes(dgvBarcodeList.Rows[4].Cells[2].Value.ToString());
                byte[] recipeData = new byte[100];
                gate1recipe.CopyTo(recipeData, 0);
                gate2recipe.CopyTo(recipeData, 20);
                gate3recipe.CopyTo(recipeData, 40);
                gate4recipe.CopyTo(recipeData, 60);
                gate5recipe.CopyTo(recipeData, 80);
                return recipeData;
            }
            catch
            {
                return null;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (lbRecipeID.Text != "ID: ??????")
            {
                Alert("Please make sure recipe is correct", Form_Alert.enmType.Warning);
                var dialogResult = MessageBox.Show("Do you want to download recipe and start?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    var recipeData = GetRecipeDataFromDgv();
                    if (recipeData != null)
                    {
                        var res = PLC.Instance().WriteRecipeData(recipeData, true);
                        if (res)
                        {
                            Alert("Download successed!", Form_Alert.enmType.Success);
                            AuditService.Ins.Record(Settings.Default.User, "Start repice");

                            btStart.Enabled = false;
                            btStart.BackgroundImage = Resources.play_100px_disable;
                            btStop.Enabled = true;
                            btStop.BackgroundImage = Resources.stop_100px_enable;

                            startTime = DateTime.Now;                          
                            lbStartTime.Text = startTime.ToString();
                            lbID.Text = _recipeID;

                            tmrLogData.Enabled = true;
                        }
                        else
                        {
                            Alert("Something went wrong", Form_Alert.enmType.Error);
                        }
                    }
                    else
                    {
                        Alert("Something went wrong", Form_Alert.enmType.Error);
                    }               
                    
                }
            }
            else
            {
                Alert("No recipe selected!", Form_Alert.enmType.Error);
            }
        }

        public byte[] addByteToArray(byte[] bArray, byte newByte)
        {
            byte[] newArray = new byte[bArray.Length + 1];
            bArray.CopyTo(newArray, 1);
            newArray[0] = newByte;
            return newArray;
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you want to Stop?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                var res = PLC.Instance().WriteRecipeData(new byte[100], false);
                if (res)
                {
                    Alert("Finished!", Form_Alert.enmType.Success);

                    var p = new ProductionRecordVM()
                    {
                        Recipe = _recipeID,
                        StartTime = startTime,
                        StopTime = DateTime.Now,
                        Total = int.Parse(lbTotal.Text),
                        Gate1Total = int.Parse(lbGate1JobCnt.Text),
                        Gate2Total = int.Parse(lbGate2JobCnt.Text),
                        Gate3Total = int.Parse(lbGate3JobCnt.Text),
                        Gate4Total = int.Parse(lbGate4JobCnt.Text),
                        Gate5Total = int.Parse(lbGate5JobCnt.Text),
                        Reject = int.Parse(lbReject.Text),
                    };

                    PLC.Instance().ResetJobCntFromPLC();
                    RecipeService.Ins.FinishRecipe(p);

                    AuditService.Ins.Record(Settings.Default.User, "Finish repice");

                    btStart.Enabled = true;
                    btStart.BackgroundImage = Resources.play_100px_enable;
                    btStop.Enabled = false;
                    btStop.BackgroundImage = Resources.stop_100px_disable;

                    tmrLogData.Enabled = false;
                    lbStartTime.Text = "xxx";
                    lbRunningTime.Text = "xxx";
                    lbID.Text = "xxx";
                    lbTarget.Text = "xxx";
                    lbGood.Text = "xxx";
                    lbReject.Text = "xxx";
                    lbTotal.Text = "xxx";
                    lbGate1JobCnt.Text = "xxx";
                    lbGate2JobCnt.Text = "xxx";
                    lbGate3JobCnt.Text = "xxx";
                    lbGate4JobCnt.Text = "xxx";
                    lbGate5JobCnt.Text = "xxx";
                }
                else
                {
                    Alert("Something went wrong", Form_Alert.enmType.Error);
                }               
            }
        }



        bool resFault;
        private void btImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog _openFileDialog = new OpenFileDialog();
                DialogResult result = _openFileDialog.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    string fileDir = _openFileDialog.FileName;
                    string recipeID = (Path.GetFileName(fileDir)).Replace(@".xlsx", @"");
                    string fileExtension = Path.GetExtension(fileDir);

                    if (fileExtension == ".xlsx")
                    {
                        try
                        {
                            OleDbConnection olecon = new OleDbConnection();
                            string strCon = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + fileDir + ";Extended Properties=Excel 12.0;";
                            olecon.ConnectionString = strCon;
                            olecon.Open();
                            string strSQL = "SELECT * FROM [DanhSach$]";
                            OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                            DataSet dsNewRecipe = new DataSet();
                            oleda.Fill(dsNewRecipe);
                            olecon.Close();
                            dsNewRecipe.Tables[0].TableName = "GateRecipe";

                            //01. Insert recipe ID
                            var resInsertRecipeID = RecipeService.Ins.AddRecipeID(recipeID);
                            if (resInsertRecipeID == true)
                            {
                                Alert("Add recipe successed!", Form_Alert.enmType.Success);
                            }
                            else
                            {
                                Alert("Cannot add new recipe", Form_Alert.enmType.Error);
                            }

                            //02. Insert GateRecipe
                            try
                            {
                                foreach (DataRow row in dsNewRecipe.Tables[0].Rows)
                                {
                                    var gateRecipe = new GateRecipe
                                    {
                                        Recipe_ID = row["Recipe_ID"].ToString(),
                                        GateNo = row["GateNo"].ToString(),
                                        ReferenceCode = row["ReferenceCode"].ToString(),
                                    };
                                    var res = RecipeService.Ins.AddGateRecipe(gateRecipe);
                                    if (!res)
                                    {
                                        resFault = true;
                                        break;
                                    }
                                }
                                if (resFault)
                                {
                                    Alert("Cannot add new gate barcode", Form_Alert.enmType.Error);
                                }
                                else
                                {
                                    Alert("Add gate barcode successed!", Form_Alert.enmType.Success);
                                    //Show on dgv
                                    dgvBarcodeList.DataSource = RecipeService.Ins.GetGateRecipe(recipeID);
                                    lbRecipeID.Text = "ID: " + recipeID;
                                    lbImportDate.Text = "Imported on Date: " + DateTime.Now.ToString();
                                }

                                RecipeGate[0] = "Bad Barcode";
                                RecipeGate[1] = dgvBarcodeList.Rows[0].Cells[2].Value.ToString();
                                RecipeGate[2] = dgvBarcodeList.Rows[1].Cells[2].Value.ToString();
                                RecipeGate[3] = dgvBarcodeList.Rows[2].Cells[2].Value.ToString();
                                RecipeGate[4] = dgvBarcodeList.Rows[3].Cells[2].Value.ToString();
                                RecipeGate[5] = dgvBarcodeList.Rows[4].Cells[2].Value.ToString();
                            }
                            catch
                            {
                                Alert("Something went wrong!", Form_Alert.enmType.Error);
                            }

                            //03. Audit record
                            AuditService.Ins.Record(Settings.Default.User, "Import repice");
                        }
                        catch
                        {
                            Alert("Not template file", Form_Alert.enmType.Error);
                        }
                    }
                    else
                    {
                        Alert("Please choose Excel file", Form_Alert.enmType.Error);
                    }
                }
            }
            catch
            {
                //MessageBox.Show(""); 
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            new FormSearchRecipe(this).Show();
        }

        public void GetRecipeFromSearchEngine(string recipeID, string importDate)
        {
            var barcodeList = RecipeService.Ins.GetGateRecipe(recipeID);
            if (barcodeList != null)
            {
                dgvBarcodeList.DataSource = barcodeList;
                _recipeID = recipeID;
                lbRecipeID.Text = "ID: " + recipeID;
                lbImportDate.Text = "Imported on Date: " + importDate;

                RecipeGate[0] = "Bad Barcode";
                RecipeGate[1] = dgvBarcodeList.Rows[0].Cells[2].Value.ToString();
                RecipeGate[2] = dgvBarcodeList.Rows[1].Cells[2].Value.ToString();
                RecipeGate[3] = dgvBarcodeList.Rows[2].Cells[2].Value.ToString();
                RecipeGate[4] = dgvBarcodeList.Rows[3].Cells[2].Value.ToString();
                RecipeGate[5] = dgvBarcodeList.Rows[4].Cells[2].Value.ToString();
            }           
        }

        private void SetDataGridViewProperties(DataGridView dgv)
        {
            dgv.Font = new Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(87, 87, 87);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(69, 69, 69);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(102, 187, 106); 
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 25;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(102, 187, 106);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
        }

        private void SetDataGridViewLogDataProperties(DataGridView dgv)
        {
            dgv.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(87, 87, 87);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(69, 69, 69);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(69, 69, 69);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 255);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
        }

        private void SetColumnChartProperties()
        {
            series = this.chartTotalPcs.Series[0];
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;
            series.Color = Color.FromArgb(255, 128, 0);
            this.chartTotalPcs.ChartAreas[0].AxisX.LineColor = Color.White;
            this.chartTotalPcs.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            this.chartTotalPcs.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.chartTotalPcs.ChartAreas[0].AxisY.LineColor = Color.White;
            this.chartTotalPcs.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Transparent;
            this.chartTotalPcs.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }

        private void tmrLogData_Tick(object sender, EventArgs e)
        {
            lbRunningTime.Text = (DateTime.Now - startTime).ToString().Remove(8);
            var res = PLC.Instance().CheckHasPackage();
            if (res != null)
            {
                int stt = 0;
                foreach (var item in res)
                {
                    if (item)
                    {
                        _id = _id + 1;
                        DataGridViewRow row = (DataGridViewRow)dgvLogData.Rows[0].Clone();
                        row.Cells[0].Value = _id;
                        row.Cells[1].Value = RecipeGate[stt];
                        row.Cells[2].Value = (stt > 0) ? stt.ToString() : "Reject";
                        row.Cells[3].Value = (stt > 0) ? "Good" : "Bad";
                        switch (row.Cells[3].Value)
                        {
                            case "Good":
                                row.Cells[3].Style.BackColor = Color.FromArgb(102, 187, 106);
                                break;
                            case "Bad":
                                row.Cells[3].Style.BackColor = Color.FromArgb(255, 128, 128);
                                break;
                        }
                        row.Cells[4].Value = DateTime.Now.ToString();
                        dgvLogData.Rows.Insert(0, row);
                    }
                    stt++;
                }
            }

            var _jobCnt = new int[6];
            _jobCnt = PLC.Instance().ReadJobCntFromPLC();
            lbReject.Text = _jobCnt[0].ToString();
            lbGate1JobCnt.Text = _jobCnt[1].ToString();
            lbGate2JobCnt.Text = _jobCnt[2].ToString();
            lbGate3JobCnt.Text = _jobCnt[3].ToString();
            lbGate4JobCnt.Text = _jobCnt[4].ToString();
            lbGate5JobCnt.Text = _jobCnt[5].ToString();
            lbGood.Text = (_jobCnt[1] + _jobCnt[2] + _jobCnt[3] + _jobCnt[4] + _jobCnt[5]).ToString();
            lbTotal.Text = (_jobCnt[1] + _jobCnt[2] + _jobCnt[3] + _jobCnt[4] + _jobCnt[5] + _jobCnt[0]).ToString();

            chartTotalPcs.Series[0].Points.DataBindXY(chTotalPcsXVal, _jobCnt);
        }
    }
}
