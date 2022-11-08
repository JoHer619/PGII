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
    public partial class frmBitacoraLogin : Form
    {
        public frmBitacoraLogin()
        {
            InitializeComponent();
        }

        private void frmBitacoraLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbBitacoraLogin' table. You can move, or remove it, as needed.
            this.tbBitacoraLoginTableAdapter.Fill(this.bD_INVENTARIODataSet.tbBitacoraLogin);

        }
    }
}
