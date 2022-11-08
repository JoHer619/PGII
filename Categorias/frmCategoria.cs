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
    public partial class frmCategoria : Form
    {

        // Var
        int idCategoria = 0;

        public frmCategoria()
        {
            InitializeComponent();

            tbCategoriasDataGridView.ReadOnly = true;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwCategoriasActivas' table. You can move, or remove it, as needed.
            this.vwCategoriasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwCategoriasActivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbCategoria' table. You can move, or remove it, as needed.
            this.tbCategoriaTableAdapter.Fill(this.bD_INVENTARIODataSet.tbCategoria);

        }

        //Clases
        private void limpiarCampos()
        {
            txtNombre.Clear();
            rtbDescripcion.Clear();
            idCategoria = 0;
        }
        //---

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || rtbDescripcion.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                tbCategoriaTableAdapter.spInsertarCategoria(txtNombre.Text, rtbDescripcion.Text);
                txtNombre.Clear();
                rtbDescripcion.Clear();
                tbCategoriasDataGridView.DataSource = vwCategoriasActivasTableAdapter.GetData();
                limpiarCampos();
                MessageBox.Show("Categoria registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idCategoria != 0)
            {
                tbCategoriaTableAdapter.spActualizarCategoria(idCategoria, txtNombre.Text, rtbDescripcion.Text);
                txtNombre.Clear();
                rtbDescripcion.Clear();
                tbCategoriasDataGridView.DataSource = vwCategoriasActivasTableAdapter.GetData();
                limpiarCampos();
                MessageBox.Show("Categoria actualizada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione una categoria", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbCategoriasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCategoria = Convert.ToInt32(tbCategoriasDataGridView.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = tbCategoriasDataGridView.CurrentRow.Cells[1].Value.ToString();
            rtbDescripcion.Text = tbCategoriasDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
