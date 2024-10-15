using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace talstelsel_h4
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            hexidecimalTextBox.Clear();
            decimalTextBox.Clear();
            hexidecimalTextBox.Focus();

        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            string hexadecimal = hexidecimalTextBox.Text;
            double decimalValue = Convert.ToInt32(hexadecimal, 16);
            decimalTextBox.Text = decimalValue.ToString();
            
        }
    }
}