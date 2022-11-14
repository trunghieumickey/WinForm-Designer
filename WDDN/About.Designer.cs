namespace WDDN
{
    partial class About : Form
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
            this.About_lbl = new System.Windows.Forms.Label();
            this.ver_lbl = new System.Windows.Forms.Label();
            this.div_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // About_lbl
            //
            this.About_lbl.AutoSize =  true;
            this.About_lbl.Text =  "About";
            this.About_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.About_lbl.Location = new System.Drawing.Point(16,8);
            this.About_lbl.Name =  "About_lbl";
            this.About_lbl.Size = new System.Drawing.Size(52,21);
            //
            // ver_lbl
            //
            this.ver_lbl.AutoSize =  true;
            this.ver_lbl.Text =  "WinForms Designer\n.NET Version: 7.0.0";
            this.ver_lbl.Location = new System.Drawing.Point(16,40);
            this.ver_lbl.Name =  "ver_lbl";
            this.ver_lbl.Size = new System.Drawing.Size(217,15);
            this.ver_lbl.TabIndex = 1;
            //
            // close_btn
            //
            this.close_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.close_btn.Text =  "OK";
            this.close_btn.Location = new System.Drawing.Point(16,126);
            this.close_btn.Name =  "close_btn";
            this.close_btn.Size = new System.Drawing.Size(150,32);
            this.close_btn.TabIndex = 3;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            //
            // form
            //
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(14,13);
            this.Size = new System.Drawing.Size(194,204);
            this.Name =  "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.Load += new System.EventHandler(this.About_Load);
            this.Controls.Add(this.About_lbl);
            this.Controls.Add(this.ver_lbl);
            this.Controls.Add(this.div_lbl);
            this.Controls.Add(this.close_btn);
            this.ResumeLayout(false);
        }

        #endregion

        private Label About_lbl;
        private Label ver_lbl;
        private Label div_lbl;
        private Button close_btn;
    }
}

//private void this.close_btn_Click(System.Object? sender, System.EventArgs e)
//{
//
//}

//private void this.About_Load(System.Object? sender, System.EventArgs e)
//{
//
//}

//private void this.About_Load(System.Object? sender, System.EventArgs e)
//{
//
//}

