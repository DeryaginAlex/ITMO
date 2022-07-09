using System;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;  

namespace ITMO.CSharp.Forms.AddingToDatabase {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        public SqlConnection sqlConnection = null;
        public SqlDataAdapter adapter = null;
        public DataTable table = null;
        public string ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Reports;Data Source=.";
        public string select = @"SELECT * FROM Products";
        public  string insetr = @"INSERT Products VALUES('iPhone 7', 'Apple', 5, 52000)";

        private void Form1_Load(object sender, EventArgs e) {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e) {
            ExecuteQuery(select);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e) {
            string ProductName = toolStripTextBox1.Text;
            string Manufacturer = toolStripTextBox2.Text;
            string ProductCount = (toolStripTextBox3.Text);
            string Price = (toolStripTextBox4.Text);

            if(String.IsNullOrEmpty(ProductName) || String.IsNullOrEmpty(Manufacturer) || String.IsNullOrEmpty(ProductCount) || String.IsNullOrEmpty(Price)) {
                MessageBox.Show("Нельзя ноль");
            } else {
                GetValueForINSERTQuery(ProductName, Manufacturer, Int32.Parse(ProductCount), Int32.Parse(Price));
                ExecuteQuery(insetr);
                ExecuteQuery(select);
            }
        }

        public void ExecuteQuery(string query) {
            adapter = new SqlDataAdapter(query, sqlConnection);
            table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void GetValueForINSERTQuery(string ProductName, string Manufacturer, int ProductCount, int Price) {
            insetr = @"INSERT Products VALUES('" + ProductName + "', '" + Manufacturer + "', " + ProductCount + ", " + Price + ")";
        }
    }
}