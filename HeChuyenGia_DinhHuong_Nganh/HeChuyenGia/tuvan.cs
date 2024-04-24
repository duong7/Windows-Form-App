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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeChuyenGia_Nhom2
{
    public partial class tuvan : Form
    {
        private List<string> listMaNganh = new List<string>();
        private List<string> listTenNganh = new List<string>();
        private ketnoi kn = new ketnoi();
        private bool run = false;
        public tuvan()
        {
            InitializeComponent();
        }

        private void tuvan_Load(object sender, EventArgs e)
        {
            //load list nganh
            string qr = "select masukien,motasukien from tblsukien where loaisukien='nganhnghe'";
            DataTable tbTruong = kn.getTable(qr);
            for (int i = 0; i < tbTruong.Rows.Count; i++)
            {
                listMaNganh.Add(tbTruong.Rows[i][0].ToString());
                listTenNganh.Add(tbTruong.Rows[i][1].ToString());
            }

            //load len hoc luc
            qr = "select masukien,motasukien from tblsukien where loaisukien='hocluc'";
            DataTable tbKN = kn.getTable(qr);
            cbhocluc.DataSource = tbKN;
            cbhocluc.DisplayMember = "motasukien";
            cbhocluc.ValueMember = "masukien";

            //load len khoi thi
            qr = "select masukien,motasukien from tblsukien where loaisukien='khoithi'";
            DataTable tbKhoi = kn.getTable(qr);
            cbkhoi.DataSource = tbKhoi;
            cbkhoi.DisplayMember = "motasukien";
            cbkhoi.ValueMember = "masukien";


            //load len so thich
            qr = "select masukien,motasukien from tblsukien where loaisukien='sothich'";
            DataTable tbST = kn.getTable(qr);
            cbsothich.DataSource = tbST;
            cbsothich.DisplayMember = "motasukien";
            cbsothich.ValueMember = "masukien";

        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            suydientien sd = new suydientien();
            sd.DocLuatTuFfile();
            run = true;
            //
            cbhocluc.Enabled = false;
            cbkhoi.Enabled = false;

            cbsothich.Enabled = false;
            btnTuVan.Enabled = false;

            List<string> gt = new List<string>();
            ricKQ.Text = "";
            if (cbhocluc.SelectedValue.ToString() != "")
            {
                gt.Add(cbhocluc.SelectedValue.ToString());
            }
            if (cbkhoi.SelectedValue.ToString() != "")
            {
                gt.Add(cbkhoi.SelectedValue.ToString());
            }
            if (cbsothich.SelectedValue.ToString() != "")
            {
                gt.Add(cbsothich.SelectedValue.ToString());
            }
            int d = 0;
            progressBar.Maximum = listMaNganh.Count - 1;
            progressBar.Minimum = 0;
            if (gt.Count > 0)
            {
                int dem = 0;
                foreach (string s in listMaNganh)
                {
                    if (!run)
                    {
                        btnReset.Enabled = false;
                        break;
                    }
                    progressBar.Value = dem;
                    List<string> kl = new List<string>();
                    kl.Add(s);

                    if (sd.SuyDien(gt, kl) == true)
                    {
                        ricKQ.Text += listTenNganh.ElementAt(dem) + "\n";
                        d++;
                    }
                    dem++;
                    SendKeys.Flush();
                }
                if (d == 0 && run != false)
                {
                    ricKQ.Text = "Không có ngành phù hợp với yêu cầu lựa chọn!!!\nXin vui lòng chọn lại!!\nChúng tôi sẽ cập nhật thông trong thời gian tới";
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn đầy đủ thông tin!");
            }
            cbhocluc.Enabled = true;
            cbkhoi.Enabled = true;
            cbsothich.Enabled = true;
            btnTuVan.Enabled = true;
        }
        private int FinIndex(string input, List<string> s)
        {
            int i = 0;
            foreach (string a in s)
            {
                if (input == a)
                {
                    return i;
                }
                i++;
            }
            return 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ricKQ.Text = "";
            cbhocluc.Text = "";
            cbkhoi.Text = "";
            cbsothich.Text = "";
            run = false;
            progressBar.Value = progressBar.Maximum;
        }

        private void cbkhoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-1I6U9416\\SQLEXPRESS;Initial Catalog=HCG";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sqlQuery = "SELECT noidung FROM tblluat"; // Thay thế ColumnName và TableName bằng tên cột và bảng tương ứng trong cơ sở dữ liệu của bạn

                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    richTextBox1.Text = reader["noidung"].ToString(); // Thay "ColumnName" bằng tên cột chứa thông tin muốn hiển thị lên TextBox
                }
                else
                {
                    richTextBox1.Text = "No data found.";
                }
            }
        }
    }
}

