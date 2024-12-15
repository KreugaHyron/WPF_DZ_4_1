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

namespace WPF_DZ_4_1
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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            NameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            PasswordBox.Password = string.Empty;

            ErrorMessageLabel.Visibility = Visibility.Collapsed;
            SuccessMessageLabel.Visibility = Visibility.Collapsed;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                ErrorMessageLabel.Content = "Заповніть всі поля";
                ErrorMessageLabel.Visibility = Visibility.Visible;
                SuccessMessageLabel.Visibility = Visibility.Collapsed;
            }
            else
            {
                SuccessMessageLabel.Content = "Реєстрація успішна!";
                SuccessMessageLabel.Visibility = Visibility.Visible;
                ErrorMessageLabel.Visibility = Visibility.Collapsed;
            }
        }
    }
}
