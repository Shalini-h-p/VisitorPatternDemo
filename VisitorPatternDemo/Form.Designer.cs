﻿namespace visitorExample
{
    partial class Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.updateMax = new System.Windows.Forms.TextBox();
            this.updateMin = new System.Windows.Forms.TextBox();
            this.labelSal = new System.Windows.Forms.Label();
            this.empSaltxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warningTxt = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Salary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Read Salary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Update Max";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(104, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "Update Min";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(246, 215);
            this.button6.Name = "button3";
            this.button6.Size = new System.Drawing.Size(112, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "Read Range";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // updateMax
            // 
            this.updateMax.Location = new System.Drawing.Point(246, 263);
            this.updateMax.Name = "updateMax";
            this.updateMax.Size = new System.Drawing.Size(110, 20);
            this.updateMax.TabIndex = 6;
            // 
            // updateMin
            // 
            this.updateMin.Location = new System.Drawing.Point(246, 307);
            this.updateMin.Name = "updateMin";
            this.updateMin.Size = new System.Drawing.Size(110, 20);
            this.updateMin.TabIndex = 7;
            // 
            // labelSal
            // 
            this.labelSal.AutoSize = true;
            this.labelSal.Location = new System.Drawing.Point(109, 123);
            this.labelSal.Name = "labelSal";
            this.labelSal.Size = new System.Drawing.Size(60, 13);
            this.labelSal.TabIndex = 8;
            this.labelSal.Text = "Employee Salary";
            // 
            // empSaltxt
            // 
            this.empSaltxt.Location = new System.Drawing.Point(246, 123);
            this.empSaltxt.Name = "empSaltxt";
            this.empSaltxt.Size = new System.Drawing.Size(110, 20);
            this.empSaltxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salary Container";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Warning text
            // 
            this.warningTxt.AutoSize = true;
            this.warningTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningTxt.Location = new System.Drawing.Point(175, 75);
            this.warningTxt.Name = "warningTxt";
            this.warningTxt.Size = new System.Drawing.Size(100, 25);
            this.warningTxt.TabIndex = 11;
            this.warningTxt.Text = "";
            this.warningTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warningTxt);
            this.Controls.Add(this.empSaltxt);
            this.Controls.Add(this.labelSal);
            this.Controls.Add(this.updateMin);
            this.Controls.Add(this.updateMax);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form";
            this.Text = "Visitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox updateMax;
        private System.Windows.Forms.TextBox updateMin;
        private System.Windows.Forms.Label labelSal;
        private System.Windows.Forms.TextBox empSaltxt;
        private System.Windows.Forms.Label warningTxt;
        private System.Windows.Forms.Label label1;
    }
}

