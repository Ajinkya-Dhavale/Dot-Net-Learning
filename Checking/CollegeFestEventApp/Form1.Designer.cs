namespace CollegeFestEventApp
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
            people = new TextBox();
            button1 = new Button();
            listbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // people
            // 
            people.AccessibleName = "people";
            people.Location = new Point(136, 68);
            people.Margin = new Padding(2);
            people.Name = "people";
            people.PlaceholderText = "No of people";
            people.Size = new Size(342, 23);
            people.TabIndex = 0;
            people.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(267, 107);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 1;
            button1.Text = "Calculate Bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listbox
            // 
            listbox.AccessibleName = "listBox";
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 15;
            listbox.Location = new Point(136, 151);
            listbox.Margin = new Padding(2);
            listbox.Name = "listbox";
            listbox.Size = new Size(342, 79);
            listbox.TabIndex = 2;
            listbox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 68);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Peoples : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(197, 22);
            label2.Name = "label2";
            label2.Size = new Size(180, 19);
            label2.TabIndex = 4;
            label2.Text = "College Fest Event Handling";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 151);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Bill :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listbox);
            Controls.Add(button1);
            Controls.Add(people);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox people;
        private Button button1;
        private ListBox listbox;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
