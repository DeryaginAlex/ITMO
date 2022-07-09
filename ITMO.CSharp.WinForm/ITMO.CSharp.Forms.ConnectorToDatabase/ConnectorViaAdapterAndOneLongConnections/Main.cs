using System;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;  

namespace ITMO.CSharp.Forms.AddingToDatabase {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private SqlConnection _sqlConnection = null;
        private SqlDataAdapter _adapter = null;
        private DataTable _table = null;
        private string _connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Reports;Data Source=.";

        private void Form1_Load(object sender, EventArgs e) {
            try {
                _sqlConnection = new SqlConnection(_connectionString);
                _sqlConnection.Open();
            } catch(SqlException) {
                MessageBox.Show("Не удалось подключиться к БД");
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e) {
            _sqlConnection.Close();
            _adapter.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            Execute(Query.Select);
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            string ProductName = toolStripTextBox1.Text;
            string Manufacturer = toolStripTextBox2.Text;
            string ProductCount = toolStripTextBox3.Text;
            string Price = toolStripTextBox4.Text;
            if(String.IsNullOrEmpty(ProductName) || String.IsNullOrEmpty(Manufacturer) || String.IsNullOrEmpty(ProductCount) || String.IsNullOrEmpty(Price)) {
                MessageBox.Show("Входные параметры должны быть обязательно заданы");
            } else {
                GetValueForINSERTQuery(ProductName, Manufacturer, Int32.Parse(ProductCount), Int32.Parse(Price));
                Execute(Query.Insetr);
                Execute(Query.Select);
            }
        }

        public void Execute(string query) {
            try {  
                using(_adapter = new SqlDataAdapter(query, _sqlConnection)) {
                    _table = new DataTable();
                    _table.Clear();
                    _adapter.Fill(_table);
                    dataGridView1.DataSource = _table;
                }
            } catch(Exception) {
                MessageBox.Show("Сервер не найден или недоступен");
            }
        }

        public void GetValueForINSERTQuery(string ProductName, string Manufacturer, int ProductCount, int Price) {
            Query.Insetr = @"INSERT Products VALUES('" + ProductName + "', '" + Manufacturer + "', " + ProductCount + ", " + Price + ")";
        }
    }
}