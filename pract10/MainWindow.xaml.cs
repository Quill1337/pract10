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
  List<int> AvgNegativeNums = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TaskShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митрофанов Роман ИСП-31\nСоставьте программу вычисления среднего арифметического отрицательных элементов.");
        }

        private void CloseProg_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            CapacityLenghtTextBox.Clear();
            AvgNums.Clear();
            AvgNegativeNums.Clear();
            ArrNums.Items.Clear();
            CapacityLenghtTextBox.Focus();
        }

        private void CapacityLenghtTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(CapacityLenghtTextBox.Text, out int capacity))
            {
                AvgNegativeNums = new List<int>(capacity);
                FillCollection(ref AvgNegativeNums, -10, 10);
                AddElemToDataGrid(AvgNegativeNums);
            }
            else
            {
                
                ArrNums.Items.Clear();
            }
        }
        public void AddElemToDataGrid(List<int> nums)
        {
            ArrNums.Items.Clear();
            foreach (int item in nums)
            {
                ArrNums.Items.Add(new Nums() { Num = item });
            }
        }
        public static void FillCollection(ref List<int> nums, int minRandNum, int maxRandNum)
        {
            Random rnd = new Random();
            for (int i = 0; i < nums.Capacity; i++)
            {
                nums.Add(rnd.Next(minRandNum, maxRandNum));
            }
        }

        private void ResBut_Click(object sender, RoutedEventArgs e)
        {
            double sum = 0, negativeCount = 0;
            for (int i = 0; i < AvgNegativeNums.Capacity; i++)
            {
                if (AvgNegativeNums[i] < 0)
                {
                    sum += AvgNegativeNums[i];
                }
                negativeCount = i + 1;
            }
            double avgNum = sum / negativeCount;
            AvgNums.Text = $"{avgNum}";
        }
    }
    public class Nums
    {
        public int Num { get; set; }
    }
}
