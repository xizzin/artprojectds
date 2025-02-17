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
using System.Windows.Shapes;
using iamapollojusticeandiamfine.ArtProjectDataSetTableAdapters;

namespace iamapollojusticeandiamfine
{
    /// <summary>
    /// Логика взаимодействия для main_designer.xaml
    /// </summary>
    public partial class main_designer : Window
    {
        ProjectsTableAdapter projects = new ProjectsTableAdapter();
        public main_designer()
        {
            InitializeComponent();
            All_orders_datagrid.ItemsSource = projects.GetEverything(); 
        }

        private void DoAfterLoad(object sender, RoutedEventArgs e)
        {
            All_orders_datagrid.Columns[0].Visibility = Visibility.Collapsed;
        }

        private void TO_Completed_orders_button_Click(object sender, RoutedEventArgs e)
        {
            completed_orders compord = new completed_orders();
            compord.Show();
            this.Close();
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void TO_All_orders_button_Click(object sender, RoutedEventArgs e)
        {
            main_designer main_Designer = new main_designer();
            main_Designer.Show();
            this.Close();
        }
    }
}
