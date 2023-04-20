namespace collageProject.Gui.Cases
{
    partial class AddCases
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descraptionTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveExit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.genderTextbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الحالة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(90, 24);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(264, 37);
            this.nameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "الجنس";
            // 
            // descraptionTextbox
            // 
            this.descraptionTextbox.Location = new System.Drawing.Point(95, 169);
            this.descraptionTextbox.Multiline = true;
            this.descraptionTextbox.Name = "descraptionTextbox";
            this.descraptionTextbox.Size = new System.Drawing.Size(264, 120);
            this.descraptionTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "تفاصيل";
            // 
            // saveExit
            // 
            this.saveExit.Location = new System.Drawing.Point(3, 356);
            this.saveExit.Name = "saveExit";
            this.saveExit.Size = new System.Drawing.Size(115, 51);
            this.saveExit.TabIndex = 6;
            this.saveExit.Text = "حفظ و غلق";
            this.saveExit.UseVisualStyleBackColor = true;
            this.saveExit.Click += new System.EventHandler(this.saveExit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(311, 356);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(115, 51);
            this.save.TabIndex = 6;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // genderTextbox
            // 
            this.genderTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderTextbox.FormattingEnabled = true;
            this.genderTextbox.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.genderTextbox.Location = new System.Drawing.Point(90, 93);
            this.genderTextbox.Name = "genderTextbox";
            this.genderTextbox.Size = new System.Drawing.Size(269, 38);
            this.genderTextbox.TabIndex = 15;
            // 
            // AddCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 419);
            this.Controls.Add(this.genderTextbox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.saveExit);
            this.Controls.Add(this.descraptionTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "AddCases";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صف";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descraptionTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveExit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox genderTextbox;
    }
}