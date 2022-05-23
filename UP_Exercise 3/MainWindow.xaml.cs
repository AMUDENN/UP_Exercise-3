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

namespace UP_Exercise_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Definitions.Set_Definitions(this);
        }
        private void Contains_Click(object sender, RoutedEventArgs e)
        {
            contains_result.Text = contains_first_string.Text.Contains(contains_second_string.Text).ToString();
        }
        private void Concat_Click(object sender, RoutedEventArgs e)
        {
            concat_result.Text = string.Concat(concat_first_string.Text, concat_second_string.Text);
        }
        private void EndsWith_Click(object sender, RoutedEventArgs e)
        {
            endswith_result.Text = endswith_first_string.Text.Contains(endswith_second_string.Text).ToString();
        }
        private void Index_Click(object sender, RoutedEventArgs e)
        {
            if (!index_first_string.Text.Contains(index_second_string.Text))
            {
                index_result.Text = "Подстрока не входит в исходную строку"; 
            }
            else
            {
                index_result.Text = $"Индекс первого вхождения: {index_first_string.Text.IndexOf(index_second_string.Text).ToString()}" +
                                $" \nИндекс последнего вхождения: {index_first_string.Text.LastIndexOf(index_second_string.Text).ToString()}";
            }
            
        }
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Exception ex = ExceptionFunctions.Ex_Int(insert_index.Text, "\"Индекс\"", 0);
            if (ex == null)
            {
                try
                {
                    insert_result.Text = insert_first_string.Text.Insert(Convert.ToInt32(insert_index.Text), insert_second_string.Text);
                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(ex.Message,"Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Join_Click(object sender, RoutedEventArgs e)
        {
            join_result.Text = string.Join(join_second_string.Text, join_first_string.Text.Split());
        }

        private void Main_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
