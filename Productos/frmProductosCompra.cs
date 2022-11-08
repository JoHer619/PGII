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
    public partial class frmProductosCompra : Form
    {
        frmCompra Compra;

        public frmProductosCompra(frmCompra compra)
        {
            InitializeComponent();

            this.Compra = compra;

            tbProductosDataGridView.ReadOnly = true;
        }

        private void frmVerProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwProductosActivos' table. You can move, or remove it, as needed.
            this.vwProductosActivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwProductosActivos);

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
            tbProductosDataGridView.DataSource = vwProductosActivosTableAdapter.GetDataBy(txtBuscar.Text);
        }

        private void tbProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.idProducto = Convert.ToInt32(tbProductosDataGridView.CurrentRow.Cells[0].Value.ToString());
            Variables.nombreProducto = tbProductosDataGridView.CurrentRow.Cells[1].Value.ToString();
            Variables.precioProducto = Convert.ToDecimal(tbProductosDataGridView.CurrentRow.Cells[2].Value.ToString());
            Variables.codigoProducto = tbProductosDataGridView.CurrentRow.Cells[6].Value.ToString();

            Variables.stockProducto = Convert.ToInt32(tbProductosDataGridView.CurrentRow.Cells[3].Value.ToString());

            if (tbProductosDataGridView.RowCount != 0)
            {
                if (tbProductosDataGridView.Columns[e.ColumnIndex].Name == "addProducto")
                {
                    if (Compra.tbProductosDataGridView.RowCount > 0)
                    {
                        for (int i = 0; i < Compra.tbProductosDataGridView.RowCount; i++)
                        {
                            if (Convert.ToInt32(Compra.tbProductosDataGridView.Rows[i].Cells["idProduct"].Value) == Variables.idProducto)
                            {
                                MessageBox.Show("Este producto ya fue agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Variables.idProducto = 0;
                                break;
                            }
                        }
                    }

                    if (Variables.idProducto != 0)
                    {
                        Compra.lblCodigo.Text = Convert.ToString(Variables.codigoProducto);
                        Compra.lblNombre.Text = Variables.nombreProducto;
                        Compra.txtPrecio.Text = Convert.ToString(Variables.precioProducto);
                        Compra.lblStock.Text = Convert.ToString(Variables.stockProducto);
                        MessageBox.Show("Producto agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

        }

        private void tbProductosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.tbProductosDataGridView.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn4")
            {
                if (Convert.ToInt32(e.Value) <= 20)
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
                else if (Convert.ToInt32(e.Value) > 20)
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }
            }
        }
    }
}
