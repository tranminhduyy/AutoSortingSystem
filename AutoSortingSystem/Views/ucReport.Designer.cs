
namespace AutoSortingSystem.Admin.Views
{
    partial class ucReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReport));
            this.dgvReportList = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dpkFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpkTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tbRecipeID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbRecipeID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbStarttime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbStoptime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbRunningtime = new System.Windows.Forms.Label();
            this.chartTotalPcs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cirpbGate1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lbGate1Total = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cirpbGateRej = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cirpbGate5 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cirpbGate4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cirpbGate3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cirpbGate2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbGateRejectTotal = new System.Windows.Forms.Label();
            this.lbGate5Total = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbGate4Total = new System.Windows.Forms.Label();
            this.lbGate3Total = new System.Windows.Forms.Label();
            this.lbGate2Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPcs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReportList
            // 
            this.dgvReportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dgvReportList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportList.Location = new System.Drawing.Point(45, 218);
            this.dgvReportList.Name = "dgvReportList";
            this.dgvReportList.ReadOnly = true;
            this.dgvReportList.RowHeadersVisible = false;
            this.dgvReportList.RowTemplate.Height = 35;
            this.dgvReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportList.Size = new System.Drawing.Size(748, 556);
            this.dgvReportList.TabIndex = 22;
            this.dgvReportList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReportList_CellMouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 32);
            this.label11.TabIndex = 23;
            this.label11.Text = "Report:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(29, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Recipe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Details:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvReportList;
            // 
            // dpkFrom
            // 
            this.dpkFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.dpkFrom.BorderRadius = 0;
            this.dpkFrom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkFrom.ForeColor = System.Drawing.Color.White;
            this.dpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpkFrom.FormatCustom = null;
            this.dpkFrom.Location = new System.Drawing.Point(130, 108);
            this.dpkFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkFrom.Name = "dpkFrom";
            this.dpkFrom.Size = new System.Drawing.Size(288, 32);
            this.dpkFrom.TabIndex = 64;
            this.dpkFrom.Value = new System.DateTime(2021, 6, 9, 15, 53, 31, 837);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "To:";
            // 
            // dpkTo
            // 
            this.dpkTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.dpkTo.BorderRadius = 0;
            this.dpkTo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkTo.ForeColor = System.Drawing.Color.White;
            this.dpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpkTo.FormatCustom = null;
            this.dpkTo.Location = new System.Drawing.Point(130, 158);
            this.dpkTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkTo.Name = "dpkTo";
            this.dpkTo.Size = new System.Drawing.Size(288, 32);
            this.dpkTo.TabIndex = 64;
            this.dpkTo.Value = new System.DateTime(2021, 6, 9, 15, 53, 31, 837);
            // 
            // tbRecipeID
            // 
            this.tbRecipeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRecipeID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbRecipeID.ForeColor = System.Drawing.Color.White;
            this.tbRecipeID.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbRecipeID.HintText = "";
            this.tbRecipeID.isPassword = false;
            this.tbRecipeID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.tbRecipeID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.tbRecipeID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.tbRecipeID.LineThickness = 3;
            this.tbRecipeID.Location = new System.Drawing.Point(532, 96);
            this.tbRecipeID.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipeID.Name = "tbRecipeID";
            this.tbRecipeID.Size = new System.Drawing.Size(261, 44);
            this.tbRecipeID.TabIndex = 63;
            this.tbRecipeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(446, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rcipe ID:";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(532, 158);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(261, 32);
            this.btSearch.TabIndex = 65;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbRecipeID
            // 
            this.lbRecipeID.AutoSize = true;
            this.lbRecipeID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecipeID.ForeColor = System.Drawing.Color.White;
            this.lbRecipeID.Location = new System.Drawing.Point(103, 71);
            this.lbRecipeID.Name = "lbRecipeID";
            this.lbRecipeID.Size = new System.Drawing.Size(34, 21);
            this.lbRecipeID.TabIndex = 56;
            this.lbRecipeID.Text = "xxx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(29, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "Start time:";
            // 
            // lbStarttime
            // 
            this.lbStarttime.AutoSize = true;
            this.lbStarttime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStarttime.ForeColor = System.Drawing.Color.White;
            this.lbStarttime.Location = new System.Drawing.Point(126, 110);
            this.lbStarttime.Name = "lbStarttime";
            this.lbStarttime.Size = new System.Drawing.Size(34, 21);
            this.lbStarttime.TabIndex = 56;
            this.lbStarttime.Text = "xxx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.label9.Location = new System.Drawing.Point(321, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 56;
            this.label9.Text = "Stop time:";
            // 
            // lbStoptime
            // 
            this.lbStoptime.AutoSize = true;
            this.lbStoptime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStoptime.ForeColor = System.Drawing.Color.White;
            this.lbStoptime.Location = new System.Drawing.Point(416, 110);
            this.lbStoptime.Name = "lbStoptime";
            this.lbStoptime.Size = new System.Drawing.Size(34, 21);
            this.lbStoptime.TabIndex = 56;
            this.lbStoptime.Text = "xxx";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.label12.Location = new System.Drawing.Point(588, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Running time:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(411, 71);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 21);
            this.lbTotal.TabIndex = 56;
            this.lbTotal.Text = "xxx";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.label14.Location = new System.Drawing.Point(321, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 21);
            this.label14.TabIndex = 56;
            this.label14.Text = "Total pcs:";
            // 
            // lbRunningtime
            // 
            this.lbRunningtime.AutoSize = true;
            this.lbRunningtime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRunningtime.ForeColor = System.Drawing.Color.White;
            this.lbRunningtime.Location = new System.Drawing.Point(711, 110);
            this.lbRunningtime.Name = "lbRunningtime";
            this.lbRunningtime.Size = new System.Drawing.Size(34, 21);
            this.lbRunningtime.TabIndex = 56;
            this.lbRunningtime.Text = "xxx";
            // 
            // chartTotalPcs
            // 
            this.chartTotalPcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartTotalPcs.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartTotalPcs.Legends.Add(legend1);
            this.chartTotalPcs.Location = new System.Drawing.Point(33, 138);
            this.chartTotalPcs.Name = "chartTotalPcs";
            this.chartTotalPcs.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Pcs";
            dataPoint1.Color = System.Drawing.Color.Red;
            dataPoint2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataPoint3.Color = System.Drawing.Color.Lime;
            dataPoint4.Color = System.Drawing.Color.Aqua;
            dataPoint5.Color = System.Drawing.Color.Silver;
            dataPoint6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            this.chartTotalPcs.Series.Add(series1);
            this.chartTotalPcs.Size = new System.Drawing.Size(789, 292);
            this.chartTotalPcs.TabIndex = 66;
            this.chartTotalPcs.Text = "chart1";
            // 
            // cirpbGate1
            // 
            this.cirpbGate1.animated = false;
            this.cirpbGate1.animationIterval = 5;
            this.cirpbGate1.animationSpeed = 300;
            this.cirpbGate1.BackColor = System.Drawing.Color.Transparent;
            this.cirpbGate1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cirpbGate1.BackgroundImage")));
            this.cirpbGate1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirpbGate1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cirpbGate1.LabelVisible = true;
            this.cirpbGate1.LineProgressThickness = 6;
            this.cirpbGate1.LineThickness = 2;
            this.cirpbGate1.Location = new System.Drawing.Point(44, 433);
            this.cirpbGate1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cirpbGate1.MaxValue = 100;
            this.cirpbGate1.Name = "cirpbGate1";
            this.cirpbGate1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cirpbGate1.ProgressColor = System.Drawing.Color.Aqua;
            this.cirpbGate1.Size = new System.Drawing.Size(93, 93);
            this.cirpbGate1.TabIndex = 67;
            this.cirpbGate1.Value = 50;
            // 
            // lbGate1Total
            // 
            this.lbGate1Total.AutoSize = true;
            this.lbGate1Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGate1Total.ForeColor = System.Drawing.Color.White;
            this.lbGate1Total.Location = new System.Drawing.Point(135, 460);
            this.lbGate1Total.Name = "lbGate1Total";
            this.lbGate1Total.Size = new System.Drawing.Size(36, 19);
            this.lbGate1Total.TabIndex = 56;
            this.lbGate1Total.Text = "xxx";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGray;
            this.label17.Location = new System.Drawing.Point(136, 482);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 56;
            this.label17.Text = "Gate 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cirpbGateRej);
            this.panel1.Controls.Add(this.cirpbGate5);
            this.panel1.Controls.Add(this.cirpbGate4);
            this.panel1.Controls.Add(this.cirpbGate3);
            this.panel1.Controls.Add(this.cirpbGate2);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.cirpbGate1);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.chartTotalPcs);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lbGateRejectTotal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbGate5Total);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.lbGate4Total);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbGate3Total);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lbGate2Total);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbGate1Total);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbRecipeID);
            this.panel1.Controls.Add(this.lbStoptime);
            this.panel1.Controls.Add(this.lbStarttime);
            this.panel1.Controls.Add(this.lbRunningtime);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Location = new System.Drawing.Point(828, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 666);
            this.panel1.TabIndex = 68;
            // 
            // cirpbGateRej
            // 
            this.cirpbGateRej.animated = false;
            this.cirpbGateRej.animationIterval = 5;
            this.cirpbGateRej.animationSpeed = 300;
            this.cirpbGateRej.BackColor = System.Drawing.Color.Transparent;
            this.cirpbGateRej.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cirpbGateRej.BackgroundImage")));
            this.cirpbGateRej.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirpbGateRej.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.cirpbGateRej.LabelVisible = true;
            this.cirpbGateRej.LineProgressThickness = 6;
            this.cirpbGateRej.LineThickness = 2;
            this.cirpbGateRej.Location = new System.Drawing.Point(625, 542);
            this.cirpbGateRej.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cirpbGateRej.MaxValue = 100;
            this.cirpbGateRej.Name = "cirpbGateRej";
            this.cirpbGateRej.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cirpbGateRej.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.cirpbGateRej.Size = new System.Drawing.Size(93, 93);
            this.cirpbGateRej.TabIndex = 67;
            this.cirpbGateRej.Value = 50;
            // 
            // cirpbGate5
            // 
            this.cirpbGate5.animated = false;
            this.cirpbGate5.animationIterval = 5;
            this.cirpbGate5.animationSpeed = 300;
            this.cirpbGate5.BackColor = System.Drawing.Color.Transparent;
            this.cirpbGate5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cirpbGate5.BackgroundImage")));
            this.cirpbGate5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirpbGate5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cirpbGate5.LabelVisible = true;
            this.cirpbGate5.LineProgressThickness = 6;
            this.cirpbGate5.LineThickness = 2;
            this.cirpbGate5.Location = new System.Drawing.Point(338, 542);
            this.cirpbGate5.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cirpbGate5.MaxValue = 100;
            this.cirpbGate5.Name = "cirpbGate5";
            this.cirpbGate5.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cirpbGate5.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cirpbGate5.Size = new System.Drawing.Size(93, 93);
            this.cirpbGate5.TabIndex = 67;
            this.cirpbGate5.Value = 50;
            // 
            // cirpbGate4
            // 
            this.cirpbGate4.animated = false;
            this.cirpbGate4.animationIterval = 5;
            this.cirpbGate4.animationSpeed = 300;
            this.cirpbGate4.BackColor = System.Drawing.Color.Transparent;
            this.cirpbGate4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cirpbGate4.BackgroundImage")));
            this.cirpbGate4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirpbGate4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.cirpbGate4.LabelVisible = true;
            this.cirpbGate4.LineProgressThickness = 6;
            this.cirpbGate4.LineThickness = 2;
            this.cirpbGate4.Location = new System.Drawing.Point(44, 542);
            this.cirpbGate4.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cirpbGate4.MaxValue = 100;
            this.cirpbGate4.Name = "cirpbGate4";
            this.cirpbGate4.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cirpbGate4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.cirpbGate4.Size = new System.Drawing.Size(93, 93);
            this.cirpbGate4.TabIndex = 67;
            this.cirpbGate4.Value = 50;
            // 
            // cirpbGate3
            // 
            this.cirpbGate3.animated = false;
            this.cirpbGate3.animationIterval = 5;
            this.cirpbGate3.animationSpeed = 300;
            this.cirpbGate3.BackColor = System.Drawing.Color.Transparent;
            this.cirpbGate3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cirpbGate3.BackgroundImage")));
            this.cirpbGate3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirpbGate3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.cirpbGate3.LabelVisible = true;
            this.cirpbGate3.LineProgressThickness = 6;
            this.cirpbGate3.LineThickness = 2;
            this.cirpbGate3.Location = new System.Drawing.Point(625, 433);
            this.cirpbGate3.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cirpbGate3.MaxValue = 100;
            this.cirpbGate3.Name = "cirpbGate3";
            this.cirpbGate3.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cirpbGate3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(76)))));
            this.cirpbGate3.Size = new System.Drawing.Size(93, 93);
            this.cirpbGate3.TabIndex = 67;
            this.cirpbGate3.Value = 50;
            // 
            // cirpbGate2
            // 
            this.cirpbGate2.animated = false;
            this.cirpbGate2.animationIterval = 5;
            this.cirpbGate2.animationSpeed = 300;
            this.cirpbGate2.BackColor = System.Drawing.Color.Transparent;
            this.cirpbGate2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cirpbGate2.BackgroundImage")));
            this.cirpbGate2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cirpbGate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.cirpbGate2.LabelVisible = true;
            this.cirpbGate2.LineProgressThickness = 6;
            this.cirpbGate2.LineThickness = 2;
            this.cirpbGate2.Location = new System.Drawing.Point(338, 433);
            this.cirpbGate2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cirpbGate2.MaxValue = 100;
            this.cirpbGate2.Name = "cirpbGate2";
            this.cirpbGate2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cirpbGate2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.cirpbGate2.Size = new System.Drawing.Size(93, 93);
            this.cirpbGate2.TabIndex = 67;
            this.cirpbGate2.Value = 50;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DarkGray;
            this.label27.Location = new System.Drawing.Point(717, 591);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 17);
            this.label27.TabIndex = 56;
            this.label27.Text = "Gate Reject";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkGray;
            this.label25.Location = new System.Drawing.Point(430, 591);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 17);
            this.label25.TabIndex = 56;
            this.label25.Text = "Gate 5";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkGray;
            this.label23.Location = new System.Drawing.Point(136, 591);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 17);
            this.label23.TabIndex = 56;
            this.label23.Text = "Gate 4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkGray;
            this.label21.Location = new System.Drawing.Point(717, 482);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 17);
            this.label21.TabIndex = 56;
            this.label21.Text = "Gate 3";
            // 
            // lbGateRejectTotal
            // 
            this.lbGateRejectTotal.AutoSize = true;
            this.lbGateRejectTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGateRejectTotal.ForeColor = System.Drawing.Color.White;
            this.lbGateRejectTotal.Location = new System.Drawing.Point(716, 569);
            this.lbGateRejectTotal.Name = "lbGateRejectTotal";
            this.lbGateRejectTotal.Size = new System.Drawing.Size(36, 19);
            this.lbGateRejectTotal.TabIndex = 56;
            this.lbGateRejectTotal.Text = "xxx";
            // 
            // lbGate5Total
            // 
            this.lbGate5Total.AutoSize = true;
            this.lbGate5Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGate5Total.ForeColor = System.Drawing.Color.White;
            this.lbGate5Total.Location = new System.Drawing.Point(429, 569);
            this.lbGate5Total.Name = "lbGate5Total";
            this.lbGate5Total.Size = new System.Drawing.Size(36, 19);
            this.lbGate5Total.TabIndex = 56;
            this.lbGate5Total.Text = "xxx";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkGray;
            this.label19.Location = new System.Drawing.Point(430, 482);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 17);
            this.label19.TabIndex = 56;
            this.label19.Text = "Gate 2";
            // 
            // lbGate4Total
            // 
            this.lbGate4Total.AutoSize = true;
            this.lbGate4Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGate4Total.ForeColor = System.Drawing.Color.White;
            this.lbGate4Total.Location = new System.Drawing.Point(135, 569);
            this.lbGate4Total.Name = "lbGate4Total";
            this.lbGate4Total.Size = new System.Drawing.Size(36, 19);
            this.lbGate4Total.TabIndex = 56;
            this.lbGate4Total.Text = "xxx";
            // 
            // lbGate3Total
            // 
            this.lbGate3Total.AutoSize = true;
            this.lbGate3Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGate3Total.ForeColor = System.Drawing.Color.White;
            this.lbGate3Total.Location = new System.Drawing.Point(716, 460);
            this.lbGate3Total.Name = "lbGate3Total";
            this.lbGate3Total.Size = new System.Drawing.Size(36, 19);
            this.lbGate3Total.TabIndex = 56;
            this.lbGate3Total.Text = "xxx";
            // 
            // lbGate2Total
            // 
            this.lbGate2Total.AutoSize = true;
            this.lbGate2Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGate2Total.ForeColor = System.Drawing.Color.White;
            this.lbGate2Total.Location = new System.Drawing.Point(429, 460);
            this.lbGate2Total.Name = "lbGate2Total";
            this.lbGate2Total.Size = new System.Drawing.Size(36, 19);
            this.lbGate2Total.TabIndex = 56;
            this.lbGate2Total.Text = "xxx";
            // 
            // ucReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.dpkTo);
            this.Controls.Add(this.dpkFrom);
            this.Controls.Add(this.tbRecipeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvReportList);
            this.Name = "ucReport";
            this.Size = new System.Drawing.Size(1710, 805);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPcs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDatepicker dpkFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dpkTo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbRecipeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbRecipeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbStarttime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbStoptime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbRunningtime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalPcs;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cirpbGate1;
        private System.Windows.Forms.Label lbGate1Total;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cirpbGate2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbGate2Total;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cirpbGate3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbGate3Total;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cirpbGate4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbGate4Total;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cirpbGate5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbGate5Total;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cirpbGateRej;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbGateRejectTotal;
    }
}
