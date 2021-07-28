
namespace AutoSortingSystem.Admin.Views
{
    partial class ucAudit
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
            this.dgvAuditReport = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btSearch = new System.Windows.Forms.Button();
            this.dpkTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpkFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tbUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditReport
            // 
            this.dgvAuditReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dgvAuditReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuditReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuditReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuditReport.Location = new System.Drawing.Point(888, 114);
            this.dgvAuditReport.Name = "dgvAuditReport";
            this.dgvAuditReport.ReadOnly = true;
            this.dgvAuditReport.RowHeadersVisible = false;
            this.dgvAuditReport.RowTemplate.Height = 45;
            this.dgvAuditReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditReport.Size = new System.Drawing.Size(762, 464);
            this.dgvAuditReport.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 32);
            this.label11.TabIndex = 23;
            this.label11.Text = "Audit Report:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvAuditReport;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(532, 164);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(261, 32);
            this.btSearch.TabIndex = 72;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dpkTo
            // 
            this.dpkTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.dpkTo.BorderRadius = 0;
            this.dpkTo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkTo.ForeColor = System.Drawing.Color.White;
            this.dpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpkTo.FormatCustom = null;
            this.dpkTo.Location = new System.Drawing.Point(130, 164);
            this.dpkTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkTo.Name = "dpkTo";
            this.dpkTo.Size = new System.Drawing.Size(288, 32);
            this.dpkTo.TabIndex = 70;
            this.dpkTo.Value = new System.DateTime(2021, 6, 9, 15, 53, 31, 837);
            // 
            // dpkFrom
            // 
            this.dpkFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.dpkFrom.BorderRadius = 0;
            this.dpkFrom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkFrom.ForeColor = System.Drawing.Color.White;
            this.dpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpkFrom.FormatCustom = null;
            this.dpkFrom.Location = new System.Drawing.Point(130, 114);
            this.dpkFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkFrom.Name = "dpkFrom";
            this.dpkFrom.Size = new System.Drawing.Size(288, 32);
            this.dpkFrom.TabIndex = 71;
            this.dpkFrom.Value = new System.DateTime(2021, 6, 9, 15, 53, 31, 837);
            // 
            // tbUser
            // 
            this.tbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUser.ForeColor = System.Drawing.Color.White;
            this.tbUser.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbUser.HintText = "";
            this.tbUser.isPassword = false;
            this.tbUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.tbUser.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.tbUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.tbUser.LineThickness = 3;
            this.tbUser.Location = new System.Drawing.Point(532, 102);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(261, 44);
            this.tbUser.TabIndex = 69;
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 66;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(446, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 67;
            this.label3.Text = "Rcipe ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "From:";
            // 
            // ucAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.dpkTo);
            this.Controls.Add(this.dpkFrom);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvAuditReport);
            this.Name = "ucAudit";
            this.Size = new System.Drawing.Size(1710, 805);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditReport;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btSearch;
        private Bunifu.Framework.UI.BunifuDatepicker dpkTo;
        private Bunifu.Framework.UI.BunifuDatepicker dpkFrom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
