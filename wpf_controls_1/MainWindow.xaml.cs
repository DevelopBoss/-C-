using PowerArgs.Cli;
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

namespace wpf_controls_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " отмечен");
        }

        void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " не отмечен");
        }

        void checkBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " в неопределенном состоянии");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            MessageBox.Show(pressed.Content.ToString());
        }
    }
}
