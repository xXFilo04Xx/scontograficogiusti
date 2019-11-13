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

namespace scontograficogiusti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double imponibile = double.Parse(txtimponibile.Text);
            int sconto = int.Parse(txtsconto.Text);
            if (sconto == 0)
            {
                sconto = 0;
            }
            double s = imponibile * sconto / 100;
            imponibile = imponibile - s;
            txtimponibilesconto.Text = string.Format("{0:c}", s);
            int iva = int.Parse(txtiva.Text);
            if (iva == 0)
            {
                iva = 0;
            }
            double i = imponibile * iva / 100;
            imponibile = imponibile + i;
            txtimponibileiva.Text = string.Format("{0:c}", i);
            txttotale.Text = string.Format("{0:c}", imponibile);
        }
    }
}
