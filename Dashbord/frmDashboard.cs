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

namespace RotacionInventario.Dashbord
{
    public partial class frmDashboard : Form
    {
        DateTime Desde;
        DateTime Hasta;
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Hasta = dtHasta.Value;
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            Desde = dtDesde.Value;
        }



        private void GraficaFecha()
        {
            BD_INVENTARIODataSetTableAdapters.VentasXfechaTableAdapter n = new BD_INVENTARIODataSetTableAdapters.VentasXfechaTableAdapter();
            DataTable dt = new DataTable();

            dt = n.GetData(Desde, Hasta);




            foreach (DataRow row in dt.Rows)
            {
                Series series = chartVentas.Series.Add(row["fechaVenta"].ToString());
                series.Points.Add(Convert.ToDouble(row["total"].ToString()));
                series.Label = row["total"].ToString();


            }

            BD_INVENTARIODataSetTableAdapters.ComprasXfechaTableAdapter n3 = new BD_INVENTARIODataSetTableAdapters.ComprasXfechaTableAdapter();
            DataTable dt3 = new DataTable();

            dt3 = n3.GetData(Desde, Hasta);



            foreach (DataRow row in dt3.Rows)
            {
                Series series = chartCompras.Series.Add(row["fechaCompra"].ToString());
                series.Points.Add(Convert.ToDouble(row["total"].ToString()));
                series.Label = row["total"].ToString();


            }



        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_INVENTARIODataSet.stockBajo' Puede moverla o quitarla según sea necesario.
            this.stockBajoTableAdapter.Fill(this.bD_INVENTARIODataSet.stockBajo);
            // TODO: esta línea de código carga datos en la tabla 'bD_INVENTARIODataSet.tbVenta' Puede moverla o quitarla según sea necesario.
            this.tbVentaTableAdapter.Fill(this.bD_INVENTARIODataSet.tbVenta);
              Dashboard();
            Grafica();
        }
        private void Dashboard()
        {
            this.tbVentaTableAdapter.dashboard(out decimal? TotalV, out decimal? TotaG, out int? Cproductos, out int? cCategorias, out int? cUsuario);

            lbltotalVentas.Text = TotalV.ToString();
            lbltotalCompra.Text = TotaG.ToString();
            lblCantProductos.Text = Cproductos.ToString();
            lblCantCategoria.Text = cCategorias.ToString();
            lblCantUsuarios.Text = cUsuario.ToString();
        }

        private void Grafica() 
        {
            BD_INVENTARIODataSetTableAdapters.spProductosMasVendidosTableAdapter n = new BD_INVENTARIODataSetTableAdapters.spProductosMasVendidosTableAdapter();
            DataTable dt = new DataTable();

            dt = n.GetData();

           

            foreach (DataRow row in dt.Rows)
            {
                Series series = chartProdMasComp.Series.Add(row["nombreProducto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad"].ToString()));
                series.Label = row["Cantidad"].ToString();
            }
            //Stock bajo

            BD_INVENTARIODataSetTableAdapters.stockBajoTableAdapter n1 = new BD_INVENTARIODataSetTableAdapters.stockBajoTableAdapter();
            DataTable dt1 = new DataTable();

            dt1 = n1.GetData();



            foreach (DataRow row in dt1.Rows)
            {
                Series series = chartStockBaja.Series.Add(row["nombreProducto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad"].ToString()));
                series.Label = row["Cantidad"].ToString();
            }

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            GraficaFecha();
        }
    }
}
