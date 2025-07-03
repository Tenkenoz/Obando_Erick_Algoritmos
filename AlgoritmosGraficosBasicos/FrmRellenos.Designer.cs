namespace Obando_Erick_Algoritmos
{
    partial class FrmRellenos
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
            this.btnLados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLados2 = new System.Windows.Forms.TextBox();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.btnLados2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.picCanvas2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLados
            // 
            this.btnLados.Location = new System.Drawing.Point(263, 92);
            this.btnLados.Name = "btnLados";
            this.btnLados.Size = new System.Drawing.Size(75, 23);
            this.btnLados.TabIndex = 40;
            this.btnLados.Text = "Dibujar";
            this.btnLados.UseVisualStyleBackColor = true;
            this.btnLados.Click += new System.EventHandler(this.btnLados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Numero de lados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLados2
            // 
            this.txtLados2.Location = new System.Drawing.Point(557, 91);
            this.txtLados2.Name = "txtLados2";
            this.txtLados2.Size = new System.Drawing.Size(81, 22);
            this.txtLados2.TabIndex = 36;
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(150, 94);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(81, 22);
            this.txtLados.TabIndex = 34;
            // 
            // btnLados2
            // 
            this.btnLados2.Location = new System.Drawing.Point(678, 92);
            this.btnLados2.Name = "btnLados2";
            this.btnLados2.Size = new System.Drawing.Size(75, 23);
            this.btnLados2.TabIndex = 33;
            this.btnLados2.Text = "Dibujar";
            this.btnLados2.UseVisualStyleBackColor = true;
            this.btnLados2.Click += new System.EventHandler(this.btnLados2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 32;
            // 
            // picCanvas2
            // 
            this.picCanvas2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picCanvas2.Location = new System.Drawing.Point(408, 126);
            this.picCanvas2.Name = "picCanvas2";
            this.picCanvas2.Size = new System.Drawing.Size(391, 311);
            this.picCanvas2.TabIndex = 31;
            this.picCanvas2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(403, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Algoritmo de Bresenham para circunferencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(145, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Flood Fill";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(239, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 29);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Relleno de regiones";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picCanvas.Location = new System.Drawing.Point(6, 126);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(396, 311);
            this.picCanvas.TabIndex = 27;
            this.picCanvas.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label5.Location = new System.Drawing.Point(241, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Si ingresa un numero menor a 3, se dibujara un circulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Numero de lados";
            // 
            // FrmRellenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLados2);
            this.Controls.Add(this.txtLados);
            this.Controls.Add(this.btnLados2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picCanvas2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmRellenos";
            this.Text = "FrmPoligonos";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLados2;
        private System.Windows.Forms.TextBox txtLados;
        private System.Windows.Forms.Button btnLados2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picCanvas2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}