namespace SNAKE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sonidooff = new System.Windows.Forms.Button();
            this.sonidoon = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Button();
            this.creadores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creadores)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.play.AutoSize = true;
            this.play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play.BackColor = System.Drawing.Color.LawnGreen;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.ForeColor = System.Drawing.Color.LawnGreen;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(966, 294);
            this.play.Margin = new System.Windows.Forms.Padding(0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(278, 216);
            this.play.TabIndex = 0;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.btplay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 760);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // sonidooff
            // 
            this.sonidooff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sonidooff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sonidooff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sonidooff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sonidooff.Image = ((System.Drawing.Image)(resources.GetObject("sonidooff.Image")));
            this.sonidooff.Location = new System.Drawing.Point(52, 6);
            this.sonidooff.Name = "sonidooff";
            this.sonidooff.Size = new System.Drawing.Size(43, 39);
            this.sonidooff.TabIndex = 8;
            this.sonidooff.UseVisualStyleBackColor = true;
            this.sonidooff.Click += new System.EventHandler(this.sonidooff_Click);
            // 
            // sonidoon
            // 
            this.sonidoon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sonidoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sonidoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sonidoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sonidoon.Image = ((System.Drawing.Image)(resources.GetObject("sonidoon.Image")));
            this.sonidoon.Location = new System.Drawing.Point(5, 6);
            this.sonidoon.Name = "sonidoon";
            this.sonidoon.Size = new System.Drawing.Size(41, 39);
            this.sonidoon.TabIndex = 9;
            this.sonidoon.UseVisualStyleBackColor = true;
            this.sonidoon.Click += new System.EventHandler(this.sonidoon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // info
            // 
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(100, 6);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(43, 39);
            this.info.TabIndex = 11;
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // creadores
            // 
            this.creadores.Image = ((System.Drawing.Image)(resources.GetObject("creadores.Image")));
            this.creadores.Location = new System.Drawing.Point(12, 78);
            this.creadores.Name = "creadores";
            this.creadores.Size = new System.Drawing.Size(228, 350);
            this.creadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.creadores.TabIndex = 12;
            this.creadores.TabStop = false;
            this.creadores.Visible = false;
            this.creadores.Click += new System.EventHandler(this.creadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(252)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(856, 508);
            this.Controls.Add(this.creadores);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sonidoon);
            this.Controls.Add(this.sonidooff);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(252)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SNAKE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sonidooff;
        private System.Windows.Forms.Button sonidoon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.PictureBox creadores;
    }
}

