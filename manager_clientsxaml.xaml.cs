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
    public partial class manager_clientsxaml : Window
    {
        CustomersTableAdapter clients = new CustomersTableAdapter();
        public manager_clientsxaml()
        {
            InitializeComponent();
            Clients_Datagrid.ItemsSource = clients.GetData();
        }

        private void addClient_button_Click(object sender, RoutedEventArgs e)
        {
            if ((ClientCompanyName_textbox.Text == null) || (CompanyPerson_textbox.Text == null) || (Email_textbox.Text == null) || (phonenumber_textbox.Text == null))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                clients.InsertQuery(ClientCompanyName_textbox.Text, CompanyPerson_textbox.Text, phonenumber_textbox.Text, Email_textbox.Text);
            }
            Clients_Datagrid.ItemsSource = clients.GetData();
        }

        private void changeClient_button_Click(object sender, RoutedEventArgs e)
        {
            int ClientID = (int)(Clients_Datagrid.SelectedItem as DataRowView).Row[0];
            if ((ClientCompanyName_textbox.Text == null) || (CompanyPerson_textbox.Text == null) || (Email_textbox.Text == null) || (phonenumber_textbox.Text == null))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                clients.UpdateQuery(ClientCompanyName_textbox.Text, CompanyPerson_textbox.Text, phonenumber_textbox.Text, Email_textbox.Text, ClientID);
            }
            Clients_Datagrid.ItemsSource = clients.GetData();
        }

        private void deleteClient_button_Click(object sender, RoutedEventArgs e)
        {
            int ClientID = (int)(Clients_Datagrid.SelectedItem as DataRowView).Row[0];
            clients.DeleteQuery(ClientID);
            Clients_Datagrid.ItemsSource = clients.GetData();
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

        private void Clients_Datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Clients_Datagrid.SelectedItem != null)
            {
                string SelectedCompanyName = (string)(Clients_Datagrid.SelectedItem as DataRowView).Row[1];
                ClientCompanyName_textbox.Text = SelectedCompanyName;
                string SelectedPerson = (string)(Clients_Datagrid.SelectedItem as DataRowView).Row[2];
                CompanyPerson_textbox.Text = SelectedPerson;
                string SelectedPhone = (string)(Clients_Datagrid.SelectedItem as DataRowView).Row[3];
                phonenumber_textbox.Text = SelectedPhone;
                string SelectedEmail = (string)(Clients_Datagrid.SelectedItem as DataRowView).Row[4];
                Email_textbox.Text = SelectedEmail;
            }
            else { }
        }
    }
}
