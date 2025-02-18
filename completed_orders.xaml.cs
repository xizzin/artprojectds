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
    public partial class completed_orders : Window
    {
        ProjectsTableAdapter projects = new ProjectsTableAdapter();
        EmployeesTableAdapter employees = new EmployeesTableAdapter();
        StatusesTableAdapter statuses = new StatusesTableAdapter();
        public completed_orders()
        {
            InitializeComponent();
            Completed_orders_datagrid.ItemsSource = projects.GetDoneProjects();

            Combobox_ProjectName.ItemsSource = projects.GetData();
            Combobox_ProjectName.DisplayMemberPath = "StageName";

            ProjectWorker_combobox.ItemsSource = employees.GetData();
            ProjectWorker_combobox.DisplayMemberPath = "FullName";

            Status_combobox.ItemsSource = statuses.GetData();
            Status_combobox.DisplayMemberPath = "StatusName";
        }

        private void DoAfterLoad(object sender, RoutedEventArgs e)
        {
            Completed_orders_datagrid.Columns[0].Visibility = Visibility.Collapsed;
            Completed_orders_datagrid.Columns[2].Visibility = Visibility.Collapsed;
            Completed_orders_datagrid.Columns[3].Visibility = Visibility.Collapsed;
            Completed_orders_datagrid.Columns[5].Visibility = Visibility.Collapsed;
            Completed_orders_datagrid.Columns[6].Visibility = Visibility.Collapsed;
            Completed_orders_datagrid.Columns[7].Visibility = Visibility.Collapsed;
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

        private void project_StatusDone_Click(object sender, RoutedEventArgs e)
        {
            if (Combobox_ProjectName.SelectedItem == null)
            {
                MessageBox.Show("НЕ выбран проект! ВЫберите проект и попыйтайтесь снова");
            }
            else
            {
                int ProjectID = (int)(Combobox_ProjectName.SelectedItem as DataRowView).Row[0];
                projects.SetDoneStatus(2, ProjectID);
                Completed_orders_datagrid.ItemsSource = projects.GetDoneProjects();
            }
        }

        private void changeOrder_button_Click(object sender, RoutedEventArgs e)
        {
            
            if ((ProjectWorker_combobox.SelectedItem == null) || (Status_combobox.SelectedItem == null) || (Status_combobox.Text == null))
            {
                MessageBox.Show("Заполнены не все поля!");
            }
            else
            {
                int StatusID = (int)(Status_combobox.SelectedItem as DataRowView).Row[0];
                int WorkerID = (int)(ProjectWorker_combobox.SelectedItem as DataRowView).Row[0];
                int ProjectID = (int)(Completed_orders_datagrid.SelectedItem as DataRowView).Row[0];
                projects.UpdateQuery(WorkerID, Project_desc_textbox.Text, StatusID, ProjectID);
            }
            Completed_orders_datagrid.ItemsSource = projects.GetDoneProjects();

        }

        private void deleteOrder_button_Click(object sender, RoutedEventArgs e)
        {
            int ProjectID = (int)(Completed_orders_datagrid.SelectedItem as DataRowView).Row[0];
            projects.DeleteQuery(ProjectID);
            Completed_orders_datagrid.ItemsSource = projects.GetDoneProjects();

        }

        private void Completed_orders_datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Completed_orders_datagrid.SelectedItem != null)
            {
                string SelectedName = (string)(Completed_orders_datagrid.SelectedItem as DataRowView).Row[1];
                ProjectName_textbox.Text = SelectedName;
                string Selected_desc = (string)(Completed_orders_datagrid.SelectedItem as DataRowView).Row[4];
                Project_desc_textbox.Text = Selected_desc;

                int SelectedAWorkerID = (int)(Completed_orders_datagrid.SelectedItem as DataRowView).Row[3];
                ProjectWorker_combobox.SelectedIndex = SelectedAWorkerID;
                int SelectedStatusID = (int)(Completed_orders_datagrid.SelectedItem as DataRowView).Row[7];
                Status_combobox.SelectedIndex = SelectedStatusID;
            }
            else { }
        }
    }
}
