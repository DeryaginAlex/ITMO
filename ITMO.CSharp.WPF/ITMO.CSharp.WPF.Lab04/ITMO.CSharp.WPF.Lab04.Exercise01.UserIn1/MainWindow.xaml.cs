using System.Windows;

namespace UserIn1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Your name is " + txtFirstName.Text + " " + txtLastName.Text + " and your email address is " + txtEmail.Text);
        }
    }
}