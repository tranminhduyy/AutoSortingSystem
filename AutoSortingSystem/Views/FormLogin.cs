using AutoSortingSystem.Application.Service;
using AutoSortingSystem.Admin.Properties;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert fa = new Form_Alert();
            fa.showAlert(msg, type);
        }

        private void lbCreateAccount_Click(object sender, EventArgs e)
        {
            var fRegister = new FormRegister();
            fRegister.Show();
        }

        private void lbCreateAccount_MouseHover(object sender, EventArgs e)
        {
            lbCreateAccount.ForeColor = Color.Blue;
        }

        private void lbCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lbCreateAccount.ForeColor = Color.FromArgb(102, 187, 106);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(1);
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            var res = UserService.Ins.Login(tbUsername.Text, tbPassword.Text);
            if (res == "")
            {
                Alert("Sign in failed", Form_Alert.enmType.Error);
            }
            else if (res == "Not active")
            {
                Alert("Please contact admin to active your account", Form_Alert.enmType.Info);
            }
            else
            {
                Settings.Default.User = res;
                AuditService.Ins.Record(res, "Login");
                this.Hide();
                var fMain = new FormMain();
                fMain.ShowDialog();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var res = UserService.Ins.Login(tbUsername.Text, tbPassword.Text);
                if (res == "")
                {
                    Alert("Sign in failed", Form_Alert.enmType.Error);
                }
                else if (res == "Not active")
                {
                    Alert("Please contact admin to active your account", Form_Alert.enmType.Info);
                }
                else
                {
                    Settings.Default.User = res;
                    AuditService.Ins.Record(res, "Login");
                    this.Hide();
                    var fMain = new FormMain();
                    fMain.ShowDialog();
                }
            }
        }

        private void tbPassword_OnValueChanged(object sender, EventArgs e)
        {
            tbPassword.isPassword = true;
        }     
    }
}
