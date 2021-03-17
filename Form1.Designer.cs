
namespace Taller1U3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudSX = new System.Windows.Forms.NumericUpDown();
            this.nudSY = new System.Windows.Forms.NumericUpDown();
            this.nudIX = new System.Windows.Forms.NumericUpDown();
            this.nudIY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIY)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSX
            // 
            this.nudSX.Location = new System.Drawing.Point(128, 59);
            this.nudSX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSX.Name = "nudSX";
            this.nudSX.Size = new System.Drawing.Size(49, 22);
            this.nudSX.TabIndex = 0;
            // 
            // nudSY
            // 
            this.nudSY.Location = new System.Drawing.Point(211, 59);
            this.nudSY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSY.Name = "nudSY";
            this.nudSY.Size = new System.Drawing.Size(49, 22);
            this.nudSY.TabIndex = 1;
            // 
            // nudIX
            // 
            this.nudIX.Location = new System.Drawing.Point(128, 110);
            this.nudIX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudIX.Name = "nudIX";
            this.nudIX.Size = new System.Drawing.Size(49, 22);
            this.nudIX.TabIndex = 2;
            // 
            // nudIY
            // 
            this.nudIY.Location = new System.Drawing.Point(212, 111);
            this.nudIY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudIY.Name = "nudIY";
            this.nudIY.Size = new System.Drawing.Size(49, 22);
            this.nudIY.TabIndex = 3;
            this.nudIY.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Superior Izquierda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inf. Derecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCanvas);
            this.groupBox1.Location = new System.Drawing.Point(299, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 405);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 22);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(476, 377);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(10, 176);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 9;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudIY);
            this.Controls.Add(this.nudIX);
            this.Controls.Add(this.nudSY);
            this.Controls.Add(this.nudSX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSX;
        private System.Windows.Forms.NumericUpDown nudSY;
        private System.Windows.Forms.NumericUpDown nudIX;
        private System.Windows.Forms.NumericUpDown nudIY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDraw;
    }
}

