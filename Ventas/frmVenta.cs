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
    public partial class frmVenta : Form
    {
        int cantidad = 0;
        decimal precio = 0;
        decimal descuento = 0;
        decimal subTotal = 0;

        public frmVenta()
        {
            InitializeComponent();
            tbProductosDataGridView.ReadOnly = true;
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwVentasActivas' table. You can move, or remove it, as needed.
            this.vwVentasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwVentasActivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbVenta' table. You can move, or remove it, as needed.
            this.tbVentaTableAdapter.Fill(this.bD_INVENTARIODataSet.tbVenta);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbDetalleVenta' table. You can move, or remove it, as needed.
            this.tbDetalleVentaTableAdapter.Fill(this.bD_INVENTARIODataSet.tbDetalleVenta);

        }

        //Clases
        public void limpiarCampos()
        {
            txtPrecio.Text = "- - -";
            txtCantidad.Value = 1;
            txtDescuento.Value = 0;
            lblNombre.Text = "- - -";
            lblCodigo.Text = "- - -";
            lblStock.Text = "- - - ";
        }

        public void limpiarVaribales()
        {
            Variables.idProducto = 0;
            Variables.nombreProducto = "";
            Variables.precioProducto = 0;
            Variables.stockProducto = 0;
            Variables.codigoProducto = "";
        }
        //---             

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductosVenta verProductos = new frmProductosVenta(this);
            verProductos.ShowDialog();
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Value > Variables.stockProducto)
                {
                    if (txtCantidad.Value > 1)
                    {
                        MessageBox.Show("No hay existencias", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCantidad.Value = 1;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtPrecio.Text == "" || txtDescuento.Text == "")
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
                    descuento = Convert.ToDecimal(txtDescuento.Text);
                    subTotal = Convert.ToDecimal((precio * cantidad) - descuento);
                    tbProductosDataGridView.Rows.Add(Variables.idProducto, Variables.codigoProducto,
                        lblNombre.Text, txtCantidad.Text, txtPrecio.Text, txtDescuento.Text, subTotal);
                    limpiarVaribales();
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
            decimal totalV = 0;
            decimal total;

            for (int i = 0; i < tbProductosDataGridView.RowCount; i++)
            {
                decimal.TryParse(tbProductosDataGridView.Rows[i].Cells[6].Value.ToString(), out total);
                totalV += total;
                lblTotal.Text = totalV.ToString("N2");
            }


            if (tbProductosDataGridView.RowCount == 0)
            {
                lblTotal.Text = "00.00";
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (tbProductosDataGridView.RowCount == 0)
            {
                MessageBox.Show("Agregue productos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tbVentaTableAdapter.spInsertarVenta(Convert.ToDecimal(lblTotal.Text));
                MessageBox.Show("Venta registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbVentaTableAdapter.spObtenerVenta(out int? idCompra);

                for (int i = 0; i < tbProductosDataGridView.RowCount; i++)
                {
                    int idProducto;
                    int cantidadProducto;
                    decimal precioProducto;
                    decimal descuentoProducto;
                    decimal subTotalCompra;

                    int.TryParse(tbProductosDataGridView.Rows[i].Cells[0].Value.ToString(), out idProducto);
                    int.TryParse(tbProductosDataGridView.Rows[i].Cells[3].Value.ToString(), out cantidadProducto);
                    decimal.TryParse(tbProductosDataGridView.Rows[i].Cells[4].Value.ToString(), out precioProducto);
                    decimal.TryParse(tbProductosDataGridView.Rows[i].Cells[5].Value.ToString(), out descuentoProducto);
                    decimal.TryParse(tbProductosDataGridView.Rows[i].Cells[6].Value.ToString(), out subTotalCompra);

                    this.tbDetalleVentaTableAdapter.spInsertarDetalleVenta(Convert.ToInt32(cantidadProducto),
                        Convert.ToDecimal(precioProducto), Convert.ToDecimal(descuentoProducto), Convert.ToDecimal(subTotalCompra), idCompra, idProducto);
                }
                tbProductosDataGridView.Rows.Clear();
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            limpiarVaribales();
            limpiarCampos();
        }

        private void txtDescuento_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDescuento.Value > Variables.precioProducto)
                {
                    MessageBox.Show("No hay existencias", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescuento.Value = 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
