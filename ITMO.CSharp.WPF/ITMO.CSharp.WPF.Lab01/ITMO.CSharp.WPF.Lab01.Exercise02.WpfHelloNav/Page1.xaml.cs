using System.Windows;
using System.Windows.Controls;

namespace WpfHelloNav {
    public partial class Page1 : Page {
        public Page1() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            Page2 page = new Page2();
            this.NavigationService.Navigate(page);

        }
    }
}