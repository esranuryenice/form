namespace UzayYolu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heart_box = new System.Windows.Forms.PictureBox();
            this.bomba_atma = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.heart_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba_atma)).BeginInit();
            this.SuspendLayout();
            // 
            // heart_box
            // 
            this.heart_box.BackColor = System.Drawing.Color.Transparent;
            this.heart_box.Image = ((System.Drawing.Image)(resources.GetObject("heart_box.Image")));
            this.heart_box.Location = new System.Drawing.Point(12, 12);
            this.heart_box.Name = "heart_box";
            this.heart_box.Size = new System.Drawing.Size(100, 50);
            this.heart_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart_box.TabIndex = 0;
            this.heart_box.TabStop = false;
            // 
            // bomba_atma
            // 
            this.bomba_atma.BackColor = System.Drawing.Color.Transparent;
            this.bomba_atma.Image = ((System.Drawing.Image)(resources.GetObject("bomba_atma.Image")));
            this.bomba_atma.Location = new System.Drawing.Point(27, 84);
            this.bomba_atma.Name = "bomba_atma";
            this.bomba_atma.Size = new System.Drawing.Size(16, 16);
            this.bomba_atma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bomba_atma.TabIndex = 1;
            this.bomba_atma.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 398);
            this.Controls.Add(this.bomba_atma);
            this.Controls.Add(this.heart_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.heart_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba_atma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox heart_box;
        private System.Windows.Forms.PictureBox bomba_atma;
        private System.Windows.Forms.Timer timer1;
    }
}

