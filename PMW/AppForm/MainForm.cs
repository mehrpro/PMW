using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PMW.AppForm
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void NewMachineryIDButton_Click(object sender, EventArgs e)
        {
            var frm = new NewMachinery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ListMachineryButton_Click(object sender, EventArgs e)
        {
            var frm = new MachineryForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
