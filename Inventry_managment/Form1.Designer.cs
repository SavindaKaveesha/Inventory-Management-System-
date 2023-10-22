namespace Inventry_managment
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
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            clearBtn = new Button();
            loginBtn = new Button();
            pwTxt = new TextBox();
            nameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(pwTxt);
            panel1.Controls.Add(nameTxt);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(26, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 378);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(90, 220);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(108, 295);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(108, 251);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // pwTxt
            // 
            pwTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pwTxt.Location = new Point(39, 183);
            pwTxt.Name = "pwTxt";
            pwTxt.Size = new Size(240, 30);
            pwTxt.TabIndex = 2;
            pwTxt.UseSystemPasswordChar = true;
            pwTxt.TextChanged += pwTxt_TextChanged;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxt.Location = new Point(39, 106);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(240, 30);
            nameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(128, 21);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(334, 28);
            label1.TabIndex = 0;
            label1.Text = "INVENTRY MANAGMENT SYSTEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 468);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox nameTxt;
        private CheckBox checkBox1;
        private Button clearBtn;
        private Button loginBtn;
        private TextBox pwTxt;
    }
}