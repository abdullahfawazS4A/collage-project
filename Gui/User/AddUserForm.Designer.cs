namespace collageProject.Gui.User
{
    partial class AddUserForm
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
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.UserNametextBox2 = new System.Windows.Forms.TextBox();
            this.PasswordtextBox3 = new System.Windows.Forms.TextBox();
            this.ValiditycheckBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(195, 95);
            this.NametextBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(246, 37);
            this.NametextBox1.TabIndex = 0;
            // 
            // UserNametextBox2
            // 
            this.UserNametextBox2.Location = new System.Drawing.Point(195, 169);
            this.UserNametextBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.UserNametextBox2.Name = "UserNametextBox2";
            this.UserNametextBox2.Size = new System.Drawing.Size(246, 37);
            this.UserNametextBox2.TabIndex = 0;
            // 
            // PasswordtextBox3
            // 
            this.PasswordtextBox3.Location = new System.Drawing.Point(195, 240);
            this.PasswordtextBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PasswordtextBox3.Name = "PasswordtextBox3";
            this.PasswordtextBox3.Size = new System.Drawing.Size(246, 37);
            this.PasswordtextBox3.TabIndex = 0;
            // 
            // ValiditycheckBox1
            // 
            this.ValiditycheckBox1.AutoSize = true;
            this.ValiditycheckBox1.Location = new System.Drawing.Point(195, 307);
            this.ValiditycheckBox1.Name = "ValiditycheckBox1";
            this.ValiditycheckBox1.Size = new System.Drawing.Size(65, 34);
            this.ValiditycheckBox1.TabIndex = 1;
            this.ValiditycheckBox1.Text = "ادمن";
            this.ValiditycheckBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "الاسم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم المستخدم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "الرمز السري :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValiditycheckBox1);
            this.Controls.Add(this.PasswordtextBox3);
            this.Controls.Add(this.UserNametextBox2);
            this.Controls.Add(this.NametextBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "AddUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.TextBox UserNametextBox2;
        private System.Windows.Forms.TextBox PasswordtextBox3;
        private System.Windows.Forms.CheckBox ValiditycheckBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}