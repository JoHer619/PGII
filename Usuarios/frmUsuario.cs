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
    public partial class frmUsuario : Form
    {

        // Var
        int idUsuario = 0;

        public frmUsuario()
        {
            InitializeComponent();

            tbUsuariosDataGridView.ReadOnly = true;

            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.bD_INVENTARIODataSet.tbUsuario);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwRolesActivos' table. You can move, or remove it, as needed.
            this.vwRolesActivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwRolesActivos);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwUsuariosActivos' table. You can move, or remove it, as needed.
            this.vwUsuariosActivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwUsuariosActivos);
        }

        //Clases
        private void limpiarCampos()
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtPassword2.Clear();
        }
        //

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtPassword2.Text != txtPassword.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbUsuarioTableAdapter.spInsertarUsuario(txtUser.Text, txtPassword.Text, Convert.ToInt32(cmbRol.SelectedValue));
                    txtUser.Clear();
                    txtPassword.Clear();
                    tbUsuariosDataGridView.DataSource = vwUsuariosActivosTableAdapter.GetData();
                    limpiarCampos();
                    MessageBox.Show("Usuario registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idUsuario != 0)
            {
                txtUser.Clear();
                txtPassword.Clear();
                tbUsuariosDataGridView.DataSource = vwUsuariosActivosTableAdapter.GetData();
                MessageBox.Show("Usuario Actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idUsuario = 0;
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbUsuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            idUsuario = Convert.ToInt32(tbUsuariosDataGridView.CurrentRow.Cells[0].Value.ToString());
            txtUser.Text = tbUsuariosDataGridView.CurrentRow.Cells[1].Value.ToString();
            password = tbUsuariosDataGridView.CurrentRow.Cells[2].Value.ToString();
            cmbRol.Text = tbUsuariosDataGridView.CurrentRow.Cells[3].Value.ToString();
            estado = tbUsuariosDataGridView.CurrentRow.Cells[4].Value.ToString();
            */
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
