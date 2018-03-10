using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLNS
{
    class Class_checker
    {
        public bool kiemtra(string tdn,string mk)
        {
            int ktr = 0;
            string chuoi = "";
            if(tdn == "")
            {
                ktr = 1;
                chuoi += "Bạn chưa nhập tên đăng nhập! \n";
            }
            if(mk=="")
            {
                ktr = 1;
                chuoi += "Bạn chưa nhập mật khẩu! \n";
            }
            if(ktr==1)
            {
                MessageBox.Show(chuoi,"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
