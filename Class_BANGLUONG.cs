using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemQLNS.LQTOSQL;
using System.Windows.Forms;
using System.IO;

namespace PhanMemQLNS
{
    class Class_BANGLUONG
    {
        Class_connect data;
        public Class_BANGLUONG()
        {
            data = new Class_connect();
        }

        public void loaddulieu(BANGLUONG f)
        {
            var sql = data.database().BangLuongs.Where(a=>a.IsDelete==true);
            f.dgv_bangluong.DataSource = sql;
        }

        public void them(BANGLUONG f)
        {
            BangLuong bl = new BangLuong();
            bl.MaTinhLuong = f.cbb_matinhluong.Text;
            bl.HeSoLuong = f.txt_hesoluong.Text;
            bl.LuongCoBan_Ngay = f.txt_luongcoban.Text;
            bl.Thuong = f.txt_thuong.Text;
            bl.TamUng = f.txt_tamung.Text;
            bl.NgayTao = Convert.ToDateTime(f.txt_ngaytao.Text);
   

            data.database().BangLuongs.InsertOnSubmit(bl);
            data.database().SubmitChanges();

            DialogResult thongbao = MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
            if(thongbao == DialogResult.OK)
            {
                loaddulieu(f);
            }
        }


        public void xoa(BANGLUONG f)
        {
            var sql = data.database().BangLuongs.SingleOrDefault(a => a.MaTinhLuong == f.cbb_matinhluong.Text);
            sql.IsDelete = false;
            data.database().SubmitChanges();
            loaddulieu(f);
        }
        public void sua(BANGLUONG f)
        {
            var sql = data.database().BangLuongs.SingleOrDefault(a => a.MaTinhLuong == f.cbb_matinhluong.Text);
            sql.HeSoLuong = f.txt_hesoluong.Text;
            sql.LuongCoBan_Ngay = f.txt_luongcoban.Text;
            sql.Thuong = f.txt_thuong.Text;
            sql.TamUng = f.txt_tamung.Text;
            sql.NgayTao = Convert.ToDateTime(f.txt_ngaytao.Text);
     

            data.database().SubmitChanges();
            loaddulieu(f);
        }

    }
}
