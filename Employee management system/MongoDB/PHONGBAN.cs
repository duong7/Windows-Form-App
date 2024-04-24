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
    public partial class PHONGBAN : Form
    {
        MongoDatabase db;
        public PHONGBAN()
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
            dataGridView1.DataSource = readToTable("Employee_manage", "Department");
        }
        public DataTable readToTable(string databaseName, string collectionName)
        {
            string[] attribute = new string[] { "Code Department", "Name" };
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
        private void PHONGBAN_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var collection = db.GetCollection<BsonDocument>("Department");

            BsonDocument document = new BsonDocument()
                    .Add("Code Department", textBox1.Text)
                    .Add("Name", textBox2.Text);
                  
            collection.Insert(document);
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataRow newrow = dataTable.NewRow();
            newrow[0] = textBox1.Text;
            newrow[1] = textBox2.Text;
         
            dataTable.Rows.Add(newrow);
            dataTable.AcceptChanges();
            MessageBox.Show("Add successful !!!");
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var collection = db.GetCollection<BsonDocument>("Department");
                var query = new QueryDocument("Code Department", textBox1.Text);
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
                var collection = db.GetCollection<BsonDocument>("Department");
                var query = new QueryDocument("Code Department", textBox1.Text);
                collection.Remove(query);
                BsonDocument nhanvien = new BsonDocument()
                        .Add(getID(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                        .Add("Code Department", textBox1.Text)
                        .Add("Name", textBox2.Text);
                    
                collection.Save(nhanvien);
                int index = dataGridView1.SelectedRows[0].Index;
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                dataTable.Rows[index][0] = textBox1.Text;
                dataTable.Rows[index][1] = textBox2.Text;
                MessageBox.Show("Update successful !!!");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
              
            }
            dataGridView1.ReadOnly = true;
        }
        public BsonElement getID(string MaPB)
        {
            var collection = db.GetCollection<BsonDocument>("Department");
            var query = new QueryDocument("Code Department", MaPB);
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
        }
    }
}
