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

namespace lab8wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void ButtonAddName_Click(Object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text)) {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
               
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
