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
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
namespace MongoDB
{
    public partial class NHANVIEN : Form
    {
        MongoDatabase db;
        public NHANVIEN()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            db = server.GetDatabase("Employee_manage");
            loaddata();
        }
        public void loaddata()
        {
            dataGridView1.DataSource = readToTable("Employee_manage", "Employee");
        }
        public DataTable readToTable(string databaseName, string collectionName)
        {
            string[] attribute = new string[] { "Employee code", "Name", "Date of birth", "Address", "Phone number", "Gender", "Department", "Position", "Salary($)" };
            DataTable datatable = new DataTable();
            //Create datatable
            for (int i = 0; i < attribute.Length; i++)
            {
                datatable.Columns.Add(attribute[i]);
            }
            var collection = db.GetCollection<BsonDocument>(collectionName);
            foreach (BsonDocument item in collection.FindAll())
            {
                DataRow newrow = datatable.NewRow();
                for (int j = 0; j < attribute.Length; j++)
                {
                    newrow[j] = item.GetElement(attribute[j]).Value.ToString();
                }
                datatable.Rows.Add(newrow);
            }
            return datatable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var collection = db.GetCollection<BsonDocument>("Employee");

            BsonDocument document = new BsonDocument()
                    .Add("Employee code", textBox1.Text)
                    .Add("Name", textBox2.Text)
                    .Add("Date of birth", dateTimePicker1.Text)
                    .Add("Address", textBox3.Text)
                    .Add("Phone number", maskedTextBox1.Text)
                    .Add("Gender", comboBox1.Text)
                    .Add("Department", textBox4.Text)
                    .Add("Position", comboBox2.Text)
                    .Add("Salary($)", numericUpDown1.Text);
            collection.Insert(document);
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataRow newrow = dataTable.NewRow();
            newrow[0] = textBox1.Text;
            newrow[1] = textBox2.Text;
            newrow[2] = dateTimePicker1.Text;
            newrow[3] = textBox3.Text;
            newrow[4] = maskedTextBox1.Text;
            newrow[5] = comboBox1.Text;
            newrow[6] = textBox4.Text;
            newrow[7] = comboBox2.Text;
            newrow[8] = numericUpDown1.Text;
            dataTable.Rows.Add(newrow);
            dataTable.AcceptChanges();
            MessageBox.Show("Add successful !!!");
            loaddata();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var collection = db.GetCollection<BsonDocument>("Employee");
                var query = new QueryDocument("Employee code", textBox1.Text);
                collection.Remove(query);
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                int index = dataGridView1.SelectedRows[0].Index;
                dataTable.Rows.RemoveAt(index);
                MessageBox.Show("Delete successful !!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var collection = db.GetCollection<BsonDocument>("Employee");
                var query = new QueryDocument("Employee code", textBox1.Text);
                collection.Remove(query);
                BsonDocument employee = new BsonDocument()
                        .Add(getID(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                        .Add("Employee code", textBox1.Text)
                        .Add("Name", textBox2.Text)
                        .Add("Date of birth", dateTimePicker1.Text)
                        .Add("Address", textBox3.Text)
                        .Add("Phone number", maskedTextBox1.Text)
                        .Add("Gender", comboBox1.Text)
                        .Add("Department", textBox4.Text)
                        .Add("Position", comboBox2.Text)
                        .Add("Salary($)", numericUpDown1.Text);

                collection.Save(employee);
                int index = dataGridView1.SelectedRows[0].Index;
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                dataTable.Rows[index][0] = textBox1.Text;
                dataTable.Rows[index][1] = textBox2.Text;
                dataTable.Rows[index][2] = dateTimePicker1.Text;
                dataTable.Rows[index][3] = textBox3.Text;
                dataTable.Rows[index][4] = maskedTextBox1.Text;
                dataTable.Rows[index][5] = comboBox1.Text;
                dataTable.Rows[index][6] = textBox4.Text;
                dataTable.Rows[index][7] = comboBox2.Text;
                dataTable.Rows[index][8] = numericUpDown1.Text;
                MessageBox.Show("Update successful !!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                maskedTextBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                numericUpDown1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
            dataGridView1.ReadOnly = true;
        }
        public BsonElement getID(string Employeecode)
        {
            var collection = db.GetCollection<BsonDocument>("Employee");
            var query = new QueryDocument("Employee code", Employeecode);
            foreach (BsonDocument item in collection.Find(query))
            {
                return item.GetElement("_id");
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
            maskedTextBox1.Clear();
            textBox1.Focus();
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
