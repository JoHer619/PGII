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
    public partial class frmUserEstados : Form
    {

        //Var
        int idUser = 0;


        public frmUserEstados()
        {
            InitializeComponent();

            tbUserActivoDataGridView.ReadOnly = true;
            tbUserInactivoDataGridView.ReadOnly = true;

            cmbEstado.Enabled = false;

            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void frmUserEstados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.bD_INVENTARIODataSet.tbUsuario);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwUsuariosInactivos' table. You can move, or remove it, as needed.
            this.vwUsuariosInactivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwUsuariosInactivos);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwUsuariosActivos' table. You can move, or remove it, as needed.
            this.vwUsuariosActivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwUsuariosActivos);

        }
        
        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (idUser != 0)
            {
                tbUsuarioTableAdapter.spActualizarEstadoUser(idUser, cmbEstado.Text);
                MessageBox.Show("Usuario actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUserActivoDataGridView.DataSource = vwUsuariosActivosTableAdapter.GetData();
                tbUserInactivoDataGridView.DataSource = vwUsuariosInactivosTableAdapter.GetData();
                lblUser.Text = "- - -";
                lblUser.ForeColor = Color.Black;
                idUser = 0;
            }
            else
            {
                MessageBox.Show("Seleccione un usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbUserActivoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idUser = Convert.ToInt32(tbUserActivoDataGridView.CurrentRow.Cells[0].Value.ToString());

            lblUser.Text = tbUserActivoDataGridView.CurrentRow.Cells[1].Value.ToString();
            lblUser.ForeColor = Color.Green;

            cmbEstado.Text = tbUserActivoDataGridView.CurrentRow.Cells[4].Value.ToString();
            cmbEstado.Enabled = true;
        }

        private void tbUserInactivoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idUser = Convert.ToInt32(tbUserInactivoDataGridView.CurrentRow.Cells[0].Value.ToString());

            lblUser.Text = tbUserInactivoDataGridView.CurrentRow.Cells[1].Value.ToString();
            lblUser.ForeColor = Color.Red;

            cmbEstado.Text = tbUserInactivoDataGridView.CurrentRow.Cells[4].Value.ToString();
            cmbEstado.Enabled = true;
        }


    }
}
