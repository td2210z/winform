using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace bmot
{




    public partial class Form1 : Form
    {



        public static SqlConnection conn; // lưu chuỗi kết nối tới cơ sở dữ liệu 
        public static SqlCommand cmd; // thực hiện câu lệnh  sql 
        public static String strCon; // chuối kết nối tới csdl
        public static SqlDataAdapter adapter;// cầu kết nối giữa csdl và datatable 
        public static DataTable dt; // bảng dữ liệu 


        // hm ket noi

        public void Connect()
        {
            strCon = @"Data Source=DESKTOP-LGKSQU5\SQLEXPRESS;Initial Catalog=winform2;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(strCon);
            conn.Open();
        }

        public void DissConnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        String sql;

        private void LoadData()
        {
            Connect(); // mo ket noi
            sql = "select * from nganh";
            adapter = new SqlDataAdapter(sql, conn); // chuyen du lieu tu sql sang sang Adapter
            dt = new DataTable(); //nơi chứa dữ liệu 
            adapter.Fill(dt); // đổ dữ liêu vào table 
            data_frv.DataSource = dt;

        }


        private void runSql(string sql)
        {
            Connect(); // Mở kết nối tới cơ sở dữ liệu
            cmd = new SqlCommand(sql, conn); // Tạo đối tượng SqlCommand với câu lệnh SQL và kết nối
            try
            {
                cmd.ExecuteNonQuery(); // Thực thi lệnh SQL (dùng cho INSERT, UPDATE, DELETE)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Hiển thị thông báo nếu có lỗi xảy ra
            }
            cmd.Dispose(); // Giải phóng tài nguyên của SqlCommand
            cmd = null; // Đặt cmd về null để tránh lỗi ngoài ý muốn
        }









        public Form1()
        {
            InitializeComponent();
        }

       


        // kiểm tra trùng khóa
        private Boolean checkKey(String sql)
        {
            Connect();
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0) return true;
            else return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // kiểm tra xem nhập mã chưa
            if (text_nganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("chưa nhập mã", "thông báo", MessageBoxButtons.OK);
                text_nganh.Focus();
                return;
            }

            if (text_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("chưa nhập tên", "thông báo", MessageBoxButtons.OK);
                text_ten.Focus();
                return;
            }
            if (text_ghichu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chuwaa nhaapj ghi chú", "thông báo", MessageBoxButtons.OK);
                text_ghichu.Focus();
                return;
            }


            sql = "select * from nganh where Ma_nganh = '" + text_nganh.Text + "'";
            if (checkKey(sql))
            {
                MessageBox.Show("mã đã tồn tại", "thông báo", MessageBoxButtons.OK);
                text_nganh.Focus();
                return;
            }

            sql = "insert into nganh values ('" + text_nganh.Text.Trim() + "',N'" + text_ten.Text.Trim() + "' , N'" + text_ghichu.Text.Trim() + "')";
            runSql(sql); // chạy
            LoadData(); // load lên dtgr
            MessageBox.Show("thêm thành công", "thông báo", MessageBoxButtons.OK);
            reSet(); // 

        }

        private void reSet()
        {
            text_ten.Text = "";
            text_nganh.Text = "";
            text_ghichu.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        int vt = -1;

        

        private void data_frv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            text_nganh.Text = data_frv.Rows[vt].Cells[0].Value.ToString();
            text_ten.Text = data_frv.Rows[vt].Cells[1].Value.ToString();
            text_ghichu.Text = data_frv.Rows[vt].Cells[2].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (text_nganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("chưa nhập gì cả", "thông báo", MessageBoxButtons.OK);
                return;
            }

            sql = "update nganh set ten_nganh = N'" + text_ten.Text.Trim() + "' , ghi_chu =  N'" + text_ghichu.Text.Trim() + "' where Ma_nganh = '" + text_nganh.Text.Trim() + "'";
            DialogResult dlr = MessageBox.Show("bạn muốn sửa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                {
                    runSql(sql);
                    LoadData();
                    MessageBox.Show("sửa thành công", "thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if(text_nganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("vui lòng nhập mã", "thông báo", MessageBoxButtons.OK);
                return;
            }

            sql = "delete nganh where Ma_nganh = '" + text_nganh.Text.Trim() + "'  ";
            DialogResult dlr = MessageBox.Show("bạn muốn xóa không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                runSql(sql);
                LoadData();
                MessageBox.Show("đã xóa thành công ", "thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("bạn có muốn thoát không " , "thông báo" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                DissConnect();
                Application.Exit();
            }
        }
    }
}
