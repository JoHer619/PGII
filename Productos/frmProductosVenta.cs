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
    public partial class frmProductosVenta : Form
    {
        frmVenta Venta;

        public frmProductosVenta(frmVenta venta)
        {
            InitializeComponent();

            this.Venta = venta;

            tbProductosDataGridView.ReadOnly = true;
        }

        private void frmProductosVenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwProductosExistencia' table. You can move, or remove it, as needed.
            this.vwProductosExistenciaTableAdapter.Fill(this.bD_INVENTARIODataSet.vwProductosExistencia);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Variables.idProducto = 0;
            Variables.nombreProducto = "";
            Variables.precioProducto = 0;
            Variables.codigoProducto = "";
            Variables.stockProducto = 0;

            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tbProductosDataGridView.DataSource = vwProductosExistenciaTableAdapter.GetDataBy(txtBuscar.Text);
        }

        private void tbProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.idProducto = Convert.ToInt32(tbProductosDataGridView.CurrentRow.Cells[0].Value.ToString());
            Variables.nombreProducto = tbProductosDataGridView.CurrentRow.Cells[1].Value.ToString();
            Variables.precioProducto = Convert.ToDecimal(tbProductosDataGridView.CurrentRow.Cells[2].Value.ToString());
            Variables.codigoProducto = tbProductosDataGridView.CurrentRow.Cells[6].Value.ToString();

            Variables.stockProducto = Convert.ToInt32(tbProductosDataGridView.CurrentRow.Cells[3].Value.ToString());

            if (tbProductosDataGridView.Columns[e.ColumnIndex].Name == "addProducto")
            {
                if (Venta.tbProductosDataGridView.RowCount > 0)
                {
                    for (int i = 0; i < Venta.tbProductosDataGridView.RowCount; i++)
                    {
                        if (Convert.ToInt32(Venta.tbProductosDataGridView.Rows[i].Cells["idProduct"].Value) == Variables.idProducto)
                        {
                            MessageBox.Show("Este producto ya fue agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Variables.idProducto = 0;
                            break;
                        }
                    }
                }

                if (Variables.idProducto != 0)
                {
                    Venta.lblCodigo.Text = Convert.ToString(Variables.codigoProducto);
                    Venta.lblNombre.Text = Variables.nombreProducto;
                    Venta.txtPrecio.Text = Convert.ToString(Variables.precioProducto);
                    Venta.lblStock.Text = Convert.ToString(Variables.stockProducto);
                    MessageBox.Show("Producto agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
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

                    if (Convert.ToInt32(e.Value) <= 10)
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
