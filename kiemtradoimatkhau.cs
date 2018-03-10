using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLNS
{
    class kiemtradoimatkhau
    {
        public bool kiemtra(string mkc, string mkm, string xnmk)
        {
            int ktr = 0;
            string chuoi = "";
            if (mkc == "")
            {
                ktr = 1;
                chuoi += "Bạn chưa nhập mật khẩu cũ! \n";
            }
            if (mkm == "")
            {
                ktr = 1;
                chuoi += "Bạn chưa nhập mật khẩu mới! \n";
            }
            if (xnmk == "")
            {
                ktr = 1;
                chuoi += "Bạn chưa xác nhận mật khẩu mới! \n";
            }
            if (ktr == 1)
            {
                MessageBox.Show(chuoi, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
