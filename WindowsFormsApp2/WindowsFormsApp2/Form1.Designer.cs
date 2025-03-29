namespace WindowsFormsApp2
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
            this.todo = new System.Windows.Forms.TextBox();
            this.todobtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.srno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // todo
            // 
            this.todo.AccessibleName = "todo";
            this.todo.Location = new System.Drawing.Point(290, 55);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(200, 20);
            this.todo.TabIndex = 0;
            this.todo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // todobtn
            // 
            this.todobtn.Location = new System.Drawing.Point(290, 94);
            this.todobtn.Name = "todobtn";
            this.todobtn.Size = new System.Drawing.Size(75, 23);
            this.todobtn.TabIndex = 1;
            this.todobtn.Text = "Save Todo";
            this.todobtn.UseVisualStyleBackColor = true;
            this.todobtn.Click += new System.EventHandler(this.todobtn_Click);
            // 
            // listView1
            // 
            this.listView1.AccessibleName = "todolist";
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.srno,
            this.task,
            this.status});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(189, 158);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 218);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What to do ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // srno
            // 
            this.srno.Text = "SR No";
            // 
            // task
            // 
            this.task.Text = "Your Task";
            // 
            // status
            // 
            this.status.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.todobtn);
            this.Controls.Add(this.todo);
            this.Name = "Form1";
            this.Text = "Ajinkya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox todo;
        private System.Windows.Forms.Button todobtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader srno;
        private System.Windows.Forms.ColumnHeader task;
        private System.Windows.Forms.ColumnHeader status;
    }
}

