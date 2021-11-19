namespace SNAKE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timermovimiento = new System.Windows.Forms.Timer(this.components);
            this.cuadrojuego = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.puntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuadrojuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timermovimiento
            // 
            this.timermovimiento.Enabled = true;
            this.timermovimiento.Tick += new System.EventHandler(this.timermovimiento_Tick);
            // 
            // cuadrojuego
            // 
            this.cuadrojuego.BackColor = System.Drawing.Color.Silver;
            this.cuadrojuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuadrojuego.Location = new System.Drawing.Point(40, 40);
            this.cuadrojuego.Name = "cuadrojuego";
            this.cuadrojuego.Size = new System.Drawing.Size(1200, 600);
            this.cuadrojuego.TabIndex = 2;
            this.cuadrojuego.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 653);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(179, 657);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(37, 40);
            this.puntaje.TabIndex = 4;
            this.puntaje.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cuadrojuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNAKE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cuadrojuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timermovimiento;
        private System.Windows.Forms.PictureBox cuadrojuego;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label puntaje;
    }
}