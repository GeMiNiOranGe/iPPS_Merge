using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class formKTX : Form
    {
        public formKTX()
        {
            InitializeComponent();
        }

        private void điệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTienDien ftd=new formTienDien();
            ftd.ShowDialog();
           
        }

        private void nướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTienNuoc ftn = new formTienNuoc();
            ftn.ShowDialog();
           
        }

        private void tiềnNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTienNha ftn=new formTienNha();
            ftn.ShowDialog();
        }
    }
}
