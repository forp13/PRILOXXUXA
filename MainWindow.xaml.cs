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
using WpfApp1.View;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly Frame _frame;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public MainWindow(Frame frame) : this()
        {
            _frame = frame;
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Main_empty(mainFrame));
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new MainEmpty(mainFrame));
        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
