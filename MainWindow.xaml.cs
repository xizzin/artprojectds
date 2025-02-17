﻿using iamapollojusticeandiamfine.ArtProjectDataSetTableAdapters;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace iamapollojusticeandiamfine
{
    public partial class MainWindow : Window
    {
        EmployeesTableAdapter employees = new EmployeesTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Auth_button_Click(object sender, RoutedEventArgs e)
        {
            if ((Login_in_textbox.Text == null) && (Password_in_textbox.Text == null))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                var AllLogins = employees.GetData().Rows;
                for (int i = 0; i < AllLogins.Count + 1; i++)
                {
                    if ((AllLogins[i][3].ToString() == Login_in_textbox.Text) && (AllLogins[i][4].ToString() == Password_in_textbox.Text))
                    {
                        LoggedWorkerInfo.LoggedWorkerID = (int)AllLogins[i][0];
                        int roleID = (int)AllLogins[i][2];

                        switch (roleID)
                        {
                            case 2:
                                manager_projects manager_Projects = new manager_projects();
                                manager_Projects.Show();
                                this.Close();
                                break;
                            case 3:
                                main_designer main_designer = new main_designer();
                                main_designer.Show();
                                this.Close();
                                break;
                            case 1:
                                boss_main boss_Main = new boss_main();
                                boss_Main.Show();
                                this.Close();
                                break;
                        }
                    }
                }
            }
        }
    }
}
