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

namespace FirstApp_Tomskiy.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePr2.xaml
    /// </summary>
    public partial class PagePr2 : Page
    {
        public PagePr2()
        {
            InitializeComponent();
        }
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double u;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Фурзиков М.А. и Томский М.В.");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"Y={y}");
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                

                case 0:
                    if (0.5 < x * y & x * y < 10) u = Math.Exp(Math.Sin(x)-Math.Abs(y));
                    else if (0.1 < x * y & x * y < 0.5) u = Math.Sqrt(Math.Abs(Math.Sin(x) + y));
                    else u = 2 * Math.Pow(Math.Sin(x),2);
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                case 1:
                    if (0.5 < x * y & x * y < 10) u = Math.Exp(Math.Cos(x) - Math.Abs(y));
                    else if (0.1 < x * y & x * y < 0.5) u = Math.Sqrt(Math.Abs(Math.Cos(x) + y));
                    else u = 2 * Math.Pow(Math.Cos(x), 2);
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                case 2:
                    if (0.5 < x * y & x * y < 10) u = Math.Exp(Math.Exp(x) - Math.Abs(y));
                    else if (0.1 < x * y & x * y < 0.5) u = Math.Sqrt(Math.Abs(Math.Exp(x) + y));
                    else u = 2 * Math.Pow(Math.Exp(x), 2);
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }




        }
        /// <summary>
        /// Очистить поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();

            lstResult.Items.Clear();
        }

    }
}

