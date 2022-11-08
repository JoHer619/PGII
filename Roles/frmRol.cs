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
    public partial class frmRol : Form
    {

        // Var
        int idRol = 0;

        public frmRol()
        {
            InitializeComponent();
            tbRolesDataGridView.ReadOnly = true;
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.vwRolesActivos' table. You can move, or remove it, as needed.
            this.vwRolesActivosTableAdapter.Fill(this.bD_INVENTARIODataSet.vwRolesActivos);
            // TODO: This line of code loads data into the 'bD_INVENTARIODataSet.tbRol' table. You can move, or remove it, as needed.
            this.tbRolTableAdapter.Fill(this.bD_INVENTARIODataSet.tbRol);

        }

        //Clases
        private void limpiarCampos()
        {
            txtNombre.Clear();
            chbVentas.Checked = false;
            chbCompras.Checked = false;
            chbProductos.Checked = false;
            chbCategorias.Checked = false;
            chbUsuarios.Checked = false;
            chbRoles.Checked = false;
            chbBitacoras.Checked = false;
            chbReportes.Checked = false;
            tbRolesDataGridView.ClearSelection();
            idRol = 0;
        }
        //---

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool? ventas = chbVentas.Checked;
            bool? compras = chbCompras.Checked;
            bool? productos = chbProductos.Checked;
            bool? categorias = chbCategorias.Checked;
            bool? usuarios = chbUsuarios.Checked;
            bool? roles = chbRoles.Checked;
            bool? bitacoras = chbBitacoras.Checked;
            bool? reportes = chbReportes.Checked;

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tbRolTableAdapter.spInsertarRol(txtNombre.Text, ventas.Value, compras.Value, productos.Value, 
                    categorias.Value, usuarios.Value, roles.Value, bitacoras.Value, reportes.Value);
                txtNombre.Clear();
                tbRolesDataGridView.DataSource = tbRolTableAdapter.GetData();
                limpiarCampos();
                MessageBox.Show("Rol registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idRol != 0)
            {
                bool? ventas = chbVentas.Checked;
                bool? compras = chbCompras.Checked;
                bool? productos = chbProductos.Checked;
                bool? categorias = chbCategorias.Checked;
                bool? usuarios = chbUsuarios.Checked;
                bool? roles = chbRoles.Checked;
                bool? bitacoras = chbBitacoras.Checked;
                bool? reportes = chbReportes.Checked;

                tbRolTableAdapter.spActualizarRol(idRol, txtNombre.Text, ventas.Value, compras.Value, productos.Value, 
                    categorias.Value, usuarios.Value, roles.Value, bitacoras.Value, reportes.Value);
                txtNombre.Clear();
                MessageBox.Show("Rol actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
                tbRolesDataGridView.DataSource = vwRolesActivosTableAdapter.GetData();
            } 
            else
            {
                MessageBox.Show("Seleccione un rol", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbRolesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idRol = Convert.ToInt32(tbRolesDataGridView.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = tbRolesDataGridView.CurrentRow.Cells[1].Value.ToString();
            chbVentas.Checked = Convert.ToBoolean(tbRolesDataGridView.CurrentRow.Cells[3].Value.ToString());
            chbCompras.Checked = Convert.ToBoolean(tbRolesDataGridView.CurrentRow.Cells[4].Value.ToString());
            chbProductos.Checked = Convert.ToBoolean(tbRolesDataGridView.CurrentRow.Cells[5].Value.ToString());
            chbCategorias.Checked = Convert.ToBoolean(tbRolesDataGridView.CurrentRow.Cells[6].Value.ToString());
            chbUsuarios.Checked = Convert.ToBoolean(tbRolesDataGridView.CurrentRow.Cells[7].Value.ToString());
            chbRoles.Checked = Convert.ToBoolean(tbRolesDataGridView.CurrentRow.Cells[8].Value.ToString());
            chbBitacoras.Checked = Convert.ToBoolean(tbRolesDataGridView.CurrentRow.Cells[9].Value.ToString());
            chbReportes.Checked = Convert.ToBoolean(tbRolesDataGridView.CurrentRow.Cells[10].Value.ToString());
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
