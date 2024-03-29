using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Podgotovka_1
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
            
        private void Edit(object sender, EventArgs e)
        {
        
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            if (Login.Text != "" & Pass.Password == Pass2.Password)
            {
                List.Items.Add($"{Login.Text}");
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {

                List.Items.Remove($"{Login.Text}");

        }
    }
}
