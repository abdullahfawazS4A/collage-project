namespace collageProject.Gui.accapted
{
    partial class AddToacceptedForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptance_datedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.credit_card_issuance_datedateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.credit_card_numbertextBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم بطاقة الائتمان  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ اصدار بطاقة الائتمان :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ القبول : ";
            // 
            // acceptance_datedateTimePicker1
            // 
            this.acceptance_datedateTimePicker1.Location = new System.Drawing.Point(213, 201);
            this.acceptance_datedateTimePicker1.Name = "acceptance_datedateTimePicker1";
            this.acceptance_datedateTimePicker1.Size = new System.Drawing.Size(262, 37);
            this.acceptance_datedateTimePicker1.TabIndex = 3;
            // 
            // credit_card_issuance_datedateTimePicker2
            // 
            this.credit_card_issuance_datedateTimePicker2.Location = new System.Drawing.Point(213, 135);
            this.credit_card_issuance_datedateTimePicker2.Name = "credit_card_issuance_datedateTimePicker2";
            this.credit_card_issuance_datedateTimePicker2.Size = new System.Drawing.Size(262, 37);
            this.credit_card_issuance_datedateTimePicker2.TabIndex = 4;
            // 
            // credit_card_numbertextBox1
            // 
            this.credit_card_numbertextBox1.Location = new System.Drawing.Point(199, 54);
            this.credit_card_numbertextBox1.Name = "credit_card_numbertextBox1";
            this.credit_card_numbertextBox1.Size = new System.Drawing.Size(276, 37);
            this.credit_card_numbertextBox1.TabIndex = 5;
            this.credit_card_numbertextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.credit_card_numbertextBox1_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(379, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 34);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "تاريخ اليوم";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(106, 340);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(336, 51);
            this.Addbutton.TabIndex = 7;
            this.Addbutton.Text = "اضافة";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // AddToacceptedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 447);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.credit_card_numbertextBox1);
            this.Controls.Add(this.credit_card_issuance_datedateTimePicker2);
            this.Controls.Add(this.acceptance_datedateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "AddToacceptedForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "AddToacceptedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker acceptance_datedateTimePicker1;
        private System.Windows.Forms.DateTimePicker credit_card_issuance_datedateTimePicker2;
        private System.Windows.Forms.TextBox credit_card_numbertextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Addbutton;
    }
}