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

namespace WPF_Opgave_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ classBIZ = new ClassBIZ();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Opgave12(ListBoxRes);
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Opgave13(ListBoxRes);
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Opgave14(ListBoxRes);
        }
    }
}
