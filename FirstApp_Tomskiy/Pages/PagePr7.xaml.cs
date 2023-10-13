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
    /// Логика взаимодействия для PagePr7.xaml
    /// </summary>
    public partial class PagePr7 : Page
    {
        public PagePr7()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            int[] array = GenerateRandomArray(12);
            int sum = SumEvenElements(array);

            arrayListBox.ItemsSource = array;
            resultTextBlock.Text = $"Сумма четных элементов: {sum}";
        }

        private int[] GenerateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            return array;
        }

        private int SumEvenElements(int[] array)
        {
            return array.Where(x => x % 2 == 0).Sum();
        }
    }
}