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
    public partial class frmProdComprado : Form
    {
        public frmProdComprado()
        {
            InitializeComponent();

            dashboard();
        }

        private void dashboard()
        {
            BD_INVENTARIODataSetTableAdapters.spProductosMasCompradosTableAdapter n = new BD_INVENTARIODataSetTableAdapters.spProductosMasCompradosTableAdapter();
            DataTable dt = new DataTable();

            dt = n.GetData();

            chartProdComprados.Titles.Add("10 de productos más comprados");

            foreach (DataRow row in dt.Rows)
            {
                Series series = chartProdComprados.Series.Add(row["nombreProducto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad"].ToString()));
                series.Label = row["Cantidad"].ToString();
            }
        }

        private void frmProdComprado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.spProductosMasComprados' table. You can move, or remove it, as needed.
            this.spProductosMasCompradosTableAdapter.Fill(this.bD_INVENTARIODataSet.spProductosMasComprados);

        }
    }
}
