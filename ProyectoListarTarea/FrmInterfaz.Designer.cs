namespace ProyectoListarTarea
{
    partial class FrmInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInterfaz));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMarcadas = new System.Windows.Forms.Button();
            this.btnVerTabla = new System.Windows.Forms.Button();
            this.btnModicar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pbRestaurar);
            this.panelTop.Controls.Add(this.pbMaximizar);
            this.panelTop.Controls.Add(this.pbMinimizar);
            this.panelTop.Controls.Add(this.pbCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 35);
            this.panelTop.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panelLeft.Controls.Add(this.btnMarcadas);
            this.panelLeft.Controls.Add(this.btnVerTabla);
            this.panelLeft.Controls.Add(this.btnModicar);
            this.panelLeft.Controls.Add(this.btnAgregar);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 35);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 615);
            this.panelLeft.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(220, 35);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1080, 615);
            this.panelCenter.TabIndex = 2;
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(531, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Programa de listar tareas";
            // 
            // btnMarcadas
            // 
            this.btnMarcadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcadas.FlatAppearance.BorderSize = 0;
            this.btnMarcadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnMarcadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcadas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMarcadas.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcadas.Image")));
            this.btnMarcadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcadas.Location = new System.Drawing.Point(0, 361);
            this.btnMarcadas.Name = "btnMarcadas";
            this.btnMarcadas.Size = new System.Drawing.Size(220, 50);
            this.btnMarcadas.TabIndex = 3;
            this.btnMarcadas.Text = "Tareas ✅";
            this.btnMarcadas.UseVisualStyleBackColor = false;
            this.btnMarcadas.Click += new System.EventHandler(this.btnMarcadas_Click);
            // 
            // btnVerTabla
            // 
            this.btnVerTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTabla.FlatAppearance.BorderSize = 0;
            this.btnVerTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnVerTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTabla.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerTabla.Image = ((System.Drawing.Image)(resources.GetObject("btnVerTabla.Image")));
            this.btnVerTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTabla.Location = new System.Drawing.Point(0, 305);
            this.btnVerTabla.Name = "btnVerTabla";
            this.btnVerTabla.Size = new System.Drawing.Size(220, 50);
            this.btnVerTabla.TabIndex = 2;
            this.btnVerTabla.Text = "Ver Tareas";
            this.btnVerTabla.UseVisualStyleBackColor = false;
            this.btnVerTabla.Click += new System.EventHandler(this.btnVerTabla_Click);
            // 
            // btnModicar
            // 
            this.btnModicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnModicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModicar.FlatAppearance.BorderSize = 0;
            this.btnModicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnModicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModicar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModicar.Image = ((System.Drawing.Image)(resources.GetObject("btnModicar.Image")));
            this.btnModicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModicar.Location = new System.Drawing.Point(0, 249);
            this.btnModicar.Name = "btnModicar";
            this.btnModicar.Size = new System.Drawing.Size(220, 50);
            this.btnModicar.TabIndex = 1;
            this.btnModicar.Text = "Modificar Tarea";
            this.btnModicar.UseVisualStyleBackColor = false;
            this.btnModicar.Click += new System.EventHandler(this.btnModicar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(220, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pbRestaurar.Image")));
            this.pbRestaurar.Location = new System.Drawing.Point(1233, 3);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestaurar.TabIndex = 3;
            this.pbRestaurar.TabStop = false;
            this.pbRestaurar.Visible = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(1233, 4);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizar.TabIndex = 2;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(1202, 4);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 1;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(1264, 4);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 25);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // FrmInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInterfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInterfaz";
            this.Load += new System.EventHandler(this.FrmInterfaz_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerTabla;
        private System.Windows.Forms.Button btnModicar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMarcadas;
        private System.Windows.Forms.Label label1;
    }
}