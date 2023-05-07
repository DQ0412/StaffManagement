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
    public partial class Main : Form
    {
        string Tendn = "", Matkhau = "", Quyen = "";
        public Main()
        {
            InitializeComponent();
        }
        public Main(string Tendn, string Matkhau, string Quyen)
        {
            InitializeComponent();
            this.Tendn = Tendn;
            this.Matkhau = Matkhau;
            this.Quyen = Quyen;
        }
        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass();
            changePass.ShowDialog();
            //this.Close();
        }

        private void thôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongtinNV tt = new ThongtinNV();
            tt.ShowDialog();
        }

        private void chứcVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            cv.ShowDialog();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();
            pb.ShowDialog();
        }

        private void bảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoHiem baoHiem = new BaoHiem();
            baoHiem.ShowDialog();
        }

        private void trìnhĐộHọcVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TDHV tDHV = new TDHV();
            tDHV.ShowDialog();
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QDKT qDKT = new QDKT();
            qDKT.ShowDialog();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong();
            hd.ShowDialog();
        }

        private void loạiHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void heejToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            luong.ShowDialog();
        }

        private void btndx_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }
    }
}
