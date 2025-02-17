using iamapollojusticeandiamfine.ArtProjectDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace iamapollojusticeandiamfine
{
    public partial class manager_comments : Window
    {
        ReviewTableAdapter reviews = new ReviewTableAdapter();
        ProjectsTableAdapter projects = new ProjectsTableAdapter();
        public manager_comments()
        {
            InitializeComponent();
            Comments_Datagrid.ItemsSource = reviews.GetData();

            projectname_combobox.ItemsSource = projects.GetData();
            projectname_combobox.DisplayMemberPath = "StageName";
        }

        private void DoAfterLoad(object sender, RoutedEventArgs e)
        {
            Comments_Datagrid.Columns[0].Visibility = Visibility.Collapsed;
            Comments_Datagrid.Columns[1].Visibility = Visibility.Collapsed;
        }

        private void addComment_button_Click(object sender, RoutedEventArgs e)
        {
            int ProjectID = (int)(projectname_combobox.SelectedItem as DataRowView).Row[0];
            if ((projectname_combobox.SelectedItem == null) || (ReviewText_textbox.Text == null) || (ReviewType_textbox.Text == null) || (ReviewTime_textbox.Text == null))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                reviews.InsertQuery(ProjectID, ReviewType_textbox.Text, ReviewText_textbox.Text, ReviewTime_textbox.Text);
            }
            Comments_Datagrid.ItemsSource = reviews.GetData();

        }
        private void TO_Comments_button_Click(object sender, RoutedEventArgs e)
        {
            manager_comments manager_Comments = new manager_comments();
            manager_Comments.Show();
            this.Close();
        }

        private void TO_All_orders_button_Click(object sender, RoutedEventArgs e)
        {
            manager_projects manager_Projects = new manager_projects();
            manager_Projects.Show();
            this.Close();
        }

        private void TO_Clients_button_Click(object sender, RoutedEventArgs e)
        {
            manager_clientsxaml manager_Clientsxaml = new manager_clientsxaml();
            manager_Clientsxaml.Show();
            this.Close();
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
