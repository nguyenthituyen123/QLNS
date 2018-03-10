using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhanMemQLNS
{
    class Class_dangnhap
    {
        Class_connect dulieu;
        public Class_dangnhap()
        {
            dulieu = new Class_connect();
        }

        public void dangnhap(DANGNHAP f)
        {
            var sql = dulieu.database().DangNhaps.SingleOrDefault(a => a.Username == f.txt_loginname.Text && a.Password == f.txt_pass.Text);
            if(sql!=null)
            {
                DANHMUC f1 = new DANHMUC(f.txt_loginname.Text,f.txt_pass.Text);
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
