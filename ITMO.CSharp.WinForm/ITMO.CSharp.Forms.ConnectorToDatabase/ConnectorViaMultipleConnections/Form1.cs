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

namespace AddingToDatabase {
    public partial class Form1 : Form {


        private string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Reports;Data Source=.";
        private string querySelect = @"SELECT * FROM Products";


        public Form1() {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            using(SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(querySelect, conn)) {
                    using(SqlDataReader reader = cmd.ExecuteReader()) {
                        MessageBox.Show(reader.ToString());
                    }
                }
            }
        }
    }
}
