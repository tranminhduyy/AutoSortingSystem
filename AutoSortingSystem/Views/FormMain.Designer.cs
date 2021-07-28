
namespace AutoSortingSystem.Admin.Views
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btReport = new Bunifu.Framework.UI.BunifuTileButton();
            this.btAdmin = new Bunifu.Framework.UI.BunifuTileButton();
            this.btAudit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.tmrIni = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipseMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDatetime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbSqlStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbPLCStatus = new System.Windows.Forms.PictureBox();
            this.tmrDatetime = new System.Windows.Forms.Timer(this.components);
            this.ucAdmin = new AutoSortingSystem.Admin.Views.ucAdmin();
            this.ucHome = new AutoSortingSystem.Admin.Views.ucHome();
            this.ucReport = new AutoSortingSystem.Admin.Views.ucReport();
            this.ucAudit = new AutoSortingSystem.Admin.Views.ucAudit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSqlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPLCStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.btMinimize);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1820, 80);
            this.panel1.TabIndex = 2;
            // 
            // btMinimize
            // 
            this.btMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btMinimize.BackgroundImage = global::AutoSortingSystem.Admin.Properties.Resources.minimize_window_100px;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMinimize.Location = new System.Drawing.Point(1745, 7);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(34, 34);
            this.btMinimize.TabIndex = 31;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btClose.Location = new System.Drawing.Point(1781, 9);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 31;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1467, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 53);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1201, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome To Our Automatic Sorting System";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(1241, 28);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(71, 21);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Minh Di";
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            this.lbUser.MouseLeave += new System.EventHandler(this.lbUser_MouseLeave);
            this.lbUser.MouseHover += new System.EventHandler(this.lbUser_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DHL - Dalsey Hillblom Lynn";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.panel6.Controls.Add(this.btReport);
            this.panel6.Controls.Add(this.btAdmin);
            this.panel6.Controls.Add(this.btAudit);
            this.panel6.Controls.Add(this.btHome);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(80, 900);
            this.panel6.TabIndex = 3;
            // 
            // btReport
            // 
            this.btReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btReport.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btReport.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.ForeColor = System.Drawing.Color.White;
            this.btReport.Image = ((System.Drawing.Image)(resources.GetObject("btReport.Image")));
            this.btReport.ImagePosition = 29;
            this.btReport.ImageZoom = 30;
            this.btReport.LabelPosition = 39;
            this.btReport.LabelText = "Report";
            this.btReport.Location = new System.Drawing.Point(0, 88);
            this.btReport.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(80, 89);
            this.btReport.TabIndex = 29;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btAdmin.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btAdmin.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin.ForeColor = System.Drawing.Color.White;
            this.btAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btAdmin.Image")));
            this.btAdmin.ImagePosition = 29;
            this.btAdmin.ImageZoom = 30;
            this.btAdmin.LabelPosition = 39;
            this.btAdmin.LabelText = "Admin";
            this.btAdmin.Location = new System.Drawing.Point(0, 266);
            this.btAdmin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(80, 89);
            this.btAdmin.TabIndex = 30;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btAudit
            // 
            this.btAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btAudit.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btAudit.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btAudit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAudit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAudit.ForeColor = System.Drawing.Color.White;
            this.btAudit.Image = ((System.Drawing.Image)(resources.GetObject("btAudit.Image")));
            this.btAudit.ImagePosition = 29;
            this.btAudit.ImageZoom = 30;
            this.btAudit.LabelPosition = 39;
            this.btAudit.LabelText = "Audit";
            this.btAudit.Location = new System.Drawing.Point(0, 177);
            this.btAudit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btAudit.Name = "btAudit";
            this.btAudit.Size = new System.Drawing.Size(80, 89);
            this.btAudit.TabIndex = 31;
            this.btAudit.Click += new System.EventHandler(this.btAudit_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btHome.color = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btHome.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImagePosition = 29;
            this.btHome.ImageZoom = 30;
            this.btHome.LabelPosition = 39;
            this.btHome.LabelText = "Home";
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(80, 89);
            this.btHome.TabIndex = 28;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // tmrIni
            // 
            this.tmrIni.Interval = 1000;
            this.tmrIni.Tick += new System.EventHandler(this.tmrIni_Tick);
            // 
            // bunifuElipseMain
            // 
            this.bunifuElipseMain.ElipseRadius = 20;
            this.bunifuElipseMain.TargetControl = this;
            // 
            // bunifuDragMain
            // 
            this.bunifuDragMain.Fixed = true;
            this.bunifuDragMain.Horizontal = true;
            this.bunifuDragMain.TargetControl = this.panel1;
            this.bunifuDragMain.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbDatetime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pbSqlStatus);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pbPLCStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(80, 940);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1740, 40);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1411, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Developed by New Ocean R&D Dpt.";
            this.label6.UseMnemonic = false;
            // 
            // lbDatetime
            // 
            this.lbDatetime.AutoSize = true;
            this.lbDatetime.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatetime.ForeColor = System.Drawing.Color.White;
            this.lbDatetime.Location = new System.Drawing.Point(638, 9);
            this.lbDatetime.Name = "lbDatetime";
            this.lbDatetime.Size = new System.Drawing.Size(197, 21);
            this.lbDatetime.TabIndex = 0;
            this.lbDatetime.Text = "28/06/2021 03:24:56 pm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(225, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "SQL Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "PLC Status:";
            // 
            // pbSqlStatus
            // 
            this.pbSqlStatus.BackColor = System.Drawing.Color.Transparent;
            this.pbSqlStatus.BackgroundImage = global::AutoSortingSystem.Admin.Properties.Resources.green_circle_100px;
            this.pbSqlStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSqlStatus.Location = new System.Drawing.Point(334, 5);
            this.pbSqlStatus.Name = "pbSqlStatus";
            this.pbSqlStatus.Size = new System.Drawing.Size(30, 30);
            this.pbSqlStatus.TabIndex = 24;
            this.pbSqlStatus.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::AutoSortingSystem.Admin.Properties.Resources.rocket_480px;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1375, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pbPLCStatus
            // 
            this.pbPLCStatus.BackColor = System.Drawing.Color.Transparent;
            this.pbPLCStatus.BackgroundImage = global::AutoSortingSystem.Admin.Properties.Resources.green_circle_100px;
            this.pbPLCStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPLCStatus.Location = new System.Drawing.Point(129, 5);
            this.pbPLCStatus.Name = "pbPLCStatus";
            this.pbPLCStatus.Size = new System.Drawing.Size(30, 30);
            this.pbPLCStatus.TabIndex = 24;
            this.pbPLCStatus.TabStop = false;
            // 
            // tmrDatetime
            // 
            this.tmrDatetime.Interval = 1000;
            this.tmrDatetime.Tick += new System.EventHandler(this.tmrDatetime_Tick);
            // 
            // ucAdmin
            // 
            this.ucAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ucAdmin.Location = new System.Drawing.Point(91, 91);
            this.ucAdmin.Name = "ucAdmin";
            this.ucAdmin.Size = new System.Drawing.Size(1710, 805);
            this.ucAdmin.TabIndex = 28;
            // 
            // ucHome
            // 
            this.ucHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ucHome.Location = new System.Drawing.Point(91, 91);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(1710, 805);
            this.ucHome.TabIndex = 26;
            // 
            // ucReport
            // 
            this.ucReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ucReport.Location = new System.Drawing.Point(91, 91);
            this.ucReport.Name = "ucReport";
            this.ucReport.Size = new System.Drawing.Size(1710, 805);
            this.ucReport.TabIndex = 29;
            // 
            // ucAudit
            // 
            this.ucAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ucAudit.Location = new System.Drawing.Point(91, 91);
            this.ucAudit.Name = "ucAudit";
            this.ucAudit.Size = new System.Drawing.Size(1710, 805);
            this.ucAudit.TabIndex = 30;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1820, 980);
            this.Controls.Add(this.ucAudit);
            this.Controls.Add(this.ucReport);
            this.Controls.Add(this.ucAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucHome);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSqlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPLCStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuTileButton btHome;
        private Bunifu.Framework.UI.BunifuTileButton btReport;
        private Bunifu.Framework.UI.BunifuTileButton btAdmin;
        private Bunifu.Framework.UI.BunifuTileButton btAudit;
        private System.Windows.Forms.Timer tmrIni;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMain;
        private System.Windows.Forms.Button btClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbUser;
        private ucHome ucHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPLCStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbSqlStatus;
        private System.Windows.Forms.Label lbDatetime;
        private System.Windows.Forms.Timer tmrDatetime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ucAdmin ucAdmin;
        private System.Windows.Forms.Button btMinimize;
        private ucReport ucReport;
        private ucAudit ucAudit;
    }
}