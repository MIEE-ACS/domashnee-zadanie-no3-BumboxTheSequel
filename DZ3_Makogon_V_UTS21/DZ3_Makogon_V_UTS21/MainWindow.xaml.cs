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

namespace DZ3_Makogon_V_UTS21
    //ВАРИАНТ 8
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ArrLen = Tb_send.Text.Length;
            int count = 0;
            char[] Arr = Tb_send.Text.ToCharArray();
            //Я взял кол-во элементов в строке на один элемент меньше, т.к. цикл рассматривает одновременно и текущий элемент, и следующий, что при неправильном построении цикла повлечёт за собой выход из массива и ошибку
            for (int i = 0; i < ArrLen-1; i++)
            {
                // Чтобы слово посчиталось, необходимо, чтобы впереди него был другой любой элемент
                if ((Char.IsLetter(Arr[i]) == true) &&((Char.IsDigit(Arr[i + 1]) == true) || (Char.IsPunctuation(Arr[i + 1]) == true) || (Char.IsWhiteSpace(Arr[i + 1]) == true)))
                {
                    count += 1;
                }
                // подсчёт последнего слова
                if ((Char.IsLetter(Arr[i+1]) == true) && (i == ArrLen - 2))
                {
                    count += 1;
                }
            }
            Tb_Output.Text = String.Format("{0}", count);
        }
    }
}
