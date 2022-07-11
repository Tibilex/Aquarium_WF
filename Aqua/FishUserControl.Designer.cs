namespace Aqua
{
    partial class FishUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FishUserControl));
            this.fish1 = new Aqua.Fish();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fish1)).BeginInit();
            this.SuspendLayout();
            // 
            // fish1
            // 
            this.fish1.BackColor = System.Drawing.Color.Transparent;
            this.fish1.Form = null;
            this.fish1.Image = ((System.Drawing.Image)(resources.GetObject("fish1.Image")));
            this.fish1.Location = new System.Drawing.Point(0, 8);
            this.fish1.Name = "fish1";
            this.fish1.Size = new System.Drawing.Size(121, 120);
            this.fish1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish1.TabIndex = 0;
            this.fish1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПОКОРМИ МЕНЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FishUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fish1);
            this.Name = "FishUserControl";
            this.Size = new System.Drawing.Size(121, 128);
            ((System.ComponentModel.ISupportInitialize)(this.fish1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Label label1;
        internal Fish fish1;
    }
}
