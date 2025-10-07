namespace WinFormsApp1
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
            login = new Button();
            user = new TextBox();
            pass = new TextBox();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(344, 244);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 0;
            login.Text = "login";
            login.UseVisualStyleBackColor = true;
            login.Click += button1_Click;
            // 
            // user
            // 
            user.Location = new Point(264, 79);
            user.Name = "user";
            user.Size = new Size(249, 27);
            user.TabIndex = 1;
            // 
            // pass
            // 
            pass.Location = new Point(264, 166);
            pass.Name = "pass";
            pass.Size = new Size(249, 27);
            pass.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(login);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private TextBox user;
        private TextBox pass;
    }
}
