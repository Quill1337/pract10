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

namespace pract10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private List<int> array = new List<int>(10);

        private void FillList_Click(object sender, RoutedEventArgs e) //заполнение ListBox
        {
            values.Items.Clear();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array.Add(random.Next(-100, 100));
                values.Items.Add(array[i]);
            }
        }

        private void FindAverage_Click(object sender, RoutedEventArgs e) //поиск средне арифметического
        {
            if (array.Count == 0)
            {
                MessageBox.Show("Заполните список!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                array = array.FindAll(x => x < 0);
                result.Text = array.Average().ToString();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            values.Items.Clear();
            result.Clear();
        }
        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митрофанов Роман ИСП-31\nСоставьте программу вычисления среднего арифметического отрицательных элементов и его номера.");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
