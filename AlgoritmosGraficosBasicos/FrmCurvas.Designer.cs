namespace Obando_Erick_Algoritmos
{
    partial class FrmCurvas
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picCanvas2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSMayor = new System.Windows.Forms.TextBox();
            this.txtSMenor = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDibujar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 16;
            // 
            // picCanvas2
            // 
            this.picCanvas2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picCanvas2.Location = new System.Drawing.Point(408, 121);
            this.picCanvas2.Name = "picCanvas2";
            this.picCanvas2.Size = new System.Drawing.Size(391, 311);
            this.picCanvas2.TabIndex = 15;
            this.picCanvas2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(403, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Algoritmo de Bresenham para circunferencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Algoritmo de Bresenham para elipses";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(246, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 29);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Rasterización de curvas";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picCanvas.Location = new System.Drawing.Point(6, 153);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(396, 279);
            this.picCanvas.TabIndex = 9;
            this.picCanvas.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSMayor
            // 
            this.txtSMayor.Location = new System.Drawing.Point(107, 92);
            this.txtSMayor.Name = "txtSMayor";
            this.txtSMayor.Size = new System.Drawing.Size(81, 22);
            this.txtSMayor.TabIndex = 20;
            // 
            // txtSMenor
            // 
            this.txtSMenor.Location = new System.Drawing.Point(107, 121);
            this.txtSMenor.Name = "txtSMenor";
            this.txtSMenor.Size = new System.Drawing.Size(81, 22);
            this.txtSMenor.TabIndex = 21;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(575, 93);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(81, 22);
            this.txtRadio.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Radio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Semieje mayor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Semieje menor";
            // 
            // btnDibujar2
            // 
            this.btnDibujar2.Location = new System.Drawing.Point(227, 105);
            this.btnDibujar2.Name = "btnDibujar2";
            this.btnDibujar2.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar2.TabIndex = 26;
            this.btnDibujar2.Text = "Dibujar";
            this.btnDibujar2.UseVisualStyleBackColor = true;
            this.btnDibujar2.Click += new System.EventHandler(this.btnDibujar2_Click);
            // 
            // FrmCurvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDibujar2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtSMenor);
            this.Controls.Add(this.txtSMayor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picCanvas2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmCurvas";
            this.Text = "FrmCirculo";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picCanvas2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSMayor;
        private System.Windows.Forms.TextBox txtSMenor;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDibujar2;
    }
}