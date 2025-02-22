namespace ECE2310_DistanceConverter_WindowsForm
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
            label1 = new Label();
            txtMi = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txtKm = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 66);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter the distance in miles: ";
            // 
            // txtMi
            // 
            txtMi.Location = new Point(112, 115);
            txtMi.Name = "txtMi";
            txtMi.Size = new Size(200, 39);
            txtMi.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.GreenYellow;
            button1.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            button1.ForeColor = Color.GreenYellow;
            button1.Location = new Point(131, 187);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 264);
            label2.Name = "label2";
            label2.Size = new Size(244, 32);
            label2.TabIndex = 3;
            label2.Text = "The distance in km is:";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(112, 342);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(200, 39);
            txtKm.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(txtKm);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtMi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMi;
        private Button button1;
        private Label label2;
        private TextBox txtKm;
    }
}
