namespace collageProject.Gui.User
{
    partial class EditUserForm
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
            this.editbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValiditycheckBox1 = new System.Windows.Forms.CheckBox();
            this.PasswordtextBox3 = new System.Windows.Forms.TextBox();
            this.UserNametextBox2 = new System.Windows.Forms.TextBox();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(214, 334);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(246, 48);
            this.editbutton.TabIndex = 11;
            this.editbutton.Text = "تعديل";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "الرمز السري :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "اسم المستخدم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "الاسم :";
            // 
            // ValiditycheckBox1
            // 
            this.ValiditycheckBox1.AutoSize = true;
            this.ValiditycheckBox1.Location = new System.Drawing.Point(214, 279);
            this.ValiditycheckBox1.Name = "ValiditycheckBox1";
            this.ValiditycheckBox1.Size = new System.Drawing.Size(65, 34);
            this.ValiditycheckBox1.TabIndex = 7;
            this.ValiditycheckBox1.Text = "ادمن";
            this.ValiditycheckBox1.UseVisualStyleBackColor = true;
            // 
            // PasswordtextBox3
            // 
            this.PasswordtextBox3.Location = new System.Drawing.Point(214, 212);
            this.PasswordtextBox3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PasswordtextBox3.Name = "PasswordtextBox3";
            this.PasswordtextBox3.Size = new System.Drawing.Size(246, 37);
            this.PasswordtextBox3.TabIndex = 4;
            // 
            // UserNametextBox2
            // 
            this.UserNametextBox2.Location = new System.Drawing.Point(214, 141);
            this.UserNametextBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.UserNametextBox2.Name = "UserNametextBox2";
            this.UserNametextBox2.Size = new System.Drawing.Size(246, 37);
            this.UserNametextBox2.TabIndex = 5;
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(214, 67);
            this.NametextBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(246, 37);
            this.NametextBox1.TabIndex = 6;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 448);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValiditycheckBox1);
            this.Controls.Add(this.PasswordtextBox3);
            this.Controls.Add(this.UserNametextBox2);
            this.Controls.Add(this.NametextBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "EditUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "EditUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ValiditycheckBox1;
        private System.Windows.Forms.TextBox PasswordtextBox3;
        private System.Windows.Forms.TextBox UserNametextBox2;
        private System.Windows.Forms.TextBox NametextBox1;
    }
}