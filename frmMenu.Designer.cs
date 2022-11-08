
namespace RotacionInventario
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnBitacoras = new FontAwesome.Sharp.IconButton();
            this.btnRoles = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnCategorias = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.paneTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.menuCategorias = new RotacionInventario.RJControls.RJDropdownMenu(this.components);
            this.itemVerCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstadoCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new RotacionInventario.RJControls.RJDropdownMenu(this.components);
            this.itemVerProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstadoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new RotacionInventario.RJControls.RJDropdownMenu(this.components);
            this.itemVerUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstadoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRoles = new RotacionInventario.RJControls.RJDropdownMenu(this.components);
            this.itemVerRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstadoRol = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBitacoras = new RotacionInventario.RJControls.RJDropdownMenu(this.components);
            this.itemBitacoraGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBitacoraLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new RotacionInventario.RJControls.RJDropdownMenu(this.components);
            this.itemRegistrarCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstadoCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new RotacionInventario.RJControls.RJDropdownMenu(this.components);
            this.itemRegistrarVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVerVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEstadoVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new RotacionInventario.RJControls.RJDropdownMenu(this.components);
            this.itemProdMasVendidos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdMasComprados = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMásVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.paneTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.menuCategorias.SuspendLayout();
            this.menuProductos.SuspendLayout();
            this.menuUsuarios.SuspendLayout();
            this.menuRoles.SuspendLayout();
            this.menuBitacoras.SuspendLayout();
            this.menuCompras.SuspendLayout();
            this.menuVentas.SuspendLayout();
            this.menuReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnBitacoras);
            this.panelMenu.Controls.Add(this.btnRoles);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnCategorias);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 1049);
            this.panelMenu.TabIndex = 51;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnReportes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 560);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Size = new System.Drawing.Size(220, 60);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "&Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click_1);
            // 
            // btnBitacoras
            // 
            this.btnBitacoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBitacoras.FlatAppearance.BorderSize = 0;
            this.btnBitacoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitacoras.IconChar = FontAwesome.Sharp.IconChar.Map;
            this.btnBitacoras.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBitacoras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBitacoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacoras.Location = new System.Drawing.Point(0, 500);
            this.btnBitacoras.Name = "btnBitacoras";
            this.btnBitacoras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBitacoras.Size = new System.Drawing.Size(220, 60);
            this.btnBitacoras.TabIndex = 7;
            this.btnBitacoras.Text = "&Bitácoras";
            this.btnBitacoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacoras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBitacoras.UseVisualStyleBackColor = true;
            this.btnBitacoras.Click += new System.EventHandler(this.btnBitacoras_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.btnRoles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(0, 440);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRoles.Size = new System.Drawing.Size(220, 60);
            this.btnRoles.TabIndex = 6;
            this.btnRoles.Text = "&Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnUsuarios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 380);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(220, 60);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "&Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCategorias.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 320);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCategorias.Size = new System.Drawing.Size(220, 60);
            this.btnCategorias.TabIndex = 4;
            this.btnCategorias.Text = "&Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnProductos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 260);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductos.Size = new System.Drawing.Size(220, 60);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "&Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnCompras.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 200);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCompras.Size = new System.Drawing.Size(220, 60);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "&Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 140);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVentas.Size = new System.Drawing.Size(220, 60);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "&Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(56, 25);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 100);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 49;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(10, 20);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(50, 49);
            this.iconCurrentChildForm.TabIndex = 52;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // paneTitleBar
            // 
            this.paneTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.paneTitleBar.Controls.Add(this.btnMinimize);
            this.paneTitleBar.Controls.Add(this.lblTitleChildForm);
            this.paneTitleBar.Controls.Add(this.btnMaximize);
            this.paneTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.paneTitleBar.Controls.Add(this.btnClose);
            this.paneTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneTitleBar.Location = new System.Drawing.Point(220, 0);
            this.paneTitleBar.Name = "paneTitleBar";
            this.paneTitleBar.Size = new System.Drawing.Size(1678, 80);
            this.paneTitleBar.TabIndex = 53;
            this.paneTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1426, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(80, 80);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(64, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(70, 29);
            this.lblTitleChildForm.TabIndex = 53;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1511, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(80, 80);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1597, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 80);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmHoraFecha
            // 
            this.tmHoraFecha.Enabled = true;
            this.tmHoraFecha.Tick += new System.EventHandler(this.tmHoraFecha_Tick);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 60;
            this.btnSalir.Location = new System.Drawing.Point(929, 598);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnSalir.Size = new System.Drawing.Size(200, 100);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.lblHora.Location = new System.Drawing.Point(447, 342);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(867, 135);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "hh:mm:ss x. m.";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.SlateGray;
            this.lblFecha.Location = new System.Drawing.Point(389, 480);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(893, 69);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "jueves, 1 de septiembre de 2022";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Controls.Add(this.lblFecha);
            this.panelDesktop.Controls.Add(this.lblHora);
            this.panelDesktop.Controls.Add(this.btnSalir);
            this.panelDesktop.Controls.Add(this.btnCerrarSesion);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1678, 969);
            this.panelDesktop.TabIndex = 54;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 60;
            this.btnCerrarSesion.Location = new System.Drawing.Point(597, 598);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 100);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "&Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // menuCategorias
            // 
            this.menuCategorias.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuCategorias.IsMainMenu = false;
            this.menuCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVerCategorias,
            this.itemEstadoCategoria});
            this.menuCategorias.MenuItemHeight = 25;
            this.menuCategorias.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuCategorias.Name = "rjDropdownMenu1";
            this.menuCategorias.PrimaryColor = System.Drawing.Color.Empty;
            this.menuCategorias.Size = new System.Drawing.Size(264, 76);
            // 
            // itemVerCategorias
            // 
            this.itemVerCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemVerCategorias.Name = "itemVerCategorias";
            this.itemVerCategorias.Size = new System.Drawing.Size(263, 36);
            this.itemVerCategorias.Text = "Ver categorías";
            this.itemVerCategorias.Click += new System.EventHandler(this.itemVerCategorias_Click);
            // 
            // itemEstadoCategoria
            // 
            this.itemEstadoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemEstadoCategoria.Name = "itemEstadoCategoria";
            this.itemEstadoCategoria.Size = new System.Drawing.Size(263, 36);
            this.itemEstadoCategoria.Text = "Modificar estado";
            this.itemEstadoCategoria.Click += new System.EventHandler(this.itemEstadoCategoria_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuProductos.IsMainMenu = false;
            this.menuProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVerProductos,
            this.itemEstadoProducto});
            this.menuProductos.MenuItemHeight = 25;
            this.menuProductos.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.PrimaryColor = System.Drawing.Color.Empty;
            this.menuProductos.Size = new System.Drawing.Size(264, 76);
            // 
            // itemVerProductos
            // 
            this.itemVerProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemVerProductos.Name = "itemVerProductos";
            this.itemVerProductos.Size = new System.Drawing.Size(263, 36);
            this.itemVerProductos.Text = "Ver productos";
            this.itemVerProductos.Click += new System.EventHandler(this.itemVerProductos_Click);
            // 
            // itemEstadoProducto
            // 
            this.itemEstadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemEstadoProducto.Name = "itemEstadoProducto";
            this.itemEstadoProducto.Size = new System.Drawing.Size(263, 36);
            this.itemEstadoProducto.Text = "Modificar estado";
            this.itemEstadoProducto.Click += new System.EventHandler(this.itemEstadoProducto_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuUsuarios.IsMainMenu = false;
            this.menuUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVerUsuarios,
            this.itemEstadoUsuario});
            this.menuUsuarios.MenuItemHeight = 25;
            this.menuUsuarios.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.PrimaryColor = System.Drawing.Color.Empty;
            this.menuUsuarios.Size = new System.Drawing.Size(264, 76);
            // 
            // itemVerUsuarios
            // 
            this.itemVerUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemVerUsuarios.Name = "itemVerUsuarios";
            this.itemVerUsuarios.Size = new System.Drawing.Size(263, 36);
            this.itemVerUsuarios.Text = "Ver usuarios";
            this.itemVerUsuarios.Click += new System.EventHandler(this.itemVerUsuarios_Click);
            // 
            // itemEstadoUsuario
            // 
            this.itemEstadoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemEstadoUsuario.Name = "itemEstadoUsuario";
            this.itemEstadoUsuario.Size = new System.Drawing.Size(263, 36);
            this.itemEstadoUsuario.Text = "Modificar estado";
            this.itemEstadoUsuario.Click += new System.EventHandler(this.itemEstadoUsuario_Click);
            // 
            // menuRoles
            // 
            this.menuRoles.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuRoles.IsMainMenu = false;
            this.menuRoles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVerRoles,
            this.itemEstadoRol});
            this.menuRoles.MenuItemHeight = 25;
            this.menuRoles.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuRoles.Name = "menuRoles";
            this.menuRoles.PrimaryColor = System.Drawing.Color.Empty;
            this.menuRoles.Size = new System.Drawing.Size(264, 76);
            // 
            // itemVerRoles
            // 
            this.itemVerRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemVerRoles.Name = "itemVerRoles";
            this.itemVerRoles.Size = new System.Drawing.Size(263, 36);
            this.itemVerRoles.Text = "Ver roles";
            this.itemVerRoles.Click += new System.EventHandler(this.itemVerRoles_Click);
            // 
            // itemEstadoRol
            // 
            this.itemEstadoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemEstadoRol.Name = "itemEstadoRol";
            this.itemEstadoRol.Size = new System.Drawing.Size(263, 36);
            this.itemEstadoRol.Text = "Modificar estado";
            this.itemEstadoRol.Click += new System.EventHandler(this.itemEstadoRol_Click);
            // 
            // menuBitacoras
            // 
            this.menuBitacoras.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBitacoras.IsMainMenu = false;
            this.menuBitacoras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBitacoraGeneral,
            this.itemBitacoraLogin});
            this.menuBitacoras.MenuItemHeight = 25;
            this.menuBitacoras.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuBitacoras.Name = "menuBitacoras";
            this.menuBitacoras.PrimaryColor = System.Drawing.Color.Empty;
            this.menuBitacoras.Size = new System.Drawing.Size(267, 76);
            // 
            // itemBitacoraGeneral
            // 
            this.itemBitacoraGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemBitacoraGeneral.Name = "itemBitacoraGeneral";
            this.itemBitacoraGeneral.Size = new System.Drawing.Size(266, 36);
            this.itemBitacoraGeneral.Text = "Bitácora general";
            this.itemBitacoraGeneral.Click += new System.EventHandler(this.itemBitacoraGeneral_Click);
            // 
            // itemBitacoraLogin
            // 
            this.itemBitacoraLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemBitacoraLogin.Name = "itemBitacoraLogin";
            this.itemBitacoraLogin.Size = new System.Drawing.Size(266, 36);
            this.itemBitacoraLogin.Text = "Bitácora de login";
            this.itemBitacoraLogin.Click += new System.EventHandler(this.itemBitacoraLogin_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuCompras.IsMainMenu = false;
            this.menuCompras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemRegistrarCompras,
            this.itemVerCompras,
            this.itemEstadoCompra});
            this.menuCompras.MenuItemHeight = 25;
            this.menuCompras.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.PrimaryColor = System.Drawing.Color.Empty;
            this.menuCompras.Size = new System.Drawing.Size(282, 112);
            // 
            // itemRegistrarCompras
            // 
            this.itemRegistrarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemRegistrarCompras.Name = "itemRegistrarCompras";
            this.itemRegistrarCompras.Size = new System.Drawing.Size(281, 36);
            this.itemRegistrarCompras.Text = "Registrar compra";
            this.itemRegistrarCompras.Click += new System.EventHandler(this.itemRegistrarCompras_Click);
            // 
            // itemVerCompras
            // 
            this.itemVerCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemVerCompras.Name = "itemVerCompras";
            this.itemVerCompras.Size = new System.Drawing.Size(281, 36);
            this.itemVerCompras.Text = "Inhabilitar Compra";
            this.itemVerCompras.Click += new System.EventHandler(this.itemVerCompras_Click);
            // 
            // itemEstadoCompra
            // 
            this.itemEstadoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemEstadoCompra.Name = "itemEstadoCompra";
            this.itemEstadoCompra.Size = new System.Drawing.Size(281, 36);
            this.itemEstadoCompra.Text = "Compras Inactivas";
            this.itemEstadoCompra.Click += new System.EventHandler(this.itemEstadoCompra_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuVentas.IsMainMenu = false;
            this.menuVentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemRegistrarVentas,
            this.itemVerVentas,
            this.itemEstadoVenta});
            this.menuVentas.MenuItemHeight = 25;
            this.menuVentas.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuVentas.Name = "menuCompras";
            this.menuVentas.PrimaryColor = System.Drawing.Color.Empty;
            this.menuVentas.Size = new System.Drawing.Size(269, 112);
            // 
            // itemRegistrarVentas
            // 
            this.itemRegistrarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemRegistrarVentas.Name = "itemRegistrarVentas";
            this.itemRegistrarVentas.Size = new System.Drawing.Size(268, 36);
            this.itemRegistrarVentas.Text = "Registrar venta";
            this.itemRegistrarVentas.Click += new System.EventHandler(this.itemRegistrarVentas_Click);
            // 
            // itemVerVentas
            // 
            this.itemVerVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemVerVentas.Name = "itemVerVentas";
            this.itemVerVentas.Size = new System.Drawing.Size(268, 36);
            this.itemVerVentas.Text = "Inhabilitar Ventas";
            this.itemVerVentas.Click += new System.EventHandler(this.itemVerVentas_Click);
            // 
            // itemEstadoVenta
            // 
            this.itemEstadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemEstadoVenta.Name = "itemEstadoVenta";
            this.itemEstadoVenta.Size = new System.Drawing.Size(268, 36);
            this.itemEstadoVenta.Text = "Ventas Inactivas";
            this.itemEstadoVenta.Click += new System.EventHandler(this.itemEstadoVenta_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuReportes.IsMainMenu = false;
            this.menuReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemProdMasVendidos,
            this.itemProdMasComprados,
            this.productosMásVendidosToolStripMenuItem});
            this.menuReportes.MenuItemHeight = 25;
            this.menuReportes.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.PrimaryColor = System.Drawing.Color.Empty;
            this.menuReportes.Size = new System.Drawing.Size(373, 145);
            // 
            // itemProdMasVendidos
            // 
            this.itemProdMasVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemProdMasVendidos.Name = "itemProdMasVendidos";
            this.itemProdMasVendidos.Size = new System.Drawing.Size(372, 36);
            this.itemProdMasVendidos.Text = "Dashboard";
            this.itemProdMasVendidos.Click += new System.EventHandler(this.itemProdMasVendidos_Click);
            // 
            // itemProdMasComprados
            // 
            this.itemProdMasComprados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemProdMasComprados.Name = "itemProdMasComprados";
            this.itemProdMasComprados.Size = new System.Drawing.Size(372, 36);
            this.itemProdMasComprados.Text = "Productos más comprados";
            this.itemProdMasComprados.Click += new System.EventHandler(this.itemProdMasComprados_Click);
            // 
            // productosMásVendidosToolStripMenuItem
            // 
            this.productosMásVendidosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productosMásVendidosToolStripMenuItem.Name = "productosMásVendidosToolStripMenuItem";
            this.productosMásVendidosToolStripMenuItem.Size = new System.Drawing.Size(372, 36);
            this.productosMásVendidosToolStripMenuItem.Text = "Productos más vendidos";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1049);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.paneTitleBar.ResumeLayout(false);
            this.paneTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.menuCategorias.ResumeLayout(false);
            this.menuProductos.ResumeLayout(false);
            this.menuUsuarios.ResumeLayout(false);
            this.menuRoles.ResumeLayout(false);
            this.menuBitacoras.ResumeLayout(false);
            this.menuCompras.ResumeLayout(false);
            this.menuVentas.ResumeLayout(false);
            this.menuReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnBitacoras;
        private FontAwesome.Sharp.IconButton btnRoles;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnCategorias;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton btnVentas;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel paneTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private FontAwesome.Sharp.IconButton btnReportes;
        private RJControls.RJDropdownMenu menuCategorias;
        private System.Windows.Forms.ToolStripMenuItem itemVerCategorias;
        private System.Windows.Forms.ToolStripMenuItem itemEstadoCategoria;
        private RJControls.RJDropdownMenu menuProductos;
        private System.Windows.Forms.ToolStripMenuItem itemVerProductos;
        private System.Windows.Forms.ToolStripMenuItem itemEstadoProducto;
        private RJControls.RJDropdownMenu menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem itemVerUsuarios;
        private System.Windows.Forms.ToolStripMenuItem itemEstadoUsuario;
        private RJControls.RJDropdownMenu menuRoles;
        private System.Windows.Forms.ToolStripMenuItem itemVerRoles;
        private System.Windows.Forms.ToolStripMenuItem itemEstadoRol;
        private RJControls.RJDropdownMenu menuBitacoras;
        private System.Windows.Forms.ToolStripMenuItem itemBitacoraGeneral;
        private System.Windows.Forms.ToolStripMenuItem itemBitacoraLogin;
        private System.Windows.Forms.Timer tmHoraFecha;
        private RJControls.RJDropdownMenu menuCompras;
        private System.Windows.Forms.ToolStripMenuItem itemRegistrarCompras;
        private System.Windows.Forms.ToolStripMenuItem itemEstadoCompra;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.ToolStripMenuItem itemVerCompras;
        private RJControls.RJDropdownMenu menuVentas;
        private System.Windows.Forms.ToolStripMenuItem itemRegistrarVentas;
        private System.Windows.Forms.ToolStripMenuItem itemVerVentas;
        private System.Windows.Forms.ToolStripMenuItem itemEstadoVenta;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private RJControls.RJDropdownMenu menuReportes;
        private System.Windows.Forms.ToolStripMenuItem itemProdMasVendidos;
        private System.Windows.Forms.ToolStripMenuItem itemProdMasComprados;
        private System.Windows.Forms.ToolStripMenuItem productosMásVendidosToolStripMenuItem;
    }
}

