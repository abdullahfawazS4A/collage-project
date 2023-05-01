namespace collageProject.Gui.Cases
{
    partial class editeCases
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
            this.editebutton = new System.Windows.Forms.Button();
            this.descraptionTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genderTextbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // editebutton
            // 
            this.editebutton.Location = new System.Drawing.Point(170, 353);
            this.editebutton.Name = "editebutton";
            this.editebutton.Size = new System.Drawing.Size(115, 51);
            this.editebutton.TabIndex = 13;
            this.editebutton.Text = "تعديل وغلق";
            this.editebutton.UseVisualStyleBackColor = true;
            this.editebutton.Click += new System.EventHandler(this.editebutton_Click);
            // 
            // descraptionTextbox
            // 
            this.descraptionTextbox.Location = new System.Drawing.Point(107, 186);
            this.descraptionTextbox.Multiline = true;
            this.descraptionTextbox.Name = "descraptionTextbox";
            this.descraptionTextbox.Size = new System.Drawing.Size(264, 120);
            this.descraptionTextbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "تفاصيل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "الجنس";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(102, 41);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(264, 37);
            this.nameTextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم الحالة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // genderTextbox
            // 
            this.genderTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderTextbox.FormattingEnabled = true;
            this.genderTextbox.Items.AddRange(new object[] {
            "ذكر ",
            "انثى"});
            this.genderTextbox.Location = new System.Drawing.Point(107, 110);
            this.genderTextbox.Name = "genderTextbox";
            this.genderTextbox.Size = new System.Drawing.Size(259, 38);
            this.genderTextbox.TabIndex = 14;
            // 
            // editeCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 465);
            this.Controls.Add(this.genderTextbox);
            this.Controls.Add(this.editebutton);
            this.Controls.Add(this.descraptionTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "editeCases";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تعديل صف";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editebutton;
        private System.Windows.Forms.TextBox descraptionTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genderTextbox;
    }
}