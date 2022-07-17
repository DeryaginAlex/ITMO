using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfHello {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            button.IsEnabled = false;
            button1.IsEnabled = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            button1.IsEnabled = true;
            try {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("username.txt");
                sw.WriteLine(textBox.Text);
                sw.Close();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            try {
                System.IO.StreamReader sr = new System.IO.StreamReader("username.txt");
                label.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {
            button.IsEnabled = true;
        }
    }
}