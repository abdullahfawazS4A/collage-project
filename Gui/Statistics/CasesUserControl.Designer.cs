namespace collageProject.Gui.Statistics
{
    partial class CasesUserControl
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
            this.casedataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.casedataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 463);
            this.panel1.TabIndex = 0;
            // 
            // casedataGridView
            // 
            this.casedataGridView.AllowUserToAddRows = false;
            this.casedataGridView.AllowUserToDeleteRows = false;
            this.casedataGridView.AllowUserToResizeColumns = false;
            this.casedataGridView.AllowUserToResizeRows = false;
            this.casedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.casedataGridView.BackgroundColor = System.Drawing.Color.White;
            this.casedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casedataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casedataGridView.Location = new System.Drawing.Point(0, 0);
            this.casedataGridView.Name = "casedataGridView";
            this.casedataGridView.ReadOnly = true;
            this.casedataGridView.RowTemplate.Height = 25;
            this.casedataGridView.Size = new System.Drawing.Size(961, 463);
            this.casedataGridView.TabIndex = 1;
            this.casedataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.casedataGridView_CellDoubleClick);
            // 
            // CasesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CasesUserControl";
            this.Size = new System.Drawing.Size(961, 463);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView casedataGridView;
    }
}
