namespace Obando_Erick_Algoritmos
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteGeométricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dePolígonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasParamétricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasDeBézierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsplinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineasToolStripMenuItem,
            this.poligonosToolStripMenuItem,
            this.recorteGeométricoToolStripMenuItem,
            this.curvasParamétricasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lineasToolStripMenuItem
            // 
            this.lineasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.curvasToolStripMenuItem});
            this.lineasToolStripMenuItem.Name = "lineasToolStripMenuItem";
            this.lineasToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.lineasToolStripMenuItem.Text = "Rasterización";
            this.lineasToolStripMenuItem.Click += new System.EventHandler(this.lineasToolStripMenuItem_Click);
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dDAToolStripMenuItem.Text = "Líneas";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // curvasToolStripMenuItem
            // 
            this.curvasToolStripMenuItem.Name = "curvasToolStripMenuItem";
            this.curvasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.curvasToolStripMenuItem.Text = "Curvas";
            this.curvasToolStripMenuItem.Click += new System.EventHandler(this.curvasToolStripMenuItem_Click);
            // 
            // poligonosToolStripMenuItem
            // 
            this.poligonosToolStripMenuItem.Name = "poligonosToolStripMenuItem";
            this.poligonosToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.poligonosToolStripMenuItem.Text = "Relleno";
            this.poligonosToolStripMenuItem.Click += new System.EventHandler(this.poligonosToolStripMenuItem_Click);
            // 
            // recorteGeométricoToolStripMenuItem
            // 
            this.recorteGeométricoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recorteToolStripMenuItem,
            this.dePolígonosToolStripMenuItem});
            this.recorteGeométricoToolStripMenuItem.Name = "recorteGeométricoToolStripMenuItem";
            this.recorteGeométricoToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.recorteGeométricoToolStripMenuItem.Text = "Recorte geométrico";
            // 
            // recorteToolStripMenuItem
            // 
            this.recorteToolStripMenuItem.Name = "recorteToolStripMenuItem";
            this.recorteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recorteToolStripMenuItem.Text = "De líneas";
            this.recorteToolStripMenuItem.Click += new System.EventHandler(this.recorteToolStripMenuItem_Click);
            // 
            // dePolígonosToolStripMenuItem
            // 
            this.dePolígonosToolStripMenuItem.Name = "dePolígonosToolStripMenuItem";
            this.dePolígonosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dePolígonosToolStripMenuItem.Text = "De polígonos";
            this.dePolígonosToolStripMenuItem.Click += new System.EventHandler(this.dePolígonosToolStripMenuItem_Click);
            // 
            // curvasParamétricasToolStripMenuItem
            // 
            this.curvasParamétricasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curvasDeBézierToolStripMenuItem,
            this.bsplinesToolStripMenuItem});
            this.curvasParamétricasToolStripMenuItem.Name = "curvasParamétricasToolStripMenuItem";
            this.curvasParamétricasToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.curvasParamétricasToolStripMenuItem.Text = "Curvas paramétricas";
            // 
            // curvasDeBézierToolStripMenuItem
            // 
            this.curvasDeBézierToolStripMenuItem.Name = "curvasDeBézierToolStripMenuItem";
            this.curvasDeBézierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.curvasDeBézierToolStripMenuItem.Text = "Curvas de Bézier";
            this.curvasDeBézierToolStripMenuItem.Click += new System.EventHandler(this.curvasDeBézierToolStripMenuItem_Click);
            // 
            // bsplinesToolStripMenuItem
            // 
            this.bsplinesToolStripMenuItem.Name = "bsplinesToolStripMenuItem";
            this.bsplinesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bsplinesToolStripMenuItem.Text = "B-splines";
            this.bsplinesToolStripMenuItem.Click += new System.EventHandler(this.bsplinesToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1112, 506);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteGeométricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dePolígonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasParamétricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasDeBézierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bsplinesToolStripMenuItem;
    }
}