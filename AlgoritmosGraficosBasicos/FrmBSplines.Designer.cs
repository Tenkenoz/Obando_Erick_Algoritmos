namespace Obando_Erick_Algoritmos
{
    partial class FrmBSplines
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearCurva = new System.Windows.Forms.Button();
            this.trackBarPrecision = new System.Windows.Forms.TrackBar();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.trackBarGrado = new System.Windows.Forms.TrackBar();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(16, 15);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(799, 492);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick_1);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown_1);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove_1);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp_1);
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(827, 124);
            this.txtPuntos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(132, 22);
            this.txtPuntos.TabIndex = 1;
            this.txtPuntos.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de puntos:";
            // 
            // btnCrearCurva
            // 
            this.btnCrearCurva.Location = new System.Drawing.Point(827, 156);
            this.btnCrearCurva.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCurva.Name = "btnCrearCurva";
            this.btnCrearCurva.Size = new System.Drawing.Size(133, 37);
            this.btnCrearCurva.TabIndex = 3;
            this.btnCrearCurva.Text = "Crear Curva";
            this.btnCrearCurva.UseVisualStyleBackColor = true;
            this.btnCrearCurva.Click += new System.EventHandler(this.btnCrearCurva_Click);
            // 
            // trackBarPrecision
            // 
            this.trackBarPrecision.Location = new System.Drawing.Point(827, 225);
            this.trackBarPrecision.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarPrecision.Name = "trackBarPrecision";
            this.trackBarPrecision.Size = new System.Drawing.Size(227, 56);
            this.trackBarPrecision.TabIndex = 4;
            this.trackBarPrecision.Scroll += new System.EventHandler(this.trackBarPrecision_Scroll);
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Location = new System.Drawing.Point(827, 205);
            this.lblPrecision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(69, 16);
            this.lblPrecision.TabIndex = 5;
            this.lblPrecision.Text = "Precisión: ";
            // 
            // trackBarGrado
            // 
            this.trackBarGrado.Location = new System.Drawing.Point(827, 311);
            this.trackBarGrado.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarGrado.Name = "trackBarGrado";
            this.trackBarGrado.Size = new System.Drawing.Size(227, 56);
            this.trackBarGrado.TabIndex = 6;
            this.trackBarGrado.Scroll += new System.EventHandler(this.trackBarGrado_Scroll);
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(827, 291);
            this.lblGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(48, 16);
            this.lblGrado.TabIndex = 7;
            this.lblGrado.Text = "Grado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 511);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(136, 16);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Listo para crear curva";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(827, 374);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(133, 37);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(885, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "B-splines";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(822, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 25);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = "Curvas paramétricas";
            // 
            // FrmBSplines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.trackBarGrado);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.trackBarPrecision);
            this.Controls.Add(this.btnCrearCurva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.picCanvas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBSplines";
            this.Text = "Curvas B-Spline";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearCurva;
        private System.Windows.Forms.TrackBar trackBarPrecision;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.TrackBar trackBarGrado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
    }
}