namespace Inventry_managment
{
    partial class ManageUsers
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
            panel1 = new Panel();
            label1 = new Label();
            nameTxt = new TextBox();
            fnameTxt = new TextBox();
            pwTxt = new TextBox();
            tpTxt = new TextBox();
            button1 = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            homeBtn = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 102);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(380, 34);
            label1.Name = "label1";
            label1.Size = new Size(201, 38);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(65, 152);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(308, 27);
            nameTxt.TabIndex = 1;
            // 
            // fnameTxt
            // 
            fnameTxt.Location = new Point(65, 203);
            fnameTxt.Name = "fnameTxt";
            fnameTxt.Size = new Size(308, 27);
            fnameTxt.TabIndex = 2;
            // 
            // pwTxt
            // 
            pwTxt.Location = new Point(65, 261);
            pwTxt.Name = "pwTxt";
            pwTxt.Size = new Size(308, 27);
            pwTxt.TabIndex = 3;
            // 
            // tpTxt
            // 
            tpTxt.Location = new Point(65, 319);
            tpTxt.Name = "tpTxt";
            tpTxt.Size = new Size(308, 27);
            tpTxt.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(65, 377);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(170, 377);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(279, 377);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 7;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // homeBtn
            // 
            homeBtn.Location = new Point(170, 412);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(94, 29);
            homeBtn.TabIndex = 8;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(450, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(508, 324);
            dataGridView1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 133);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 11;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 184);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 12;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 239);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 296);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 14;
            label5.Text = "Telephone";
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 514);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(homeBtn);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(button1);
            Controls.Add(tpTxt);
            Controls.Add(pwTxt);
            Controls.Add(fnameTxt);
            Controls.Add(nameTxt);
            Controls.Add(panel1);
            Name = "ManageUsers";
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox nameTxt;
        private TextBox fnameTxt;
        private TextBox pwTxt;
        private TextBox tpTxt;
        private Button button1;
        private Button deleteBtn;
        private Button editBtn;
        private Button homeBtn;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}