using AutoSortingSystem.Admin.Properties;
using AutoSortingSystem.Application.Service;
using AutoSortingSystem.Data.Entities;
using AutoSortingSystem.Views;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AutoSortingSystem.Admin.Views
{
    public partial class FormMain : Form
    {
        bool iniLoad;
        public FormMain()
        {
            InitializeComponent();

            ucHome.BringToFront();
            lbUser.Text = "Hi! " + Settings.Default.User;
            tmrIni.Enabled = true;
            tmrDatetime.Enabled = true;
            iniLoad = true;
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert fa = new Form_Alert();
            fa.showAlert(msg, type);
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            btHome.BackColor = Color.FromArgb(69,69,69);
            btHome.color = Color.FromArgb(69,69,69);
            btHome.colorActive = Color.FromArgb(33, 33, 33);

            btReport.BackColor = Color.FromArgb(102, 187, 106);
            btReport.color = Color.FromArgb(102, 187, 106);
            btReport.colorActive = Color.FromArgb(76, 175, 80);

            btAudit.BackColor = Color.FromArgb(102, 187, 106);
            btAudit.color = Color.FromArgb(102, 187, 106);
            btAudit.colorActive = Color.FromArgb(76, 175, 80);

            btAdmin.BackColor = Color.FromArgb(102, 187, 106);
            btAdmin.color = Color.FromArgb(102, 187, 106);
            btAdmin.colorActive = Color.FromArgb(76, 175, 80);

            ucHome.BringToFront();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            btReport.BackColor = Color.FromArgb(69, 69, 69);
            btReport.color = Color.FromArgb(69, 69, 69);
            btReport.colorActive = Color.FromArgb(33, 33, 33);

            btHome.BackColor = Color.FromArgb(102, 187, 106);
            btHome.color = Color.FromArgb(102, 187, 106);
            btHome.colorActive = Color.FromArgb(76, 175, 80);

            btAudit.BackColor = Color.FromArgb(102, 187, 106);
            btAudit.color = Color.FromArgb(102, 187, 106);
            btAudit.colorActive = Color.FromArgb(76, 175, 80);

            btAdmin.BackColor = Color.FromArgb(102, 187, 106);
            btAdmin.color = Color.FromArgb(102, 187, 106);
            btAdmin.colorActive = Color.FromArgb(76, 175, 80);

            ucReport.BringToFront();
        }

        private void btAudit_Click(object sender, EventArgs e)
        {
            btAudit.BackColor = Color.FromArgb(69, 69, 69);
            btAudit.color = Color.FromArgb(69, 69, 69);
            btAudit.colorActive = Color.FromArgb(33, 33, 33);

            btReport.BackColor = Color.FromArgb(102, 187, 106);
            btReport.color = Color.FromArgb(102, 187, 106);
            btReport.colorActive = Color.FromArgb(76, 175, 80);

            btHome.BackColor = Color.FromArgb(102, 187, 106);
            btHome.color = Color.FromArgb(102, 187, 106);
            btHome.colorActive = Color.FromArgb(76, 175, 80);

            btAdmin.BackColor = Color.FromArgb(102, 187, 106);
            btAdmin.color = Color.FromArgb(102, 187, 106);
            btAdmin.colorActive = Color.FromArgb(76, 175, 80);

            ucAudit.BringToFront();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User == "admin")
            {
                btAdmin.BackColor = Color.FromArgb(69, 69, 69);
                btAdmin.color = Color.FromArgb(69, 69, 69);
                btAdmin.colorActive = Color.FromArgb(33, 33, 33);

                btReport.BackColor = Color.FromArgb(102, 187, 106);
                btReport.color = Color.FromArgb(102, 187, 106);
                btReport.colorActive = Color.FromArgb(76, 175, 80);

                btAudit.BackColor = Color.FromArgb(102, 187, 106);
                btAudit.color = Color.FromArgb(102, 187, 106);
                btAudit.colorActive = Color.FromArgb(76, 175, 80);

                btHome.BackColor = Color.FromArgb(102, 187, 106);
                btHome.color = Color.FromArgb(102, 187, 106);
                btHome.colorActive = Color.FromArgb(76, 175, 80);

                ucAdmin.BringToFront();
            }
            else
            {
                Alert("Only Admin can use this function", Form_Alert.enmType.Warning);
            }
        }

        private void lbUser_MouseHover(object sender, EventArgs e)
        {
            lbUser.Font = new Font(lbUser.Font, FontStyle.Underline);
            lbUser.ForeColor = Color.FromArgb(102, 187, 106);
        }

        private void lbUser_MouseLeave(object sender, EventArgs e)
        {
            lbUser.Font = new Font(lbUser.Font, FontStyle.Regular);
            lbUser.ForeColor = Color.White;
        }

        private void lbUser_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you want to sign out?", "Confirm sign out", MessageBoxButtons.YesNo);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AuditService.Ins.Record(Settings.Default.User, "Logout");
                this.Hide();
                var fLogin = new FormLogin();
                fLogin.ShowDialog();
                this.Close();
            }         
        }

        private void tmrIni_Tick(object sender, EventArgs e)
        {
            if (iniLoad)
            {
                Alert("Welcome back " + Settings.Default.User + "! Have a nice day!", Form_Alert.enmType.Info);
                iniLoad = false;
                tmrIni.Interval = 10000;
            }
            var res = PLC.Instance().CheckPlcConnection();
            if (res)
            {
                pbPLCStatus.BackgroundImage = Resources.green_circle_100px;
            }
            else
            {
                pbPLCStatus.BackgroundImage = Resources.red_circle_100px;
            }
            var sqlStatus = SqlService.Ins.CheckSqlConnection();
            if (sqlStatus)
            {
                pbSqlStatus.BackgroundImage = Resources.green_circle_100px;
            }
            else
            {
                pbSqlStatus.BackgroundImage = Resources.red_circle_100px;
            }
        }

        private void tmrDatetime_Tick(object sender, EventArgs e)
        {
            lbDatetime.Text = DateTime.Now.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
