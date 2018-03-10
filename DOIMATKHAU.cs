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
    public partial class DOIMATKHAU : Form
    {
        Class_connect data;
        kiemtradoimatkhau check;
        public string lgname, pw;
        public DOIMATKHAU(string loginname,string pass)
        {
            InitializeComponent();
            data = new Class_connect();
            lgname = loginname;
            pw = pass;
            check = new kiemtradoimatkhau();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (check.kiemtra(txt_matkhaucu.Text, txt_matkhaumoi.Text, txt_xacnhanmk.Text) == true)
            {
                if(txt_matkhaucu.Text == pw)
                {
                    if (txt_matkhaumoi.Text == txt_xacnhanmk.Text)
                    {
                        var sql = data.database().DangNhaps.SingleOrDefault(a => a.Username == lgname && a.Password == pw);
                        sql.Password = txt_matkhaumoi.Text;
                        data.database().SubmitChanges();
                        MessageBox.Show("Đổi mật khẩu thành công","Thông Báo");
                    }
                }
            }  
        }

        private void bt_nhaplai_Click(object sender, EventArgs e)
        {
            txt_matkhaucu.Text = "";
            txt_matkhaumoi.Text = "";
            txt_xacnhanmk.Text = "";
        }
    }
}
