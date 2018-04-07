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
    class Class_BANGCONG
    {
        Class_connect data;
        public Class_BANGCONG()
        {
            data = new Class_connect();
        }

        public void loaddulieu(BANGCONG f)
        {
            var sql = data.database().BangCongs.Where(a=>a.IsDelete == 1);
            f.dgv_bangcong.DataSource = sql;
        }

        public void loaddulieucbbbl(BANGCONG f1)
        {
            var sql = data.database().BangLuongs.Where(a => a.IsDelete == 1);
            f1.cbb_matinhluong.DataSource = sql;
            f1.cbb_matinhluong.DisplayMember = "MaTinhLuong";
            f1.cbb_matinhluong.ValueMember = "MaTinhLuong";
        }
        public void them(BANGCONG f)
        {
            BangCong bc = new BangCong();
            bc.MaTinhCong = f.cbb_matinhcong.Text;
            bc.CheDoCong = f.txt_chedocong.Text;
            bc.SoCongNghi = f.txt_socongnghi.Text;
            bc.SoCongTangCa = f.txt_congtangca.Text;
            bc.MaTinhLuong = f.cbb_matinhluong.Text;

            bc.IsDelete = 1;
            data.database().BangCongs.InsertOnSubmit(bc);
            data.database().SubmitChanges();

            DialogResult thongbao = MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
            if (thongbao == DialogResult.OK)
            {
                loaddulieu(f);
            }
        }

        public void xoa(BANGCONG f)
        {
            var sql = data.database().BangCongs.SingleOrDefault(a => a.MaTinhCong == f.cbb_matinhcong.Text);
            sql.IsDelete = 0;
            data.database().SubmitChanges();
            loaddulieu(f);
        }
        public void sua(BANGCONG f)
        {
            var sql = data.database().BangCongs.SingleOrDefault(a => a.MaTinhCong == f.cbb_matinhcong.Text);
            sql.CheDoCong = f.txt_chedocong.Text;
            sql.SoCongNghi = f.txt_socongnghi.Text;
            sql.SoCongTangCa = f.txt_congtangca.Text;
            sql.MaTinhLuong = f.cbb_matinhluong.Text;
          

            data.database().SubmitChanges();
            loaddulieu(f);
        }

        public void tinhcong(BANGCONG f)
        {
            double dlcong = 0;
            dlcong = Convert.ToDouble(f.txt_chedocong.Text) - Convert.ToDouble(f.txt_socongnghi.Text) + Convert.ToDouble(f.txt_congtangca.Text);
            f.lb_tongcong.Text = Convert.ToString(dlcong);

            var sql = data.database().BangCongs.SingleOrDefault(a => a.MaTinhCong == f.cbb_matinhcong.Text);
            sql.DULIEUCONG = Convert.ToDouble(f.lb_tongcong.Text);
            data.database().SubmitChanges();
        }

    }
      

}
