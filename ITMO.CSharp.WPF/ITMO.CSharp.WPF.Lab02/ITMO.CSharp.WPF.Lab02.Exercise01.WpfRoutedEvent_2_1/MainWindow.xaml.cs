using System.Windows;
using System.Windows.Controls;

namespace WpfRoutedEvent_2_1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e) {
            MessageBox.Show("Event by textbox");
            e.Handled = (bool)radBut1.IsChecked;
        }

        private void Grid_TextChanged_1(object sender, TextChangedEventArgs e) {
            MessageBox.Show("Event by Grid");
            e.Handled = (bool)radBut2.IsChecked;
        }

        private void Window_TextChanged(object sender, TextChangedEventArgs e) {
            MessageBox.Show("Event by Window");
            e.Handled = (bool)radBut3.IsChecked;
        }
    }
}