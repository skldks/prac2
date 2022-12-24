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
using LibMas;
using Lib13;
using Microsoft.Win32;

namespace prac2
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
        int[] mas;
        private void Random_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Int32.TryParse(NizhPred.Text, out int min);
                Int32.TryParse(VerhPred.Text, out int max);
                Int32.TryParse(Lengt.Text, out int lent);
                mas = Masssiv.Zapol(min, max, lent);
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введите допустимое значение размера массива");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Введите минимальное значение рандома меньше максимального");
            }
        }

        private void Clear_Ckick(object sender, RoutedEventArgs e)
        {
            Masssiv.Clear(mas);
            dataGrid.ItemsSource = null;
        }

        private void Chet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                itogovoe.Text = $"{Resh.Rezu(mas)}";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Сначала заполните массив");
            }
        }

        private void Spravka_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кузнецов Алексей Алексеевич ИСП-31. Вариант 13: Ввести n целых чисел. Найти произведение чисел > 2. Результат вывести на экран");
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LibMas.Masssiv.SaveMassiv(mas);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Массив не может быть пустой");
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LibMas.Masssiv.OpenMassiv(ref mas); 
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введите не пустой массив");
            }
        }
    }
}
