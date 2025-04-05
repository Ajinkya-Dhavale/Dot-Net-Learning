namespace Assign4_WindowForm_Tshirt
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
            input = new TextBox();
            s = new RadioButton();
            m = new RadioButton();
            l = new RadioButton();
            code = new TextBox();
            p = new Label();
            cal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(176, 47);
            input.Margin = new Padding(2, 2, 2, 2);
            input.Name = "input";
            input.PlaceholderText = "Enter the no of Tshirt";
            input.Size = new Size(264, 23);
            input.TabIndex = 0;
            input.TextChanged += input_TextChanged;
            // 
            // s
            // 
            s.AutoSize = true;
            s.Location = new Point(176, 89);
            s.Margin = new Padding(2, 2, 2, 2);
            s.Name = "s";
            s.Size = new Size(54, 19);
            s.TabIndex = 1;
            s.TabStop = true;
            s.Text = "Small";
            s.UseVisualStyleBackColor = true;
            // 
            // m
            // 
            m.AutoSize = true;
            m.Location = new Point(277, 89);
            m.Margin = new Padding(2, 2, 2, 2);
            m.Name = "m";
            m.Size = new Size(70, 19);
            m.TabIndex = 2;
            m.TabStop = true;
            m.Text = "Medium";
            m.UseVisualStyleBackColor = true;
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(386, 89);
            l.Margin = new Padding(2, 2, 2, 2);
            l.Name = "l";
            l.Size = new Size(54, 19);
            l.TabIndex = 3;
            l.TabStop = true;
            l.Text = "Large";
            l.UseVisualStyleBackColor = true;
            l.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // code
            // 
            code.Location = new Point(176, 125);
            code.Margin = new Padding(2, 2, 2, 2);
            code.Name = "code";
            code.PlaceholderText = "Refer code";
            code.Size = new Size(264, 23);
            code.TabIndex = 4;
            code.TextChanged += code_TextChanged;
            // 
            // p
            // 
            p.AutoSize = true;
            p.Location = new Point(176, 204);
            p.Margin = new Padding(2, 0, 2, 0);
            p.Name = "p";
            p.Size = new Size(0, 15);
            p.TabIndex = 5;
            // 
            // cal
            // 
            cal.Location = new Point(253, 167);
            cal.Margin = new Padding(2, 2, 2, 2);
            cal.Name = "cal";
            cal.Size = new Size(78, 20);
            cal.TabIndex = 6;
            cal.Text = "calculate";
            cal.UseVisualStyleBackColor = true;
            cal.Click += cal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 50);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 89);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 8;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 129);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 9;
            label3.Text = "Refer Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 204);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(207, 12);
            label5.Name = "label5";
            label5.Size = new Size(140, 19);
            label5.TabIndex = 11;
            label5.Text = "Tshirt Price Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cal);
            Controls.Add(p);
            Controls.Add(code);
            Controls.Add(l);
            Controls.Add(m);
            Controls.Add(s);
            Controls.Add(input);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private RadioButton s;
        private RadioButton m;
        private RadioButton l;
        private TextBox code;
        private Label p;
        private Button cal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
