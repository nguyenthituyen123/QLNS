using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLNS
{
    public partial class DANHMUC : Form
    {
        public string loginname, password;
        public DANHMUC(string name,string pass)
        {
            InitializeComponent();
            loginname = name;
            password = pass;
        }

        public DANHMUC()
        {
            // TODO: Complete member initialization
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_nhanvien_Click(object sender, EventArgs e)
        {
            NHANVIEN NV = new NHANVIEN();
            NV.Show();
        }

        private void bt_hopdong_Click(object sender, EventArgs e)
        {
            baitaplon2.frmHopDong HD = new baitaplon2.frmHopDong();
            HD.Show();
        }

        private void bt_chucvu_Click(object sender, EventArgs e)
        {
            baitaplon2.frmChucvu CV = new baitaplon2.frmChucvu();
            CV.Show();
        }

        private void bt_bangluong_Click(object sender, EventArgs e)
        {
            BANGLUONG BL = new BANGLUONG();
            BL.Show();
        }

        private void bt_chitiethd_Click(object sender, EventArgs e)
        {
            baitaplon2.frmChucvu CTHĐ = new baitaplon2.frmChucvu();
            CTHĐ.Show();
        }

        private void bt_phongban_Click(object sender, EventArgs e)
        {
            PHONGBAN PB = new PHONGBAN();
            PB.Show();
        }

        private void bt_bangcong_Click(object sender, EventArgs e)
        {
            BANGCONG BC = new BANGCONG();
            BC.Show();
        }

        

        private void bt_dmk_Click(object sender, EventArgs e)
        {
            DOIMATKHAU f = new DOIMATKHAU(loginname,password);
            f.Show();
        }

      

       
    }
}
