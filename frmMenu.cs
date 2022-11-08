using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace RotacionInventario
{
    public partial class frmMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Contructor
        public frmMenu()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            menuCategorias.IsMainMenu = true;
            menuProductos.IsMainMenu = true;
            menuUsuarios.IsMainMenu = true;
            menuRoles.IsMainMenu = true;
            menuBitacoras.IsMainMenu = true;
            menuCompras.IsMainMenu = true;
            menuVentas.IsMainMenu = true;
            menuReportes.IsMainMenu = true;

            /* Permisos
            btnVentas.Enabled = Permisos.ventas;
            btnCompras.Enabled = Permisos.compras;
            btnProductos.Enabled = Permisos.productos;
            btnCategorias.Enabled = Permisos.categorias;
            btnUsuarios.Enabled = Permisos.usuarios;
            btnRoles.Enabled = Permisos.roles;
            btnBitacoras.Enabled = Permisos.bitacoras;            
            btnReportes.Enabled = Permisos.reportes;
            */

        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(20, 195, 142);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(225, 178, 0);
            public static Color color5 = Color.FromArgb(255, 153, 186);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(236, 179, 144);
            public static Color color8 = Color.FromArgb(43, 122, 11);
        }

        //Methods 
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 43, 91);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

                //lblTitleChildForm.Text = currentBtn.Text;
                //lblTitleChildForm.ForeColor = currentBtn.ForeColor;
            }
        }

        // ---
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(39, 73, 109);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // ---
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //panel
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProducto regProducto = new frmProducto();
            regProducto.Show();
        }

        private void reporteUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategoria regCategoria = new frmCategoria();
            regCategoria.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            menuVentas.Show(btnVentas, btnVentas.Width, 0);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            menuCompras.Show(btnCompras, btnCompras.Width, 0);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            menuProductos.Show(btnProductos, btnProductos.Width, 0);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            menuCategorias.Show(btnCategorias, btnCategorias.Width, 0);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            menuUsuarios.Show(btnUsuarios, btnUsuarios.Width, 0);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            menuRoles.Show(btnRoles, btnRoles.Width, 0);
        }

        private void btnBitacoras_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            menuBitacoras.Show(btnBitacoras, btnBitacoras.Width, 0);
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            menuReportes.Show(btnReportes, btnReportes.Width, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            lblTitleChildForm.Text = "Inicio";
            lblTitleChildForm.ForeColor = Color.Gainsboro;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void paneTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void itemVerCategorias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategoria());
        }

        private void itemEstadoCategoria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCatEstados());
        }

        private void itemVerProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProducto());
        }

        private void itemEstadoProducto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProdEstados());
        }

        private void itemVerUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUsuario());
        }

        private void itemEstadoUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUserEstados());
        }

        private void itemVerRoles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRol());
        }

        private void itemEstadoRol_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRolEstados());
        }

        private void itemBitacoraGeneral_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBitacoraGeneral());
        }

        private void itemBitacoraLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBitacoraLogin());
        }

        private void itemVerCompras_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmVerCompras());
        }

        private void itemEstadoCompra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCompraEstado());
        }


        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void itemRegistrarCompras_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCompra());
        }

        private void itemRegistrarVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmVenta());
        }

        private void itemVerVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmVerVentas());
        }

        private void itemEstadoVenta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmVentaEstado());
        }

        private void itemProdMasVendidos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashbord.frmDashboard());
        }

        private void itemProdMasComprados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reportes.frmProdComprado());
        }
    }
}
