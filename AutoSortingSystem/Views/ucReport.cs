using AutoSortingSystem.Application.Service;
using AutoSortingSystem.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutoSortingSystem.Admin.Views
{
    public partial class ucReport : UserControl
    {
        Series series;

        public ucReport()
        {
            InitializeComponent();

            SetDataGridViewProperties(dgvReportList);
            SetColumnChartProperties();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert fa = new Form_Alert();
            fa.showAlert(msg, type);
        }

        private void SetDataGridViewProperties(DataGridView dgv)
        {
            dgv.Font = new Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#454545");
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#333333");
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 187, 76);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Transparent;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(251, 187, 76);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
        }

        private void SetColumnChartProperties()
        {
            series = this.chartTotalPcs.Series[0];
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;
            series.Color = Color.FromArgb(102, 187, 106);
            this.chartTotalPcs.ChartAreas[0].AxisX.LineColor = Color.White;
            this.chartTotalPcs.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            this.chartTotalPcs.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.chartTotalPcs.ChartAreas[0].AxisY.LineColor = Color.White;
            this.chartTotalPcs.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Transparent;
            this.chartTotalPcs.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var res = ReportService.Ins.GetReportBarcodeList(dpkFrom.Value, dpkTo.Value, tbRecipeID.Text);
            if (res != null)
            {
                dgvReportList.DataSource = res;
            }        
        }

        private void dgvReportList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string reportId = dgvReportList.SelectedCells[0].Value.ToString();
            var reportData = ReportService.Ins.GetRecipeReportInfo(reportId);

            if (reportData != null)
            {
                lbRecipeID.Text = reportData.Recipe;
                lbStarttime.Text = reportData.StartTime.ToString();
                lbStoptime.Text = reportData.StopTime.ToString();
                lbRunningtime.Text = (reportData.StopTime - reportData.StartTime).ToString().Remove(8);
                lbTotal.Text = reportData.Total.ToString();
                lbGateRejectTotal.Text = reportData.Reject.ToString();
                lbGate1Total.Text = reportData.Gate1Total.ToString();
                lbGate2Total.Text = reportData.Gate2Total.ToString();
                lbGate3Total.Text = reportData.Gate3Total.ToString();
                lbGate4Total.Text = reportData.Gate4Total.ToString();
                lbGate5Total.Text = reportData.Gate5Total.ToString();

                string[] chTotalPcsXVal = { "Gate Rej", "Gate 1", "Gate 2", "Gate 3", "Gate 4", "Gate 5" };
                var _jobCnt = new int?[6];
                _jobCnt[0] = reportData.Reject;
                _jobCnt[1] = reportData.Gate1Total;
                _jobCnt[2] = reportData.Gate2Total;
                _jobCnt[3] = reportData.Gate3Total;
                _jobCnt[4] = reportData.Gate4Total;
                _jobCnt[5] = reportData.Gate5Total;

                chartTotalPcs.Series[0].Points.DataBindXY(chTotalPcsXVal, _jobCnt);


                cirpbGateRej.Value = (int)Math.Round((double)((double)(100 * reportData.Reject) / reportData.Total));
                cirpbGate1.Value = (int)Math.Round((double)((double)(100 * reportData.Gate1Total) / reportData.Total));
                cirpbGate2.Value = (int)Math.Round((double)((double)(100 * reportData.Gate2Total) / reportData.Total));
                cirpbGate3.Value = (int)Math.Round((double)((double)(100 * reportData.Gate3Total) / reportData.Total));
                cirpbGate4.Value = (int)Math.Round((double)((double)(100 * reportData.Gate4Total) / reportData.Total));
                cirpbGate5.Value = (int)Math.Round((double)((double)(100 * reportData.Gate5Total) / reportData.Total));
            }        
        }
    }
}
