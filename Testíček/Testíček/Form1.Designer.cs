namespace Testíček
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Aqua = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.Velikost = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.PictureBox();
            this.Black = new System.Windows.Forms.PictureBox();
            this.Yellow = new System.Windows.Forms.PictureBox();
            this.Green = new System.Windows.Forms.PictureBox();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Aqua)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(3, 3);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(34, 31);
            this.Aqua.TabIndex = 0;
            this.Aqua.TabStop = false;
            this.Aqua.Click += new System.EventHandler(this.Aqua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSize);
            this.panel1.Controls.Add(this.Velikost);
            this.panel1.Controls.Add(this.Red);
            this.panel1.Controls.Add(this.Black);
            this.panel1.Controls.Add(this.Yellow);
            this.panel1.Controls.Add(this.Green);
            this.panel1.Controls.Add(this.Aqua);
            this.panel1.Location = new System.Drawing.Point(13, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 81);
            this.panel1.TabIndex = 1;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(210, 8);
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 20);
            this.numSize.TabIndex = 6;
            // 
            // Velikost
            // 
            this.Velikost.AutoSize = true;
            this.Velikost.Location = new System.Drawing.Point(336, 10);
            this.Velikost.Name = "Velikost";
            this.Velikost.Size = new System.Drawing.Size(44, 13);
            this.Velikost.TabIndex = 5;
            this.Velikost.Text = "Velikost";
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Crimson;
            this.Red.Location = new System.Drawing.Point(163, 3);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(34, 31);
            this.Red.TabIndex = 4;
            this.Red.TabStop = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(123, 3);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(34, 31);
            this.Black.TabIndex = 3;
            this.Black.TabStop = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(83, 3);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(34, 31);
            this.Yellow.TabIndex = 2;
            this.Yellow.TabStop = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(43, 3);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(34, 31);
            this.Green.TabIndex = 1;
            this.Green.TabStop = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // pbox1
            // 
            this.pbox1.Location = new System.Drawing.Point(13, 12);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(1193, 534);
            this.pbox1.TabIndex = 2;
            this.pbox1.TabStop = false;
            this.pbox1.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pbox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pbox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 641);
            this.Controls.Add(this.pbox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Aqua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Aqua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label Velikost;
        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.PictureBox Black;
        private System.Windows.Forms.PictureBox Yellow;
        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

