using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDDN
{
    public partial class Settings : Form
    {

        MainForm parentForm;

        public Settings(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            parentForm.GCL = GCL_ddb.Text;
            parentForm.DeletionKey = DKC_ddb.Text;
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            GCL_ddb.Text = parentForm.GCL;
            DKC_ddb.Text = parentForm.DeletionKey;
        }
    }
}
