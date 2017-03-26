using System;

namespace WindowsFormsApplication1
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
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dec = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(9, 272);
            this.one.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 49);
            this.one.TabIndex = 6;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(9, 325);
            this.zero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(128, 48);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(75, 272);
            this.two.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(62, 49);
            this.two.TabIndex = 7;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(75, 213);
            this.five.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(62, 55);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(9, 213);
            this.four.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 55);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(9, 159);
            this.seven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(60, 47);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(75, 159);
            this.eight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(62, 48);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(143, 159);
            this.nine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(61, 48);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(143, 213);
            this.six.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(61, 55);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(143, 272);
            this.three.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(61, 49);
            this.three.TabIndex = 8;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(276, 272);
            this.equals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(54, 102);
            this.equals.TabIndex = 18;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(210, 325);
            this.plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 47);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operation_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(210, 272);
            this.minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 49);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operation_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(210, 213);
            this.times.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(60, 55);
            this.times.TabIndex = 15;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.operation_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(210, 159);
            this.div.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 48);
            this.div.TabIndex = 14;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operation_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(144, 102);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 53);
            this.clear.TabIndex = 13;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 23);
            this.label1.TabIndex = 20;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(144, 325);
            this.dec.Margin = new System.Windows.Forms.Padding(4);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(60, 47);
            this.dec.TabIndex = 21;
            this.dec.Text = ",";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.Location = new System.Drawing.Point(75, 102);
            this.clearEntry.Margin = new System.Windows.Forms.Padding(4);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(62, 53);
            this.clearEntry.TabIndex = 22;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = true;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.Enabled = false;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.Location = new System.Drawing.Point(11, 11);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(319, 82);
            this.result.TabIndex = 23;
            this.result.Text = " ";
            this.result.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 55);
            this.button2.TabIndex = 25;
            this.button2.Text = "√";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 48);
            this.button3.TabIndex = 26;
            this.button3.Text = "x²";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 53);
            this.button4.TabIndex = 27;
            this.button4.Text = "+/-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(276, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 51);
            this.button5.TabIndex = 28;
            this.button5.Text = "1/x";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 380);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.times);
            this.Controls.Add(this.div);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.numberButton_Click);
            this.ResumeLayout(false);

        }









        #endregion
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

