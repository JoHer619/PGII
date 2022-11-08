using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RotacionInventario.Reportes
{
    public partial class frmProdVendido : Form
    {
        public frmProdVendido()
        {
            InitializeComponent();

            dashboard();
        }

        private void dashboard()
        {
            BD_INVENTARIODataSetTableAdapters.spProductosMasVendidosTableAdapter n = new BD_INVENTARIODataSetTableAdapters.spProductosMasVendidosTableAdapter();
            DataTable dt = new DataTable();

            dt = n.GetData();

            chartProdVendidos.Titles.Add("10 de productos más vendidos");

            foreach (DataRow row in dt.Rows)
            {
                Series series = chartProdVendidos.Series.Add(row["nombreProducto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad"].ToString()));
                series.Label = row["Cantidad"].ToString();
            }
        }


        private void frmReportProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.spProductosMasVendidos' table. You can move, or remove it, as needed.
            this.spProductosMasVendidosTableAdapter.Fill(this.bD_INVENTARIODataSet.spProductosMasVendidos);

        }
    }
}
