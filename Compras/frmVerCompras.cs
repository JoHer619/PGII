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
    public partial class frmVerCompras : Form
    {

        int idCompra = 0;

        public frmVerCompras()
        {
            InitializeComponent();

            tbComprasDataGridView.ReadOnly = true;
            spDetalleCompraDataGridView.ReadOnly = true;
        }

        private void frmVerCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwComprasActivas' table. You can move, or remove it, as needed.
            this.vwComprasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasActivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbCompra' table. You can move, or remove it, as needed.
            this.tbCompraTableAdapter.Fill(this.bD_INVENTARIODataSet.tbCompra);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbDetalleCompra' table. You can move, or remove it, as needed.
            this.tbDetalleCompraTableAdapter.Fill(this.bD_INVENTARIODataSet.tbDetalleCompra);
        }

        private void tbComprasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbComprasDataGridView.RowCount != 0)
            {
                idCompra = Convert.ToInt32(tbComprasDataGridView.CurrentRow.Cells[0].Value);

                lblCompra.Text = "Compra No." + tbComprasDataGridView.CurrentRow.Cells[0].Value.ToString();
                lblCompra.ForeColor = Color.Green;

                this.spDetalleCompraTableAdapter.spDetalleCompra(bD_INVENTARIODataSet.spDetalleCompra, idCompra);
            }

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (idCompra != 0)
            {
                this.vwComprasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasActivas);

                for (int i = 0; i < spDetalleCompraDataGridView.RowCount - 0; i++)
                {
                    int cantidad;
                    int idProducto;

                    int.TryParse(spDetalleCompraDataGridView.Rows[i].Cells[2].Value.ToString(), out cantidad);
                    int.TryParse(spDetalleCompraDataGridView.Rows[i].Cells[6].Value.ToString(), out idProducto);

                    this.tbCompraTableAdapter.spActualizarEstadoCompra(idCompra, idProducto, cantidad, "Inactivo");
                }

                //MessageBox.Show("Compra inactivada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbComprasDataGridView.DataSource = vwComprasActivasTableAdapter.GetData();
                //spDetalleCompraDataGridView.Rows.Clear();
                spDetalleCompraDataGridView.DataSource = null;
                lblCompra.Text = "- - -";
                lblCompra.ForeColor = Color.Black;
                idCompra = 0;
            }
            else
            {
                MessageBox.Show("Seleccione una venta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
