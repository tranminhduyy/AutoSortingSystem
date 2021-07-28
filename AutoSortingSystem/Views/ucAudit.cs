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
    public partial class ucAudit : UserControl
    {
        public ucAudit()
        {
            InitializeComponent();

            SetDataGridViewProperties(dgvAuditReport);
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
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 98, 209);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var res = AuditService.Ins.GetReportAudit(dpkFrom.Value, dpkTo.Value, tbUser.Text);
            if (res != null)
            {
                dgvAuditReport.DataSource = res;
            }            
        }
    }
}
