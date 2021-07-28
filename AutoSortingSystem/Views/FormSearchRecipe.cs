using AutoSortingSystem.Admin.Views;
using AutoSortingSystem.Application.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSortingSystem.Views
{
    public partial class FormSearchRecipe : Form
    {
        ucHome _ucHome;
        public FormSearchRecipe(ucHome ucHome)
        {
            _ucHome = ucHome;
            InitializeComponent();

            SetDataGridViewProperties(dgvRecipeList);
            var recipeList = RecipeService.Ins.GetRecipe("");
            if (recipeList != null)
            {
                dgvRecipeList.DataSource = recipeList;
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert fa = new Form_Alert();
            fa.showAlert(msg, type);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var recipeList = RecipeService.Ins.GetRecipe(tbSearch.Text);
                if (recipeList != null)
                {
                    dgvRecipeList.DataSource = recipeList;
                }
            }
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            if (dgvRecipeList.SelectedRows.Count == 1)
            {
                string recipe = dgvRecipeList.SelectedCells[1].Value.ToString();
                string importDate = dgvRecipeList.SelectedCells[2].Value.ToString();
                _ucHome.GetRecipeFromSearchEngine(recipe, importDate);
                
                this.Close();
            }      
            else
            {
                Alert("Please select only 1 row", Form_Alert.enmType.Error);
            }    
        }

        private void dgvRecipeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvRecipeList.SelectedRows.Count == 1)
            {
                string recipe = dgvRecipeList.SelectedCells[1].Value.ToString();
                string importDate = dgvRecipeList.SelectedCells[2].Value.ToString();
                _ucHome.GetRecipeFromSearchEngine(recipe, importDate);

                this.Close();
            }
            else
            {
                Alert("Please select only 1 row", Form_Alert.enmType.Error);
            }
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
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#86D489");
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(102, 187, 106);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
        }        
    }
}
