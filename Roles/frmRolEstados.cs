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
    public partial class frmRolEstados : Form
    {
        //Var
        int idRol = 0;

        public frmRolEstados()
        {
            InitializeComponent();

            tbRolActivoDataGridView.ReadOnly = true;
            tbRolInactivoDataGridView.ReadOnly = true;

            cmbEstado.Enabled = false;

            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmRolEstados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwRolesInactivos' table. You can move, or remove it, as needed.
            this.vwRolesInactivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwRolesInactivos);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwRolesActivos' table. You can move, or remove it, as needed.
            this.vwRolesActivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwRolesActivos);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbRol' table. You can move, or remove it, as needed.
            this.tbRolTableAdapter.Fill(this.bD_INVENTARIODataSet.tbRol);

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (idRol != 0)
            {
                tbRolTableAdapter.spActualizarEstadoRol(idRol, cmbEstado.Text);
                MessageBox.Show("Rol actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbRolActivoDataGridView.DataSource = vwRolesActivosTableAdapter.GetData();
                tbRolInactivoDataGridView.DataSource = vwRolesInactivosTableAdapter.GetData();
                lblRol.Text = "- - -";
                lblRol.ForeColor = Color.Black;
                idRol = 0;
            }
            else
            {
                MessageBox.Show("Seleccione un rol", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbRolActivoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idRol = Convert.ToInt32(tbRolActivoDataGridView.CurrentRow.Cells[0].Value.ToString());

            lblRol.Text = tbRolActivoDataGridView.CurrentRow.Cells[1].Value.ToString();
            lblRol.ForeColor = Color.Green;

            cmbEstado.Text = tbRolActivoDataGridView.CurrentRow.Cells[2].Value.ToString();
            cmbEstado.Enabled = true;
        }

        private void tbRolInactivoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idRol = Convert.ToInt32(tbRolInactivoDataGridView.CurrentRow.Cells[0].Value.ToString());

            lblRol.Text = tbRolInactivoDataGridView.CurrentRow.Cells[1].Value.ToString();
            lblRol.ForeColor = Color.Red;

            cmbEstado.Text = tbRolInactivoDataGridView.CurrentRow.Cells[2].Value.ToString();
            cmbEstado.Enabled = true;
        }
    }
}
