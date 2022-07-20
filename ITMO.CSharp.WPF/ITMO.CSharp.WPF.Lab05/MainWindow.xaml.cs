using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMO.CSharp.WPF.Lab05 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        System.ComponentModel.BackgroundWorker aWorker = new System.ComponentModel.BackgroundWorker();
        public MainWindow() {

            InitializeComponent();
            aWorker.WorkerSupportsCancellation = true;
            aWorker.DoWork += aWorker_DoWork;
            aWorker.RunWorkerCompleted += aWorker_RunWorkerCompleted;
        }
        private void aWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            for(int i = 0 ; i <= 50 ; i++) {
                for(int j = 1 ; j <= 10000000 ; j++) {
                }
                if(aWorker.CancellationPending) {
                    e.Cancel = true;
                    return;
                }
                UpdateDelegate update = new UpdateDelegate(UpdateLabel);
                Label1.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, update, i);
            }
        }
        private void aWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            if(!(e.Cancelled))
                Label2.Content = "Run Completed";
            else
                Label2.Content = "Run Cancelled";
        }
        private delegate void UpdateDelegate(int i);
        private void UpdateLabel(int i) {
            Label1.Content = "Cycles: " + i.ToString();
        }

        private void Button1_Click(object sender, RoutedEventArgs e) {
            aWorker.RunWorkerAsync();
        }

        private void Button2_Click(object sender, RoutedEventArgs e) {
            aWorker.CancelAsync();
        }
    }
}
