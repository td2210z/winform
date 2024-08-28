using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace sv
{
    public partial class Form1 : Form
    {

        public static SqlDataAdapter adapter;
        public static SqlCommand cmd;
        public static SqlConnection conn;
        public static String strCon;
        public static DataTable dt;


        public void Connect()
        {
            strCon = @"Data Source=DESKTOP-LGKSQU5\SQLEXPRESS;Initial Catalog=wf4;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(strCon);
            conn.Open();
        }

        public void DissConnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }


        string sql;

        public void LoadData()
        {
            Connect();
            sql = "select * from sv";
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dvg.DataSource = dt;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void runSql(string sql)
        {
            Connect();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Dispose();
            cmd = null;
        }

        private Boolean check(string sql)
        {
            Connect();
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0) return true;
            else return false;
        }


        private void rs()
        {
            textMa.Text = "";
            textTen.Text = "";
            textNS.Text = "";
            textGT.Text = "";
            textCC.Text = "";
            textTenLop.Text = "";
            textDc.Text = "";
            textSdt.Text = "";
            textGhi.Text = "";
        }
        int vt = -1;
        private void dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            textMa.Text = dvg.Rows[vt].Cells[0].Value.ToString();
            textTen.Text = dvg.Rows[vt].Cells[1].Value.ToString();
            textNS.Text = dvg.Rows[vt].Cells[2].Value.ToString();
            textGT.Text = dvg.Rows[vt].Cells[3].Value.ToString();
            textCC.Text = dvg.Rows[vt].Cells[4].Value.ToString();
            textTenLop.Text = dvg.Rows[vt].Cells[5].Value.ToString();
            textDc.Text = dvg.Rows[vt].Cells[6].Value.ToString();
            textSdt.Text = dvg.Rows[vt].Cells[7].Value.ToString();
            textGhi.Text = dvg.Rows[vt].Cells[8].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("vui long chon ma ", "tt", MessageBoxButtons.OK);
                textMa.Focus();
                return;
            }

            sql = "select * from sv where ma_sv = '" + textMa.Text.Trim() + "' ";
            if (check(sql))
            {
                MessageBox.Show("khoa da bi trung ", "tt", MessageBoxButtons.OK);
                textMa.Focus();
                return;
            }
            sql = "insert into sv values ( '" + textMa.Text.Trim() + "', '" + textTen.Text.Trim() + "' , '" + textNS.Text.Trim() + "' , '" + textGT.Text.Trim() + "' , '" + textCC.Text.Trim() + "' , '" + textTenLop.Text.Trim() + "' , '" + textDc.Text.Trim() + "' , '" + textSdt.Text.Trim() + "' , '" + textGhi.Text.Trim() + "')";

            runSql(sql);
            LoadData();
            MessageBox.Show("dax them thanhc ong", "tt", MessageBoxButtons.OK);
            rs();
              
        }

        private void btnSUa_Click(object sender, EventArgs e)
        {

            if (textMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("vui long chon ma ", "tt", MessageBoxButtons.OK);
                textMa.Focus();
                return;
            }

            sql = "update sv set ho_ten = '" + textTen.Text.Trim() + "' , ns = '" + textNS.Text.Trim() + "' , gt = '" + textGT.Text.Trim() + "' , cccd = '" + textCC.Text.Trim() + "' , ten_lop = '" + textTenLop.Text.Trim() + "' , diachi = '" + textDc.Text.Trim() + "' , sdt = '" + textSdt.Text.Trim() + "' , ghichu = '" + textGhi.Text.Trim() + "' where ma_sv = '" + textMa.Text.Trim() + "'  ";
            DialogResult dlr = MessageBox.Show("bn co muon su khong ", "tt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                runSql(sql);
                LoadData();
                MessageBox.Show("da sua athnh cong ", "tt", MessageBoxButtons.OK);

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("vui long chon ma ", "tt", MessageBoxButtons.OK);
                textMa.Focus();
                return;
            }

            sql = "delete sv where ma_sv = '" + textMa.Text.Trim() + "'  ";
            DialogResult dlr = MessageBox.Show("thng no lm em cuoi", "tt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                runSql(sql);
                LoadData();
                MessageBox.Show("da xoa thanhc ong ", "tt", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("m muon di u", ":tt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Yes)
            {
                DissConnect();
                Application.Exit();
            }
        }
    }
}
