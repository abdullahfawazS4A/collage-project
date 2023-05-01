namespace collageProject.Gui.Statistics
{
    partial class poepleCaseUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.poeplecasedataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveexcelbutton1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poeplecasedataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.poeplecasedataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 463);
            this.panel1.TabIndex = 0;
            // 
            // poeplecasedataGridView
            // 
            this.poeplecasedataGridView.AllowUserToAddRows = false;
            this.poeplecasedataGridView.AllowUserToDeleteRows = false;
            this.poeplecasedataGridView.AllowUserToResizeColumns = false;
            this.poeplecasedataGridView.AllowUserToResizeRows = false;
            this.poeplecasedataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poeplecasedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.poeplecasedataGridView.BackgroundColor = System.Drawing.Color.White;
            this.poeplecasedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poeplecasedataGridView.Location = new System.Drawing.Point(0, 48);
            this.poeplecasedataGridView.Name = "poeplecasedataGridView";
            this.poeplecasedataGridView.ReadOnly = true;
            this.poeplecasedataGridView.RowTemplate.Height = 25;
            this.poeplecasedataGridView.Size = new System.Drawing.Size(961, 415);
            this.poeplecasedataGridView.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel1.Controls.Add(this.saveexcelbutton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(961, 47);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // saveexcelbutton1
            // 
            this.saveexcelbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveexcelbutton1.Location = new System.Drawing.Point(3, 3);
            this.saveexcelbutton1.Name = "saveexcelbutton1";
            this.saveexcelbutton1.Size = new System.Drawing.Size(1074, 44);
            this.saveexcelbutton1.TabIndex = 0;
            this.saveexcelbutton1.Text = "سحب";
            this.saveexcelbutton1.UseVisualStyleBackColor = true;
            this.saveexcelbutton1.Click += new System.EventHandler(this.saveexcelbutton1_Click);
            // 
            // poepleCaseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "poepleCaseUserControl";
            this.Size = new System.Drawing.Size(961, 463);
            this.Load += new System.EventHandler(this.poepleCaseUserControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poeplecasedataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView poeplecasedataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button saveexcelbutton1;
    }
}
