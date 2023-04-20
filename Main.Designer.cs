namespace collageProject
{
    partial class Main
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.Acceptbutton = new System.Windows.Forms.Button();
            this.Applicantbutton = new System.Windows.Forms.Button();
            this.Casesbutton = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonHome);
            this.flowLayoutPanel1.Controls.Add(this.Acceptbutton);
            this.flowLayoutPanel1.Controls.Add(this.Applicantbutton);
            this.flowLayoutPanel1.Controls.Add(this.Casesbutton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 417);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(968, 94);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::collageProject.Properties.Resources.icons8_home_32px_1;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(830, 11);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(119, 71);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "    الرئيسية";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // Acceptbutton
            // 
            this.Acceptbutton.Image = global::collageProject.Properties.Resources.icons8_apply_32px;
            this.Acceptbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Acceptbutton.Location = new System.Drawing.Point(705, 11);
            this.Acceptbutton.Name = "Acceptbutton";
            this.Acceptbutton.Size = new System.Drawing.Size(119, 71);
            this.Acceptbutton.TabIndex = 1;
            this.Acceptbutton.Text = "     المقبولين ";
            this.Acceptbutton.UseVisualStyleBackColor = true;
            this.Acceptbutton.Click += new System.EventHandler(this.Acceptbutton_Click);
            // 
            // Applicantbutton
            // 
            this.Applicantbutton.Image = global::collageProject.Properties.Resources.icons8_account_32px;
            this.Applicantbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Applicantbutton.Location = new System.Drawing.Point(580, 11);
            this.Applicantbutton.Name = "Applicantbutton";
            this.Applicantbutton.Size = new System.Drawing.Size(119, 71);
            this.Applicantbutton.TabIndex = 2;
            this.Applicantbutton.Text = "     المقدمين";
            this.Applicantbutton.UseVisualStyleBackColor = true;
            this.Applicantbutton.Click += new System.EventHandler(this.Applicantbutton_Click);
            // 
            // Casesbutton
            // 
            this.Casesbutton.Image = global::collageProject.Properties.Resources.icons8_Case_Study_32px;
            this.Casesbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Casesbutton.Location = new System.Drawing.Point(455, 11);
            this.Casesbutton.Name = "Casesbutton";
            this.Casesbutton.Size = new System.Drawing.Size(119, 71);
            this.Casesbutton.TabIndex = 3;
            this.Casesbutton.Text = "الحالات";
            this.Casesbutton.UseVisualStyleBackColor = true;
            this.Casesbutton.Click += new System.EventHandler(this.Casesbutton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(968, 417);
            this.panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 511);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button Acceptbutton;
        private System.Windows.Forms.Button Applicantbutton;
        private System.Windows.Forms.Button Casesbutton;
        public System.Windows.Forms.Panel panelContainer;
    }
}
