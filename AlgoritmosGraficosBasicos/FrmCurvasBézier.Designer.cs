namespace Obando_Erick_Algoritmos
{
    partial class FrmCurvasBézier
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.trackBarPrecision = new System.Windows.Forms.TrackBar();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(28, 116);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(744, 287);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(76, 72);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(100, 22);
            this.txtPuntos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // trackBarPrecision
            // 
            this.trackBarPrecision.Location = new System.Drawing.Point(101, 416);
            this.trackBarPrecision.Name = "trackBarPrecision";
            this.trackBarPrecision.Size = new System.Drawing.Size(558, 56);
            this.trackBarPrecision.TabIndex = 4;
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Location = new System.Drawing.Point(405, 78);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(44, 16);
            this.lblPrecision.TabIndex = 5;
            this.lblPrecision.Text = "label1";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(498, 75);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(177, 16);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Ingrese un valor para dibujar";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(246, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 29);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Curvas paramétricas";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(292, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Curvas de Bézier";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmCurvasBézier
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.trackBarPrecision);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmCurvasBézier";
            this.Text = "FrmCurvasBézier";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrecision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TrackBar trackBarPrecision;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
    }
}