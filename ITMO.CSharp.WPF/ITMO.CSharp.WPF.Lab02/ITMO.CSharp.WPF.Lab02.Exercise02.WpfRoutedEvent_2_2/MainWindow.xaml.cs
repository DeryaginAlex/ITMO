using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RoutedEvent_2_2 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e) {
            FrameworkElement feSource = e.Source as FrameworkElement;
            double a = Double.Parse(txtBox.Text);
            switch(feSource.Name) {
                case "butAdd":
                    a += a;
                    break;
                case "butMult":
                    a *= a;
                    break;
            }
            e.Handled = true;
            txtBox.Text = String.Format("{0:#.##}", a);
        }
    }
}