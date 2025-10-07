namespace WinFormsApp2
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
            cmbStudent = new ComboBox();
            btnShow = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbDempartment = new ComboBox();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(620, 105);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(151, 28);
            cmbStudent.TabIndex = 0;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(317, 258);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(286, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 27);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(286, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(286, 142);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(214, 27);
            txtAge.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 41);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 5;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 92);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 149);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "Age";
            // 
            // cmbDempartment
            // 
            cmbDempartment.FormattingEnabled = true;
            cmbDempartment.Items.AddRange(new object[] { "SD", ".NET", "OS" });
            cmbDempartment.Location = new Point(620, 55);
            cmbDempartment.Name = "cmbDempartment";
            cmbDempartment.Size = new Size(151, 28);
            cmbDempartment.TabIndex = 8;
            cmbDempartment.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDempartment);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnShow);
            Controls.Add(cmbStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudent;
        private Button btnShow;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbDempartment;
    }
}
