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

namespace AutoSortingSystem.Admin.Views
{
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();

            var _userList = UserService.Ins.GetUserList();           
            if (_userList != null)
            {
                dgvUserList.DataSource = _userList;
            }
            SetDataGridViewProperties(dgvUserList);
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert fa = new Form_Alert();
            fa.showAlert(msg, type);
        }

        private void SetDataGridViewProperties(DataGridView dgv)
        {
            //dgv.DataSource = UserService.Ins.GetUserList();
            dgv.Font = new Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#454545");
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#333333");
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 98, 209);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
        }

        private void dgvUserList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string userGuid = dgvUserList.SelectedCells[0].Value.ToString();
            var userInfo = UserService.Ins.GetUserInfo(userGuid);
            if (userInfo != null)
            {
                tbID.Text = userInfo.ID.ToString();
                tbUserName.Text = userInfo.UserName;
                tbEmail.Text = userInfo.Email;
                tbPhoneNo.Text = userInfo.PhoneNo;
                tbFirstName.Text = userInfo.FirstName;
                tbLastName.Text = userInfo.LastName;
                tbDob.Text = userInfo.Dob.ToString("yyyy-MM-dd");
                cbActive.Checked = userInfo.Active;
                switch (userInfo.Role)
                {
                    case "Admin":
                        ddRole.selectedIndex = 0;
                        break;
                    case "Manager":
                        ddRole.selectedIndex = 1;
                        break;
                    case "Operator":
                        ddRole.selectedIndex = 2;
                        break;
                }               
            }           
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure to update user?", "Warning", MessageBoxButtons.YesNo);
            if (diag.Equals(DialogResult.Yes))
            {
                var userUpdate = new UserInfoVM()
                {
                    ID = Guid.Parse(tbID.Text),
                    UserName = tbUserName.Text,
                    Email = tbEmail.Text,
                    PhoneNo = tbPhoneNo.Text,
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Dob = DateTime.Parse(tbDob.Text),
                    Active = cbActive.Checked,
                    Role = ddRole.selectedValue,
                };
                var res = UserService.Ins.UpdateUserInfo(userUpdate);
                if (res)
                {
                    Alert("Update user successed", Form_Alert.enmType.Success);
                }
                else
                {
                    Alert("Update user failed", Form_Alert.enmType.Error);
                }
                dgvUserList.DataSource = UserService.Ins.GetUserList();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure to delete user?", "Warning", MessageBoxButtons.YesNo);
            if (diag.Equals(DialogResult.Yes))
            {
                var res = UserService.Ins.DeleteUser(Guid.Parse(tbID.Text));
                if (res)
                {
                    Alert("Delete user successed", Form_Alert.enmType.Success);
                }
                else
                {
                    Alert("Delete user failed", Form_Alert.enmType.Error);
                }
                dgvUserList.DataSource = UserService.Ins.GetUserList();
            }
        }

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            pnResetPassword.Visible = true;
        }

        private void lbCloseNewPass_Click(object sender, EventArgs e)
        {
            pnResetPassword.Visible = false;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            var res = UserService.Ins.NewPassword(Guid.Parse(tbID.Text), tbNewPassword.Text);
            if (res)
            {
                Alert("Update password successed", Form_Alert.enmType.Success);
            }
            else
            {
                Alert("Update password failed", Form_Alert.enmType.Error);
            }
            pnResetPassword.Visible = false;
            dgvUserList.DataSource = UserService.Ins.GetUserList();
        }
    }
}
