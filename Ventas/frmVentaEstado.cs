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
    public partial class frmVentaEstado : Form
    {
        //Var
        int idVenta = 0;

        public frmVentaEstado()
        {
            InitializeComponent();

        
            tbVentaInactivaDataGridView.ReadOnly = true;
            spDetalleVentaDataGridView.ReadOnly = true;


        }

        private void frmVentaEstado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwVentasInactivas' table. You can move, or remove it, as needed.
            this.vwVentasInactivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwVentasInactivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwVentasActivas' table. You can move, or remove it, as needed.
            this.vwVentasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwVentasActivas);

        }

        private void tbVentaActivaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void tbVentaInactivaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbVentaInactivaDataGridView.RowCount != 0)
            {
                idVenta = Convert.ToInt32(tbVentaInactivaDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.spDetalleVentaTableAdapter.spDetalleVenta(bD_INVENTARIODataSet.spDetalleVenta, idVenta);
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
