using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWorkApp2
{
    public partial class FinishForm : Form
    {
        public FinishForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishForm_Load(object sender, EventArgs e) {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            using(GraphicsPath myPath = new GraphicsPath()) {
                myPath.AddLines(new[]
                    {
                new Point(0, Height / 2),
                new Point(Width / 2, 0),
                new Point(Width, Height / 2),
                new Point(Width / 2, Height)
            });
                Region = new Region(myPath);
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
