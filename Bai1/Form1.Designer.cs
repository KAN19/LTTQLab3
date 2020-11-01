namespace Bai1
{
    partial class RandomCorlorChanging
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
            this.button_ChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ChangeColor
            // 
            this.button_ChangeColor.Location = new System.Drawing.Point(135, 102);
            this.button_ChangeColor.Name = "button_ChangeColor";
            this.button_ChangeColor.Size = new System.Drawing.Size(113, 40);
            this.button_ChangeColor.TabIndex = 0;
            this.button_ChangeColor.Text = "Change Color";
            this.button_ChangeColor.UseVisualStyleBackColor = true;
            this.button_ChangeColor.Click += new System.EventHandler(this.button_ChangeColor_Click);
            // 
            // RandomCorlorChanging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 273);
            this.Controls.Add(this.button_ChangeColor);
            this.Name = "RandomCorlorChanging";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ChangeColor;
    }
}

