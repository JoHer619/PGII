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
    public partial class frmProducto : Form
    {

        // Var
        int idProducto = 0;

        public frmProducto()
        {
            InitializeComponent();

            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            tbProductosDataGridView.ReadOnly = true;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbProducto' table. You can move, or remove it, as needed.
            this.tbProductoTableAdapter.Fill(this.bD_INVENTARIODataSet.tbProducto);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwCategoriasActivas' table. You can move, or remove it, as needed.
            this.vwCategoriasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwCategoriasActivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwProductosActivos' table. You can move, or remove it, as needed.
            this.vwProductosActivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwProductosActivos);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbProducto' table. You can move, or remove it, as needed.
            this.tbProductoTableAdapter.Fill(this.bD_INVENTARIODataSet.tbProducto);
        }

        //Clases
        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtExistencias.Clear();
            txtSku.Clear();

            idProducto = 0;
        }
        //---

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtExistencias.Text == "" || txtSku.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tbProductoTableAdapter.spInsertarProducto(txtNombre.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtExistencias.Text), Convert.ToInt32(cmbCategoria.SelectedValue), txtSku.Text);
                limpiarCampos();
                tbProductosDataGridView.DataSource = vwProductosActivosTableAdapter.GetData();
                MessageBox.Show("Producto registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idProducto != 0)
            { 
                tbProductoTableAdapter.spActualizarProducto(idProducto, txtNombre.Text, Convert.ToDecimal(txtPrecio.Text), 
                    Convert.ToInt32(txtExistencias.Text), Convert.ToInt32(cmbCategoria.SelectedValue), txtSku.Text);
                limpiarCampos();
                MessageBox.Show("Producto actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbProductosDataGridView.DataSource = vwProductosActivosTableAdapter.GetData();
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = Convert.ToInt32(tbProductosDataGridView.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = tbProductosDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = tbProductosDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtExistencias.Text = tbProductosDataGridView.CurrentRow.Cells[3].Value.ToString();
            cmbCategoria.Text = tbProductosDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtSku.Text = tbProductosDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tbProductosDataGridView.DataSource = vwProductosActivosTableAdapter.GetDataBy(txtBuscar.Text);
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void tbProductosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.tbProductosDataGridView.Columns[e.ColumnIndex].Name == "stockProductoDataGridViewTextBoxColumn")
            {
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    //e.CellStyle.BackColor = Color.Orange;

                    if (Convert.ToInt32(e.Value) <= 5)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                }
                else if (Convert.ToInt32(e.Value) > 10)
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }
            }
        }
    }
}
