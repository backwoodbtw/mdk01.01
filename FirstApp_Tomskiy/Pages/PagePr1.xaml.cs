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
    /// Логика взаимодействия для PagePr1.xaml
    /// </summary>
    public partial class PagePr1 : Page
    {
        public PagePr1()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtX.Text);
            double y = Convert.ToDouble(TxtY.Text);
            double z = Convert.ToDouble(TxtZ.Text);

            double psi = Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 0.333)) + (y - x) * (Math.Cos(y) - z / (y - x)) / (1 + (Math.Pow(y - x, 2)));

            LstResult.Items.Add("ПР№1 ИСП.21.2А Фурзиков Томский");
            LstResult.Items.Add($"x = {x}");
            LstResult.Items.Add($"y = {y}");
            LstResult.Items.Add($"z = {z}");
            LstResult.Items.Add($"Результат psi = {psi}");

        }
    }
}
