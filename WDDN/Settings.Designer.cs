namespace WDDN
{
    partial class Settings
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
            this.Footer_lbl = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.GCL_ddb = new System.Windows.Forms.ComboBox();
            this.GCL_lbl = new System.Windows.Forms.Label();
            this.DKC_lbl = new System.Windows.Forms.Label();
            this.DKC_ddb = new System.Windows.Forms.ComboBox();
            this.Footer_lbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer_lbl
            // 
            this.Footer_lbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Footer_lbl.Controls.Add(this.Save_btn);
            this.Footer_lbl.Controls.Add(this.Cancel_btn);
            this.Footer_lbl.Controls.Add(this.Close_btn);
            this.Footer_lbl.Location = new System.Drawing.Point(0, 288);
            this.Footer_lbl.Name = "Footer_lbl";
            this.Footer_lbl.Size = new System.Drawing.Size(496, 48);
            this.Footer_lbl.TabIndex = 0;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Save_btn.Location = new System.Drawing.Point(384, 8);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(96, 32);
            this.Save_btn.TabIndex = 5;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cancel_btn.Location = new System.Drawing.Point(280, 8);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(96, 32);
            this.Cancel_btn.TabIndex = 6;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Close_btn.Location = new System.Drawing.Point(176, 8);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(96, 32);
            this.Close_btn.TabIndex = 7;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // GCL_ddb
            // 
            this.GCL_ddb.DropDownWidth = 160;
            this.GCL_ddb.ItemHeight = 16;
            this.GCL_ddb.Items.AddRange(new object[] {
            "CSharp",
            "Powershell"});
            this.GCL_ddb.Location = new System.Drawing.Point(24, 40);
            this.GCL_ddb.Name = "GCL_ddb";
            this.GCL_ddb.Size = new System.Drawing.Size(160, 24);
            this.GCL_ddb.TabIndex = 2;
            this.GCL_ddb.Text = "CSharp";
            // 
            // GCL_lbl
            // 
            this.GCL_lbl.AutoSize = true;
            this.GCL_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GCL_lbl.Location = new System.Drawing.Point(24, 16);
            this.GCL_lbl.Name = "GCL_lbl";
            this.GCL_lbl.Size = new System.Drawing.Size(155, 16);
            this.GCL_lbl.TabIndex = 4;
            this.GCL_lbl.Text = "Generated Code Language";
            // 
            // DKC_lbl
            // 
            this.DKC_lbl.AutoSize = true;
            this.DKC_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DKC_lbl.Location = new System.Drawing.Point(24, 80);
            this.DKC_lbl.Name = "DKC_lbl";
            this.DKC_lbl.Size = new System.Drawing.Size(122, 16);
            this.DKC_lbl.TabIndex = 5;
            this.DKC_lbl.Text = "Deletion Key Combo";
            // 
            // DKC_ddb
            // 
            this.DKC_ddb.DropDownWidth = 160;
            this.DKC_ddb.ItemHeight = 16;
            this.DKC_ddb.Items.AddRange(new object[] {
            "Alt + Delete",
            "Delete"});
            this.DKC_ddb.Location = new System.Drawing.Point(24, 104);
            this.DKC_ddb.Name = "DKC_ddb";
            this.DKC_ddb.Size = new System.Drawing.Size(160, 24);
            this.DKC_ddb.TabIndex = 6;
            this.DKC_ddb.Text = "Alt + Delete";
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(490, 339);
            this.Controls.Add(this.Footer_lbl);
            this.Controls.Add(this.GCL_ddb);
            this.Controls.Add(this.GCL_lbl);
            this.Controls.Add(this.DKC_lbl);
            this.Controls.Add(this.DKC_ddb);
            this.Location = new System.Drawing.Point(416, 416);
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Footer_lbl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Footer_lbl;
        private ComboBox GCL_ddb;
        private Label GCL_lbl;
        private Label DKC_lbl;
        private ComboBox DKC_ddb;
        private Button Save_btn;
        private Button Cancel_btn;
        private Button Close_btn;
    }
}

