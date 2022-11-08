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
    public partial class frmCompraEstado : Form
    {
        
        int idCompra = 0;

        public frmCompraEstado()
        {
            InitializeComponent();
        
            tbCompraInactivaDataGridView.ReadOnly = true;
            spDetalleCompraDataGridView.ReadOnly = true;
        }

        private void frmCompraEstado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwComprasInactivas' table. You can move, or remove it, as needed.
            this.vwComprasInactivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasInactivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwComprasActivas' table. You can move, or remove it, as needed.
            this.vwComprasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasActivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwComprasActivas' table. You can move, or remove it, as needed.
            this.vwComprasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasActivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwComprasInactivas' table. You can move, or remove it, as needed.
            this.vwComprasInactivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasInactivas);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwComprasActivas' table. You can move, or remove it, as needed.
            this.vwComprasActivasTableAdapter.Fill(this.bD_INVENTARIODataSet.vwComprasActivas);

        }

        private void tbCompraInactivaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (tbCompraInactivaDataGridView.RowCount != 0)
            {
                idCompra = Convert.ToInt32(tbCompraInactivaDataGridView.CurrentRow.Cells[0].Value.ToString());

                this.spDetalleCompraTableAdapter.spDetalleCompra(bD_INVENTARIODataSet.spDetalleCompra, idCompra);
            }   
        }
    }
}
