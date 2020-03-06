using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Aflevering_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            users.Clear();
            count = 0;
            UserBox.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string line in File.ReadLines(openFileDialog.FileName)){
                    User u = new User(line);
                    users.Add(u);
                    count++;
                }
            }

            UserBox.ItemsSource = users;

            sbLineCount.Text = "Usercount: " + count;
            sbLastRead.Text = "Last updated: " + DateTime.Now.ToString();

        }

        private void UserBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = UserBox.SelectedIndex;
            lblAge.Content = "Age: " + users[index].age;
            lblName.Content = "Name: " + users[index].name;
            lblScore.Content = "Score: " + users[index].score;
            lblId.Content = "Id: " + users[index].id;
        }
    }
}
