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
    public partial class manager_projects : Window
    {
        ProjectsTableAdapter projects = new ProjectsTableAdapter();
        EmployeesTableAdapter employees = new EmployeesTableAdapter();
        StatusesTableAdapter statuses = new StatusesTableAdapter();
        public manager_projects()
        {
            InitializeComponent();
            projects_datagrid.ItemsSource = projects.GetEverything();

            WorkeronProject_Combobox.ItemsSource = employees.GetData();
            WorkeronProject_Combobox.DisplayMemberPath = "FullName";

            status_combobox.ItemsSource = statuses.GetData();
            status_combobox.DisplayMemberPath = "StatusName";

        }

        private void DoAfterLoad(object sender, RoutedEventArgs e)
        {
            projects_datagrid.Columns[0].Visibility = Visibility.Collapsed;
            projects_datagrid.Columns[2].Visibility = Visibility.Collapsed;
            projects_datagrid.Columns[3].Visibility = Visibility.Collapsed;
            projects_datagrid.Columns[7].Visibility = Visibility.Collapsed;
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

        private void Filtr_button_Click(object sender, RoutedEventArgs e)
        {
            int WorkerID = (int)(WorkeronProject_Combobox.SelectedItem as DataRowView).Row[0];
            int StatusID = (int)(status_combobox.SelectedItem as DataRowView).Row[0];

            if ((status_combobox.SelectedItem == null) && (WorkeronProject_Combobox.SelectedItem != null))
            {
                projects_datagrid.ItemsSource = projects.SearchByWorkerID(WorkerID);

            }
            if ((status_combobox.SelectedItem != null) && (WorkeronProject_Combobox.SelectedItem == null))
            {
                projects_datagrid.ItemsSource = projects.SearchByStatsusID(StatusID);

            }
            if ((status_combobox.SelectedItem != null) && (WorkeronProject_Combobox.SelectedItem != null))
            {
                projects_datagrid.ItemsSource = projects.SearchByBoth(WorkerID, StatusID);

            }
            else
            {
                projects_datagrid.ItemsSource = projects.GetEverything();
            }
            WorkeronProject_Combobox.SelectedItem = null;
            status_combobox.SelectedItem = null;
        }
    }
}
