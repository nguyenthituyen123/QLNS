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
    public partial class frmChitietHĐ : Form
    {
        public frmChitietHĐ()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void frmChitietHĐ_Load(object sender, EventArgs e)
        {
            string cnString = ConfigurationManager.ConnectionStrings["QLNS"].ConnectionString.ToString();
            con = new SqlConnection(cnString);
            con.Open();
            Hienthi();
        }

        private void frmChitietHĐ_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void Hienthi()
        {
            string sql = "SELECT * FROM ChiTietHĐ";
            //tao doi tuong comman de doc no
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvcthd.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO ChiTietHĐ VALUES(@MaNV, @MaHĐ, @NgayKyHĐ, @NgayKetThucHĐ, @GhiChu, @IsDelete)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("MaHĐ", txtmahd.Text);
            cmd.Parameters.AddWithValue("NgayKyHĐ", dtngaykt.Text);
            cmd.Parameters.AddWithValue("NgayKetThucHĐ", dtngaykt.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE ChiTietHĐ SET NgayKyHĐ = @NgayKyHĐ, NgayKetThucHĐ = @NgayKetThucHĐ, GhiChu =@GhiChu WHERE MaHĐ = @MaHĐ, NgayKetThucHĐ = @NgayKetThucHĐ and MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("MaHĐ", txtmahd.Text);
            cmd.Parameters.AddWithValue("NgayKyHĐ", dtngaykt.Text);
            //cmd.Parameters.AddWithValue("NgayKetThucHĐ", dtngaykt.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM ChiTietHĐ WHERE MaHĐ = @MaHĐ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("MaHĐ", txtmahd.Text);
            cmd.Parameters.AddWithValue("NgayKyHĐ", dtngaykt.Text);
            //cmd.Parameters.AddWithValue("NgayKetThucHĐ", dtngaykt.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM ChiTietHĐ WHERE MaHĐ = @MaHĐ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txtmanv.Text);
            cmd.Parameters.AddWithValue("MaHĐ", txtmahd.Text);
            cmd.Parameters.AddWithValue("NgayKyHĐ", dtngaykt.Text);
            //cmd.Parameters.AddWithValue("NgayKetThucHĐ", dtngaykt.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtghichu.Text);
            cmd.Parameters.AddWithValue("IsDelete", txtIs.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvcthd.DataSource = dt;

        }
    }
}
