namespace PROCESO_CRUD
{
    partial class frmAplicacion
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msiGaleria = new System.Windows.Forms.ToolStripMenuItem();
            this.msiInfoCreador = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiGaleria,
            this.msiInfoCreador});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(532, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // msiGaleria
            // 
            this.msiGaleria.Image = global::PROCESO_CRUD.Properties.Resources.gallery;
            this.msiGaleria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiGaleria.Name = "msiGaleria";
            this.msiGaleria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msiGaleria.Size = new System.Drawing.Size(71, 20);
            this.msiGaleria.Text = "&Galeria";
            this.msiGaleria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msiGaleria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.msiGaleria.Click += new System.EventHandler(this.msiGaleria_Click);
            // 
            // msiInfoCreador
            // 
            this.msiInfoCreador.Image = global::PROCESO_CRUD.Properties.Resources.pro;
            this.msiInfoCreador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msiInfoCreador.Name = "msiInfoCreador";
            this.msiInfoCreador.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msiInfoCreador.Size = new System.Drawing.Size(77, 20);
            this.msiInfoCreador.Text = "&Creador";
            this.msiInfoCreador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msiInfoCreador.Click += new System.EventHandler(this.msiInfoCreador_Click);
            // 
            // frmAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 407);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.Name = "frmAplicacion";
            this.Text = "fmrAplicacion";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msiGaleria;
        private System.Windows.Forms.ToolStripMenuItem msiInfoCreador;
    }
}