
namespace AutoSortingSystem.Admin.Views
{
    partial class ucAdmin
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
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPhoneNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbDob = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.cbActive = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddRole = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnResetPassword = new System.Windows.Forms.Panel();
            this.lbCloseNewPass = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btResetPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.pnResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserList
            // 
            this.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.Location = new System.Drawing.Point(45, 85);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowHeadersVisible = false;
            this.dgvUserList.RowTemplate.Height = 45;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(974, 612);
            this.dgvUserList.TabIndex = 22;
            this.dgvUserList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserList_CellMouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 32);
            this.label11.TabIndex = 23;
            this.label11.Text = "User Management:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label8.Location = new System.Drawing.Point(1181, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Phone No:";
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPhoneNo.ForeColor = System.Drawing.Color.White;
            this.tbPhoneNo.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPhoneNo.HintText = "";
            this.tbPhoneNo.isPassword = false;
            this.tbPhoneNo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbPhoneNo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbPhoneNo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbPhoneNo.LineThickness = 3;
            this.tbPhoneNo.Location = new System.Drawing.Point(1185, 463);
            this.tbPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(415, 44);
            this.tbPhoneNo.TabIndex = 57;
            this.tbPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(1181, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Date of birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label7.Location = new System.Drawing.Point(1181, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label10.Location = new System.Drawing.Point(1413, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 54;
            this.label10.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label9.Location = new System.Drawing.Point(1181, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 55;
            this.label9.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label4.Location = new System.Drawing.Point(1181, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "User Name:";
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbEmail.HintText = "";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbEmail.LineThickness = 3;
            this.tbEmail.Location = new System.Drawing.Point(1185, 312);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(415, 44);
            this.tbEmail.TabIndex = 60;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbLastName
            // 
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbLastName.ForeColor = System.Drawing.Color.White;
            this.tbLastName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbLastName.HintText = "";
            this.tbLastName.isPassword = false;
            this.tbLastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbLastName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbLastName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbLastName.LineThickness = 3;
            this.tbLastName.Location = new System.Drawing.Point(1417, 169);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(183, 44);
            this.tbLastName.TabIndex = 61;
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbFirstName.HintText = "";
            this.tbFirstName.isPassword = false;
            this.tbFirstName.LineFocusedColor = System.Drawing.Color.Empty;
            this.tbFirstName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbFirstName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbFirstName.LineThickness = 3;
            this.tbFirstName.Location = new System.Drawing.Point(1185, 169);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(183, 44);
            this.tbFirstName.TabIndex = 62;
            this.tbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUserName
            // 
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUserName.ForeColor = System.Drawing.Color.White;
            this.tbUserName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbUserName.HintText = "";
            this.tbUserName.isPassword = false;
            this.tbUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbUserName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbUserName.LineThickness = 3;
            this.tbUserName.Location = new System.Drawing.Point(1185, 241);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(415, 44);
            this.tbUserName.TabIndex = 63;
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbDob
            // 
            this.tbDob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDob.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbDob.ForeColor = System.Drawing.Color.White;
            this.tbDob.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbDob.HintText = "";
            this.tbDob.isPassword = false;
            this.tbDob.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbDob.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbDob.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbDob.LineThickness = 3;
            this.tbDob.Location = new System.Drawing.Point(1185, 388);
            this.tbDob.Margin = new System.Windows.Forms.Padding(4);
            this.tbDob.Name = "tbDob";
            this.tbDob.Size = new System.Drawing.Size(415, 44);
            this.tbDob.TabIndex = 57;
            this.tbDob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(1185, 656);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(187, 41);
            this.btUpdate.TabIndex = 64;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // cbActive
            // 
            this.cbActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.cbActive.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbActive.Checked = true;
            this.cbActive.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.cbActive.ForeColor = System.Drawing.Color.White;
            this.cbActive.Location = new System.Drawing.Point(1395, 529);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(20, 20);
            this.cbActive.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(1181, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Active:";
            // 
            // ddRole
            // 
            this.ddRole.BackColor = System.Drawing.Color.Transparent;
            this.ddRole.BorderRadius = 3;
            this.ddRole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddRole.ForeColor = System.Drawing.Color.White;
            this.ddRole.Items = new string[] {
        "Admin",
        "Manager",
        "Operator"};
            this.ddRole.Location = new System.Drawing.Point(1185, 593);
            this.ddRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddRole.Name = "ddRole";
            this.ddRole.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.ddRole.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.ddRole.selectedIndex = -1;
            this.ddRole.Size = new System.Drawing.Size(415, 33);
            this.ddRole.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(1181, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Role:";
            // 
            // tbID
            // 
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbID.ForeColor = System.Drawing.Color.White;
            this.tbID.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbID.HintText = "";
            this.tbID.isPassword = false;
            this.tbID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.tbID.LineThickness = 3;
            this.tbID.Location = new System.Drawing.Point(1185, 93);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(415, 44);
            this.tbID.TabIndex = 63;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(209)))));
            this.label5.Location = new System.Drawing.Point(1181, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1179, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "User Info:";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(1378, 656);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(108, 41);
            this.btDelete.TabIndex = 64;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvUserList;
            // 
            // pnResetPassword
            // 
            this.pnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnResetPassword.Controls.Add(this.lbCloseNewPass);
            this.pnResetPassword.Controls.Add(this.btConfirm);
            this.pnResetPassword.Controls.Add(this.label12);
            this.pnResetPassword.Controls.Add(this.tbNewPassword);
            this.pnResetPassword.Location = new System.Drawing.Point(765, 268);
            this.pnResetPassword.Name = "pnResetPassword";
            this.pnResetPassword.Size = new System.Drawing.Size(280, 164);
            this.pnResetPassword.TabIndex = 67;
            this.pnResetPassword.Visible = false;
            // 
            // lbCloseNewPass
            // 
            this.lbCloseNewPass.AutoSize = true;
            this.lbCloseNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbCloseNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCloseNewPass.ForeColor = System.Drawing.Color.White;
            this.lbCloseNewPass.Location = new System.Drawing.Point(252, 8);
            this.lbCloseNewPass.Name = "lbCloseNewPass";
            this.lbCloseNewPass.Size = new System.Drawing.Size(18, 19);
            this.lbCloseNewPass.TabIndex = 56;
            this.lbCloseNewPass.Text = "x";
            this.lbCloseNewPass.Click += new System.EventHandler(this.lbCloseNewPass_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.ForeColor = System.Drawing.Color.White;
            this.btConfirm.Location = new System.Drawing.Point(68, 111);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(145, 36);
            this.btConfirm.TabIndex = 64;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 39);
            this.label12.TabIndex = 56;
            this.label12.Text = "   New Password:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNewPassword.ForeColor = System.Drawing.Color.White;
            this.tbNewPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbNewPassword.HintText = "";
            this.tbNewPassword.isPassword = false;
            this.tbNewPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbNewPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbNewPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbNewPassword.LineThickness = 3;
            this.tbNewPassword.Location = new System.Drawing.Point(13, 51);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(254, 44);
            this.tbNewPassword.TabIndex = 63;
            this.tbNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btResetPassword
            // 
            this.btResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetPassword.ForeColor = System.Drawing.Color.White;
            this.btResetPassword.Location = new System.Drawing.Point(1492, 656);
            this.btResetPassword.Name = "btResetPassword";
            this.btResetPassword.Size = new System.Drawing.Size(108, 41);
            this.btResetPassword.TabIndex = 64;
            this.btResetPassword.Text = "Reset Pass";
            this.btResetPassword.UseVisualStyleBackColor = false;
            this.btResetPassword.Click += new System.EventHandler(this.btResetPassword_Click);
            // 
            // ucAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnResetPassword);
            this.Controls.Add(this.ddRole);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.btResetPassword);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPhoneNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvUserList);
            this.Controls.Add(this.tbDob);
            this.Name = "ucAdmin";
            this.Size = new System.Drawing.Size(1710, 805);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.pnResetPassword.ResumeLayout(false);
            this.pnResetPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPhoneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbDob;
        private System.Windows.Forms.Button btUpdate;
        private Bunifu.Framework.UI.BunifuCheckbox cbActive;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown ddRole;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDelete;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnResetPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbCloseNewPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPassword;
        private System.Windows.Forms.Button btResetPassword;
    }
}
