using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class PhanQuyen : Form
    {
        string Tendn = "", Matkhau = "", Quyen = "";
        public PhanQuyen()
        {
            InitializeComponent();
        }
        public PhanQuyen(string Tendn, string Matkhau, string Quyen)
        {
            InitializeComponent();
            this.Tendn = Tendn;
            this.Matkhau = Matkhau;
            this.Quyen = Quyen;
        }
        private void btnns_Click(object sender, EventArgs e)
        {
            if (Tendn == "Admin")
            {
                MessageBox.Show("oke");
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("noke");
            }
        }
    }
}
