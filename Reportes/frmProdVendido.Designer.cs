
namespace RotacionInventario.Reportes
{
    partial class frmProdVendido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProdVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.spProductosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spProductosMasVendidosTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.spProductosMasVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosMasVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdVendidos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProdVendidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdVendidos.Legends.Add(legend1);
            this.chartProdVendidos.Location = new System.Drawing.Point(12, 12);
            this.chartProdVendidos.Name = "chartProdVendidos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProdVendidos.Series.Add(series1);
            this.chartProdVendidos.Size = new System.Drawing.Size(1632, 890);
            this.chartProdVendidos.TabIndex = 0;
            this.chartProdVendidos.Text = "Productos mas vendidos";
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spProductosMasVendidosBindingSource
            // 
            this.spProductosMasVendidosBindingSource.DataMember = "spProductosMasVendidos";
            this.spProductosMasVendidosBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // spProductosMasVendidosTableAdapter
            // 
            this.spProductosMasVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // frmProdVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 914);
            this.Controls.Add(this.chartProdVendidos);
            this.Name = "frmProdVendido";
            this.Text = "Productos mas vendidos";
            this.Load += new System.EventHandler(this.frmReportProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosMasVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdVendidos;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource spProductosMasVendidosBindingSource;
        private BD_INVENTARIODataSetTableAdapters.spProductosMasVendidosTableAdapter spProductosMasVendidosTableAdapter;
    }
}