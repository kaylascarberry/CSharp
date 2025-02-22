namespace ECE2310_AdditionCalculator
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
            button1 = new Button();
            txtX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtY = new TextBox();
            txtSum = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtStr = new TextBox();
            button2 = new Button();
            sumStr = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 131);
            button1.Name = "button1";
            button1.Size = new Size(99, 123);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtX
            // 
            txtX.Location = new Point(378, 41);
            txtX.Name = "txtX";
            txtX.Size = new Size(200, 39);
            txtX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 41);
            label1.Name = "label1";
            label1.Size = new Size(297, 32);
            label1.TabIndex = 2;
            label1.Text = "Enter a number to operate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 83);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 3;
            label2.Text = "Enter a second number";
            // 
            // txtY
            // 
            txtY.Location = new Point(378, 86);
            txtY.Name = "txtY";
            txtY.Size = new Size(200, 39);
            txtY.TabIndex = 4;
            // 
            // txtSum
            // 
            txtSum.Location = new Point(405, 277);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(200, 39);
            txtSum.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 277);
            label3.Name = "label3";
            label3.Size = new Size(361, 32);
            label3.TabIndex = 6;
            label3.Text = "The result of the two numbers is";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 403);
            label4.Name = "label4";
            label4.Size = new Size(534, 32);
            label4.TabIndex = 7;
            label4.Text = "Enter a string of numbers to add, seperated by +";
            // 
            // txtStr
            // 
            txtStr.Location = new Point(46, 458);
            txtStr.Name = "txtStr";
            txtStr.Size = new Size(532, 39);
            txtStr.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(54, 503);
            button2.Name = "button2";
            button2.Size = new Size(524, 101);
            button2.TabIndex = 9;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // sumStr
            // 
            sumStr.Location = new Point(387, 645);
            sumStr.Name = "sumStr";
            sumStr.Size = new Size(200, 39);
            sumStr.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 652);
            label5.Name = "label5";
            label5.Size = new Size(129, 32);
            label5.TabIndex = 11;
            label5.Text = "The sum is";
            // 
            // button3
            // 
            button3.Location = new Point(139, 131);
            button3.Name = "button3";
            button3.Size = new Size(110, 123);
            button3.TabIndex = 12;
            button3.Text = "Sub";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(255, 134);
            button4.Name = "button4";
            button4.Size = new Size(101, 120);
            button4.TabIndex = 13;
            button4.Text = "Mult";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(362, 134);
            button5.Name = "button5";
            button5.Size = new Size(103, 122);
            button5.TabIndex = 14;
            button5.Text = "Div";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(471, 134);
            button6.Name = "button6";
            button6.Size = new Size(134, 120);
            button6.TabIndex = 15;
            button6.Text = "Mod";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(661, 277);
            button7.Name = "button7";
            button7.Size = new Size(150, 46);
            button7.TabIndex = 16;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(661, 344);
            button8.Name = "button8";
            button8.Size = new Size(150, 46);
            button8.TabIndex = 17;
            button8.Text = "Close";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 744);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(sumStr);
            Controls.Add(button2);
            Controls.Add(txtStr);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSum);
            Controls.Add(txtY);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtX);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtX;
        private Label label1;
        private Label label2;
        private TextBox txtY;
        private TextBox txtSum;
        private Label label3;
        private Label label4;
        private TextBox txtStr;
        private Button button2;
        private TextBox sumStr;
        private Label label5;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
