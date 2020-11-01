namespace Bai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Num1 = new System.Windows.Forms.TextBox();
            this.textBox_Num2 = new System.Windows.Forms.TextBox();
            this.textBox_Ans = new System.Windows.Forms.TextBox();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_mutiple = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Answer";
            // 
            // textBox_Num1
            // 
            this.textBox_Num1.Location = new System.Drawing.Point(168, 62);
            this.textBox_Num1.Name = "textBox_Num1";
            this.textBox_Num1.Size = new System.Drawing.Size(237, 20);
            this.textBox_Num1.TabIndex = 1;
            this.textBox_Num1.Text = "0";
            // 
            // textBox_Num2
            // 
            this.textBox_Num2.Location = new System.Drawing.Point(168, 99);
            this.textBox_Num2.Name = "textBox_Num2";
            this.textBox_Num2.Size = new System.Drawing.Size(237, 20);
            this.textBox_Num2.TabIndex = 1;
            this.textBox_Num2.Text = "0";
            // 
            // textBox_Ans
            // 
            this.textBox_Ans.Enabled = false;
            this.textBox_Ans.Location = new System.Drawing.Point(168, 212);
            this.textBox_Ans.Name = "textBox_Ans";
            this.textBox_Ans.Size = new System.Drawing.Size(237, 20);
            this.textBox_Ans.TabIndex = 1;
            // 
            // button_Plus
            // 
            this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus.Location = new System.Drawing.Point(130, 145);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(63, 34);
            this.button_Plus.TabIndex = 2;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(199, 145);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(63, 34);
            this.button_minus.TabIndex = 2;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_mutiple
            // 
            this.button_mutiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mutiple.Location = new System.Drawing.Point(268, 145);
            this.button_mutiple.Name = "button_mutiple";
            this.button_mutiple.Size = new System.Drawing.Size(63, 34);
            this.button_mutiple.TabIndex = 2;
            this.button_mutiple.Text = "*";
            this.button_mutiple.UseVisualStyleBackColor = true;
            this.button_mutiple.Click += new System.EventHandler(this.button_mutiple_Click);
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.Location = new System.Drawing.Point(337, 145);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(63, 34);
            this.button_divide.TabIndex = 2;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 299);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_mutiple);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.textBox_Ans);
            this.Controls.Add(this.textBox_Num2);
            this.Controls.Add(this.textBox_Num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Num1;
        private System.Windows.Forms.TextBox textBox_Num2;
        private System.Windows.Forms.TextBox textBox_Ans;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_mutiple;
        private System.Windows.Forms.Button button_divide;
    }
}

