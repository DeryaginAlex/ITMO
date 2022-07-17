using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UserIn2 {
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

        private void button2_Click(object sender, RoutedEventArgs e) {
            richTextBox1.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Italic);
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            richTextBox1.Selection.ApplyPropertyValue(FontFamilyProperty, new FontFamily(comboBox1.Text));

        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            richTextBox1.Selection.ApplyPropertyValue(FontSizeProperty, Slider1.Value.ToString());
        }
    }
}
