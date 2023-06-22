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
using System.Windows.Shapes;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Windows.Navigation;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Tasks.xaml
    /// </summary>
    public partial class Tasks : System.Windows.Window
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Lession_Click(object sender, RoutedEventArgs e)
        {
            GodovoyOtchet godovoyOtchet = new GodovoyOtchet();
            godovoyOtchet.Show(); 
            
        }

        

        private void BtnUsExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private void Btn_Komplekt_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            Document document = ap.Documents.Open(System.IO.Path.GetFullPath(@"Resources\Кос_1курс (2).docx"));
            ap.Visible = true;
        }
        

        private void Test_1_Click(object sender, RoutedEventArgs e)
        {
         Window1 ylica1 =  new Window1();
            ylica1.Show();
            Close();
        }

        private void Test_2_Click(object sender, RoutedEventArgs e)
        {
            Window2 ylica2 = new Window2();
            ylica2.Show();
            Close();

        }

        private void Test_3_Click(object sender, RoutedEventArgs e)
        {
            Window3 ylica3 = new Window3();
            ylica3.Show();
            Close();
        }

        private void Test_4_Click(object sender, RoutedEventArgs e)
        {
            Window4 ylica4 = new Window4();
            ylica4.Show();
            Close();
        }

        private void Test_5_Click(object sender, RoutedEventArgs e)
        {
            Window5 ylica5 = new Window5();
            ylica5.Show();
            Close();
        }

        private void Test_6_Click(object sender, RoutedEventArgs e)
        {
            Window6 ylica6 = new Window6();
            ylica6.Show();
            Close();
        }
    }
}
