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
    public partial class frmProdEstados : Form
    {

        //Var
        int idProducto = 0;

        public frmProdEstados()
        {
            InitializeComponent();

            tbProdActivoDataGridView.ReadOnly = true;
            tbProdInactivoDataGridView.ReadOnly = true;

            cmbEstado.Enabled = false;

            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmProdEstados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbProducto' table. You can move, or remove it, as needed.
            this.tbProductoTableAdapter.Fill(this.bD_INVENTARIODataSet.tbProducto);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwProductosInactivos' table. You can move, or remove it, as needed.
            this.vwProductosInactivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwProductosInactivos);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwProductosActivos' table. You can move, or remove it, as needed.
            this.vwProductosActivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwProductosActivos);

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (idProducto != 0)
            {
                tbProductoTableAdapter.spActualizarEstadoProd(idProducto, cmbEstado.Text);
                MessageBox.Show("Producto actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbProdActivoDataGridView.DataSource = vwProductosActivosTableAdapter.GetData();
                tbProdInactivoDataGridView.DataSource = vwProductosInactivosTableAdapter.GetData();
                lblProducto.Text = "- - -";
                lblProducto.ForeColor = Color.Black;
                idProducto = 0;
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbProdActivoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = Convert.ToInt32(tbProdActivoDataGridView.CurrentRow.Cells[0].Value.ToString());

            lblProducto.Text = tbProdActivoDataGridView.CurrentRow.Cells[6].Value.ToString();
            lblProducto.ForeColor = Color.Green;

            cmbEstado.Text = tbProdActivoDataGridView.CurrentRow.Cells[6].Value.ToString();
            cmbEstado.Enabled = true;
        }

        private void tbProdInactivoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (tbProdActivoDataGridView.RowCount != 0)
            {
                idProducto = Convert.ToInt32(tbProdInactivoDataGridView.CurrentRow.Cells[0].Value.ToString());

                lblProducto.Text = tbProdInactivoDataGridView.CurrentRow.Cells[6].Value.ToString();
                lblProducto.ForeColor = Color.Red;

                cmbEstado.Text = tbProdInactivoDataGridView.CurrentRow.Cells[6].Value.ToString();
                cmbEstado.Enabled = true;
            }


        }
    }
}
