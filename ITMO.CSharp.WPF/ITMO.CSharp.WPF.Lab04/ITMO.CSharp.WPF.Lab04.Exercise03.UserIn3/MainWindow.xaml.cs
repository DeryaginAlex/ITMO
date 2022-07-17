using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPU_lab4_task3_UserIn3 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            foreach(FontFamily F in Fonts.SystemFontFamilies) {
                comboBox1.Items.Add(F.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            richTextBox1.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Bold);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            richTextBox1.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Italic);
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            ValueChanged:
            try {
                richTextBox1.Selection.ApplyPropertyValue(FontSizeProperty, Slider1.Value.ToString());
            } catch { }
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            richTextBox1.Selection.ApplyPropertyValue(FontFamilyProperty, ((ListBoxItem)listBox1.SelectedItem).FontFamily);
        }
    }
}
