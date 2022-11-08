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
    public partial class frmCompra : Form
    {
        int cantidad = 0;
        decimal precio = 0;
        decimal subTotal = 0;

        public frmCompra()
        {
            InitializeComponent();

            tbProductosDataGridView.ReadOnly = true;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwComprasActivas' table. You can move, or remove it, as needed.
            this.vwComprasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasActivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbDetalleCompra' table. You can move, or remove it, as needed.
            this.tbDetalleCompraTableAdapter.Fill(this.bD_INVENTARIODataSet.tbDetalleCompra);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwComprasActivas' table. You can move, or remove it, as needed.
            this.vwComprasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasActivas);
        }

        //Clases
        public void limpiarCampos()
        {
            txtPrecio.Clear();
            txtCantidad.Value = 1;
            lblNombre.Text = "- - -";
            lblCodigo.Text = "- - -";
        }

        public void limpiarVariables()
        {
            Variables.idProducto = 0;
            Variables.nombreProducto = "";
            Variables.precioProducto = 0;
            Variables.codigoProducto = "";
        }
        //---

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductosCompra verProductos = new frmProductosCompra(this);
            verProductos.ShowDialog();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Variables.idProducto == 0)
                {
                    MessageBox.Show("Seleccione un producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    precio = Convert.ToDecimal(txtPrecio.Text);
                    subTotal = Convert.ToDecimal((precio * cantidad));
                    tbProductosDataGridView.Rows.Add(Variables.idProducto, Variables.codigoProducto,
                        lblNombre.Text, txtCantidad.Text, txtPrecio.Text, subTotal);
                    limpiarVariables();
                }

                limpiarCampos();
                calcularTotal();
            }
        }

        private void tbProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbProductosDataGridView.RowCount != 0)
            {
                if (tbProductosDataGridView.Columns[e.ColumnIndex].Name == "deleteProducto")
                {
                    tbProductosDataGridView.Rows.Remove(tbProductosDataGridView.CurrentRow);
                    calcularTotal();
                }
            }

        }

        public void calcularTotal()
        {
            decimal totalC = 0;
            decimal total;

            for (int i = 0; i < tbProductosDataGridView.RowCount; i++)
            {
                decimal.TryParse(tbProductosDataGridView.Rows[i].Cells[5].Value.ToString(), out total);
                totalC += total;
                lblTotal.Text = totalC.ToString("N2");
            }


            if (tbProductosDataGridView.RowCount == 0)
            {
                lblTotal.Text = "00.00";
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (tbProductosDataGridView.RowCount == 0)
            {
                MessageBox.Show("Agregue productos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tbCompraTableAdapter.spInsertarCompra(Convert.ToDecimal(lblTotal.Text));
                MessageBox.Show("Compra registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbCompraTableAdapter.spObtenerCompra(out int? idCompra);

                for (int i = 0; i < tbProductosDataGridView.RowCount; i++)
                {
                    //int idProduct = Convert.ToInt32(tbProductosDataGridView.Rows[i].Cells[6]);
                    int idProducto;
                    int cantidadProducto;
                    decimal precioProducto;
                    decimal subTotalCompra;

                    int.TryParse(tbProductosDataGridView.Rows[i].Cells[0].Value.ToString(), out idProducto);
                    int.TryParse(tbProductosDataGridView.Rows[i].Cells[3].Value.ToString(), out cantidadProducto);
                    decimal.TryParse(tbProductosDataGridView.Rows[i].Cells[4].Value.ToString(), out precioProducto);
                    decimal.TryParse(tbProductosDataGridView.Rows[i].Cells[5].Value.ToString(), out subTotalCompra);

                    this.tbDetalleCompraTableAdapter.spInsertarDetalleCompra(Convert.ToInt32(cantidadProducto),
                        Convert.ToDecimal(precioProducto), Convert.ToDecimal(subTotalCompra), idCompra, idProducto);
                }
                tbProductosDataGridView.Rows.Clear();
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            limpiarVariables();
            limpiarCampos();
        }
    }
}
