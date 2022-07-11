using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ControlWorkApp1
{
    public partial class EllipseForm : Form
    {
        public EllipseForm()
        {
            InitializeComponent();
        }

        private void EllipseForm_Load(object sender, EventArgs e)
        {
            // Добавление эллипса, вписанного в прямоугольную форму 
            // заданной ширины и высоты 
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
