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
    public partial class frmBitacoraGeneral : Form
    {
        public frmBitacoraGeneral()
        {
            InitializeComponent();

            tbBitGenerallDataGridView.ReadOnly = true;
        }

        private void frmBitacoraGeneral_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbBitacora' table. You can move, or remove it, as needed.
            this.tbBitacoraTableAdapter.Fill(this.bD_INVENTARIODataSet.tbBitacora);

        }
    }
}
