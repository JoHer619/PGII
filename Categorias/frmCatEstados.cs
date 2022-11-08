using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotacionInventario
{
    public partial class frmCatEstados : Form
    {

        //Var
        int idCategoria = 0;

        public frmCatEstados()
        {
            InitializeComponent();

            tbCatInactivaDataGridView.ReadOnly = true;
            tbCatActivaDataGridView.ReadOnly = true;

            cmbEstado.Enabled = false;

            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmCatEstados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwCategoriasInactivas' table. You can move, or remove it, as needed.
            this.vwCategoriasInactivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwCategoriasInactivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwCategoriasActivas' table. You can move, or remove it, as needed.
            this.vwCategoriasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwCategoriasActivas);

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (idCategoria != 0)
            {
                tbCategoriaTableAdapter.spActualizarEstadoCat(idCategoria, cmbEstado.Text);
                MessageBox.Show("Categoria actualizada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCatActivaDataGridView.DataSource = vwCategoriasActivasTableAdapter.GetData();
                tbCatInactivaDataGridView.DataSource = vwCategoriasInactivasTableAdapter.GetData();
                lblCategoria.Text = "- - -";
                lblCategoria.ForeColor = Color.Black;
                idCategoria = 0;
            }
            else
            {
                MessageBox.Show("Seleccione una categoria", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbCatActivaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCategoria = Convert.ToInt32(tbCatActivaDataGridView.CurrentRow.Cells[0].Value.ToString());

            lblCategoria.Text = tbCatActivaDataGridView.CurrentRow.Cells[1].Value.ToString();
            lblCategoria.ForeColor = Color.Green;

            cmbEstado.Text = tbCatActivaDataGridView.CurrentRow.Cells[3].Value.ToString();
            cmbEstado.Enabled = true;
        }

        private void tbCatInactivaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCategoria = Convert.ToInt32(tbCatInactivaDataGridView.CurrentRow.Cells[0].Value.ToString());

            lblCategoria.Text = tbCatInactivaDataGridView.CurrentRow.Cells[1].Value.ToString();
            lblCategoria.ForeColor = Color.Red;

            cmbEstado.Text = tbCatInactivaDataGridView.CurrentRow.Cells[3].Value.ToString();
            cmbEstado.Enabled = true;
        }
    }
}
