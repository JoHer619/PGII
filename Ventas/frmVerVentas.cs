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
    public partial class frmVerVentas : Form
    {

        int idVenta = 0;

        public frmVerVentas()
        {
            InitializeComponent();

            tbVentasDataGridView.ReadOnly = true;
            spDetalleVentaDataGridView.ReadOnly = true;
        }

        private void frmVerVentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwVentasActivas' table. You can move, or remove it, as needed.
            this.vwVentasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwVentasActivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbVenta' table. You can move, or remove it, as needed.
            this.tbVentaTableAdapter.Fill(this.bD_INVENTARIODataSet.tbVenta);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbDetalleVenta' table. You can move, or remove it, as needed.
            this.tbDetalleVentaTableAdapter.Fill(this.bD_INVENTARIODataSet.tbDetalleVenta);
        }

        private void tbVentasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbVentasDataGridView.RowCount != 0)
            {
                idVenta = Convert.ToInt32(tbVentasDataGridView.CurrentRow.Cells[0].Value);

                lblVenta.Text = "Venta No." + tbVentasDataGridView.CurrentRow.Cells[1].Value.ToString();
                lblVenta.ForeColor = Color.Green;

                this.spDetalleVentaTableAdapter.spDetalleVenta(bD_INVENTARIODataSet.spDetalleVenta, idVenta);
            }

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (idVenta != 0)
            {
                this.vwVentasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwVentasActivas);

                for (int i = 0; i < spDetalleVentaDataGridView.RowCount - 0; i++)
                {
                    int cantidad;
                    int idProducto;

                    int.TryParse(spDetalleVentaDataGridView.Rows[i].Cells[2].Value.ToString(), out cantidad);
                    int.TryParse(spDetalleVentaDataGridView.Rows[i].Cells[7].Value.ToString(), out idProducto);

                    this.tbVentaTableAdapter.spActualizarEstadoVenta(idVenta, idProducto, cantidad, "Inactivo");
                }

                MessageBox.Show("Venta inactivada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbVentasDataGridView.DataSource = vwVentasActivasTableAdapter.GetData();
                //spDetalleVentaDataGridView.Rows.Clear();
                spDetalleVentaDataGridView.DataSource = null;
                lblVenta.Text = "- - -";
                lblVenta.ForeColor = Color.Black;
                idVenta = 0;
            }
            else
            {
                MessageBox.Show("Seleccione una venta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
