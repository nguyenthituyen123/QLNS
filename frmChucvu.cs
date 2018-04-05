using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace baitaplon2
{
    public partial class frmChucvu : Form
    {
        public frmChucvu()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void frmChucvu_Load(object sender, EventArgs e)
        {
            string cnString = ConfigurationManager.ConnectionStrings["QLNS"].ConnectionString.ToString();
            con = new SqlConnection(cnString);
            con.Open();
            Hienthi();
        }

        private void frmChucvu_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void Hienthi()
        {
            string sql = "SELECT * FROM ChucVu";
            //tao doi tuong comman de doc no
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvchucvu.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chua chay duoc
            string sql = "INSERT INTO ChucVu VALUES(@MaCV, @MaNV, @TenCV, @PhuCapCV, @QuyenHan, @NhiemVu, @GhiChu, @IsDelete)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaCV", txtmacv.Text);
            //cmd.Parameters.Add("MaNV", SqlDbType.NVarChar, 4, "MaNV");
            cmd.Parameters.AddWithValue("MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("TenCV", txttencv.Text);
            cmd.Parameters.AddWithValue("PhuCapCV", txtphucapcv.Text);
            cmd.Parameters.AddWithValue("QuyenHan", txtquyenhan.Text);
            cmd.Parameters.AddWithValue("NhiemVu", txtnhiemvu.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);
            cmd.ExecuteNonQuery();
            
            Hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE ChucVu SET TenCV = @TenCV, PhuCapCV = @PhuCapCV, QuyenHan = @QuyenHan, NhiemVu = @NhiemVu, GhiChu = @GhiChu, IsDelete = @IsDelete WHERE MaCV = @MaCV and MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaCV", txtmacv.Text);
            cmd.Parameters.AddWithValue("MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("TenCV", txttencv.Text);
            cmd.Parameters.AddWithValue("PhuCapCV", txtphucapcv.Text);
            cmd.Parameters.AddWithValue("QuyenHan", txtquyenhan.Text);
            cmd.Parameters.AddWithValue("NhiemVu", txtnhiemvu.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);
            cmd.ExecuteNonQuery();

            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM ChucVu WHERE MaCV = @MaCV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaCV", txtmacv.Text);
            cmd.Parameters.AddWithValue("MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("TenCV", txttencv.Text);
            cmd.Parameters.AddWithValue("PhuCapCV", txtphucapcv.Text);
            cmd.Parameters.AddWithValue("QuyenHan", txtquyenhan.Text);
            cmd.Parameters.AddWithValue("NhiemVu", txtnhiemvu.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);
            cmd.ExecuteNonQuery();

            Hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ChucVu WHERE MaCV = @MaCV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaCV", txtmacv.Text);
            cmd.Parameters.AddWithValue("MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("TenCV", txttencv.Text);
            cmd.Parameters.AddWithValue("PhuCapCV", txtphucapcv.Text);
            cmd.Parameters.AddWithValue("QuyenHan", txtquyenhan.Text);
            cmd.Parameters.AddWithValue("NhiemVu", txtnhiemvu.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvchucvu.DataSource = dt;

        }
    }
}
