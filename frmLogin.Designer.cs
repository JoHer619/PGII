
namespace RotacionInventario
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.bD_INVENTARIODataSet = new RotacionInventario.BD_INVENTARIODataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbUsuarioTableAdapter();
            this.tbRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRolTableAdapter = new RotacionInventario.BD_INVENTARIODataSetTableAdapters.tbRolTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(303, 296);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(196, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "INICIAR SESIÓN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 400);
            this.panel1.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Lato", 14F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(303, 129);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(408, 34);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(303, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(303, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 1);
            this.panel3.TabIndex = 12;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Lato", 14F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(303, 205);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(408, 34);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // bD_INVENTARIODataSet
            // 
            this.bD_INVENTARIODataSet.DataSetName = "BD_INVENTARIODataSet";
            this.bD_INVENTARIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tbRolBindingSource
            // 
            this.tbRolBindingSource.DataMember = "tbRol";
            this.tbRolBindingSource.DataSource = this.bD_INVENTARIODataSet;
            // 
            // tbRolTableAdapter
            // 
            this.tbRolTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalir.Location = new System.Drawing.Point(531, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 60);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_INVENTARIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPass;
        private BD_INVENTARIODataSet bD_INVENTARIODataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.BindingSource tbRolBindingSource;
        private BD_INVENTARIODataSetTableAdapters.tbRolTableAdapter tbRolTableAdapter;
        private System.Windows.Forms.Button btnSalir;
    }
}