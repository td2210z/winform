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

namespace wf2
{
    public partial class Form1 : Form
    {


        // 5 bien

        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;
        public static SqlConnection conn;
        public static String strCon;
        public DataTable dt;


       

        // ham connect


        public void Connect()
        {
            strCon = @"Data Source=DESKTOP-LGKSQU5\SQLEXPRESS;Initial Catalog=wf3;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(strCon);
            conn.Open();


        }

        // ham ngat ket noi

        public void DissConnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
            
            

        }


        // ham tai du lieu
        String sql;
        public void LoadData()
        {
            Connect();
            sql = "select * from tb_nganh";
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dtv.DataSource = dt;

        }

        // viet ham truy van sql 
        private void runSql(string sql)
        {
            Connect();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("thong bao", "loi", MessageBoxButtons.OK);
            }
            cmd.Dispose();
            cmd = null;
            

        }


        // kiem tra trung khoa 

        private Boolean checkey(String sql)
        {
            Connect();
            adapter = new SqlDataAdapter(sql , conn);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0) return true;
            else return false;
           
        }
        

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            

        }

        private void textMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void rs()
        {
            textMa.Text = "";
            textTen.Text = "";
            textGhichu.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            // kiem tr
            if(textMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("ch , nhop", "tt", MessageBoxButtons.OK);
                textMa.Focus();
                return;
            }

            if(textTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("cc", "dd", MessageBoxButtons.OK);
                textTen.Focus();
                return;
            }
            if (textGhichu.Text.Trim().Length == 0)
            {
                MessageBox.Show("cc", "dd", MessageBoxButtons.OK);
                textGhichu.Focus();
                return;
            }

            sql = "select * from tb_nganh where ma_nganh = '" + textMa.Text + "'";

            if (checkey(sql))
            {
                MessageBox.Show("trung kho", "tt", MessageBoxButtons.OK);
                textMa.Focus();
                return;
            }
            sql = "insert into tb_nganh values( '" + textMa.Text.Trim() + "' , '" + textTen.Text.Trim() + "' , '" + textGhichu.Text.Trim() + "')";
            runSql(sql);
            LoadData();
            MessageBox.Show("them thnh cong", "tt", MessageBoxButtons.OK);
            rs();



        }

        int vt = -1;
        private void dtv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            textMa.Text = dtv.Rows[vt].Cells[0].Value.ToString();
            textTen.Text = dtv.Rows[vt].Cells[1].Value.ToString();
            textGhichu.Text = dtv.Rows[vt].Cells[2].Value.ToString();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(textMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("chuw nhp j ca", "tt", MessageBoxButtons.OK);
                return;
            }

            sql = "update tb_nganh set ten_nganh = '"+textTen.Text.Trim()+"' , ghi_chu = '"+textGhichu.Text.Trim()+"' where ma_nganh = '"+textMa.Text.Trim()+ "'";

            DialogResult dlr = MessageBox.Show("bn muon su k", "tt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                runSql(sql);
                LoadData();
                MessageBox.Show("sua thnh cong", "tt", MessageBoxButtons.OK);

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (textMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("bn chu", "tt", MessageBoxButtons.OK);
                return;
            }

            sql = "delete tb_nganh where ma_nganh = '" + textMa.Text.Trim() + "' ";
            DialogResult dlr = MessageBox.Show("bn muon xo", "tt",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                runSql(sql);
                LoadData();
                MessageBox.Show("d x t t", "tt", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("toat????", "tt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                DissConnect();
                Application.Exit();
            }
        }
    }
}
