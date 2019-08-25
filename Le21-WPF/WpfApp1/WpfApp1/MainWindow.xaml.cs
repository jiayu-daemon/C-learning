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
using System.IO.Ports;


namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort com = new SerialPort("COM1", 9600);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte[] buffer = { 0x4e, 0x4c, 0x00, 0x32, 0x11, 0x01 };
            char[] buf = { ' ' };
            try
            {
                com.Open();
                com.Write(buffer, 0, 6);
                com.Read(buf, 0, 1);

                com.Close();
            }
            catch (Exception )
            {
                Console.WriteLine("e IOException");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
    }
}
