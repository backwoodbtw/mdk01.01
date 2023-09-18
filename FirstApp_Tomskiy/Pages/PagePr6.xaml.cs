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
using System.IO;

namespace FirstApp_Tomskiy.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePr6.xaml
    /// </summary>
    public partial class PagePr6 : Page
    {
        public PagePr6()
        {
            InitializeComponent();
        }

        private void BtnListFromFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                LstInput.Items.Add(sr.ReadLine());
            }
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            try // обработка исключения
            {
                // получаем номер выделенной строки
                int index = LstInput.SelectedIndex;

                // считываем строку в переменную str
                string str = (string)LstInput.Items[index];

                // узнаем количество символов в строке
                int len = str.Length;

                // считаем, что количество пробелов равно 0
                int count = 0;

                // устанавливаем счетчик символов в 0
                int i = 0;

                string[] str1 = str.Split();
                for (i = 0; i < str1.Length; i++)
                {
                    char Letter = char.ToLower(str1[i][0]);
                    str1[i] = Letter + str1[i].Substring(1);
                }

               
                
                TxbResult.Text = string.Join(" ", str1);
                StreamWriter sw = new StreamWriter(@"result.txt");
                sw.WriteLine($"Номер строки: {index}");
                sw.WriteLine($"Исходная строка: {index}");
                sw.WriteLine($"Новая строка: {TxbResult.Text}");
                sw.Close();
            }
            catch (Exception ex) // поймать ошибку
            {
                MessageBox.Show(ex.Message); // вывести сообщение об ошибке
            }
            }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            LstInput.Items.Clear();
        }
    }
    }



