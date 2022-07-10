namespace Aqua
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FishPictureBox = new System.Windows.Forms.PictureBox();
            this.FishMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FishPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FishPictureBox
            // 
            this.FishPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.FishPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FishPictureBox.Image = global::Aqua.Properties.Resources.fish;
            this.FishPictureBox.InitialImage = null;
            this.FishPictureBox.Location = new System.Drawing.Point(43, 42);
            this.FishPictureBox.Name = "FishPictureBox";
            this.FishPictureBox.Size = new System.Drawing.Size(383, 331);
            this.FishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FishPictureBox.TabIndex = 0;
            this.FishPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aqua.Properties.Resources._5b01d815bf894;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FishPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FishPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox FishPictureBox;
        private System.Windows.Forms.Timer FishMoveTimer;
    }
}