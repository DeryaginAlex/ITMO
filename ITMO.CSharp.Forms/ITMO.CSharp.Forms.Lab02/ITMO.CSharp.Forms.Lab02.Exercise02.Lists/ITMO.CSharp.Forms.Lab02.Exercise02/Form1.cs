using System;
using System.Windows.Forms;

namespace ITMO.CSharp.Forms.Lab02.Exercise02 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            if(peopleList.Text.Length != 0) {
                memberList.Items.Add(peopleList.Text);
            } else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            while(memberList.CheckedIndices.Count > 0)
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void buttonSort_Click(object sender, EventArgs e) {
            memberList.Sorted = true;
        }
    }
}
