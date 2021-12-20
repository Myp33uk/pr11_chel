using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace pr11_chel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string expression = "ave a#b a2b a$b a4b a5b a-b acb";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Челяев Никита ИСП-31\nДана строка 'ave a#b a2b a$b a4b a5b a-b acb'. Напишите регулярное выражение,  которое найдет строки следующего вида: по краям стоят буквы 'a' и 'b', а между ними - не буква и не цифра. Напишите регулярное выражение, м найдет строки следующего вида: по краям стоят буквы 'a', а между ними - буква от a до g.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"a[^a-z && 0-9 && A-Z]b");
            Regex second = new Regex(@"a[a-g]a"); //2-ая часть задания
            MatchCollection matchCollection = regex.Matches(expression);
            object[] mas = new object[matchCollection.Count];
            matchCollection.CopyTo(mas, 0);
            resultList.ItemsSource = mas;
            button.IsEnabled = false;
        }

    }
}
