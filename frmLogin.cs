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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.tbUsuarioTableAdapter.spLogin(txtUser.Text, txtPass.Text, out int ? idUsuario);

            if (idUsuario > 0 )
            {

                this.tbRolTableAdapter.spValidarPermisos(this.bD_INVENTARIODataSet.tbRol, idUsuario);

                Permisos.ventas = Convert.ToBoolean(bD_INVENTARIODataSet.Tables["tbRol"].Rows[0]["pVentas"]);
                Permisos.compras = Convert.ToBoolean(bD_INVENTARIODataSet.Tables["tbRol"].Rows[0]["pCompras"]);
                Permisos.productos = Convert.ToBoolean(bD_INVENTARIODataSet.Tables["tbRol"].Rows[0]["pProductos"]);
                Permisos.categorias = Convert.ToBoolean(bD_INVENTARIODataSet.Tables["tbRol"].Rows[0]["pCategorias"]);
                Permisos.usuarios = Convert.ToBoolean(bD_INVENTARIODataSet.Tables["tbRol"].Rows[0]["pUsuarios"]);
                Permisos.roles = Convert.ToBoolean(bD_INVENTARIODataSet.Tables["tbRol"].Rows[0]["pRoles"]);
                Permisos.bitacoras = Convert.ToBoolean(bD_INVENTARIODataSet.Tables["tbRol"].Rows[0]["pBitacoras"]);
                Permisos.reportes = Convert.ToBoolean(bD_INVENTARIODataSet.Tables["tbRol"].Rows[0]["pReportes"]);


                MessageBox.Show("Bienvenido " + txtUser.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("NO ES POSIBLE INICIAR SESIÓN", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbRol' table. You can move, or remove it, as needed.
            this.tbRolTableAdapter.Fill(this.bD_INVENTARIODataSet.tbRol);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.bD_INVENTARIODataSet.tbUsuario);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
