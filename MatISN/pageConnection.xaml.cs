using Npgsql;
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
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;

namespace MatISN
{
    /// <summary>
    /// Logique d'interaction pour pageConnection.xaml
    /// </summary>
    public partial class pageConnection : Window
    {
        public static string user = "";
        public static string password = "";

        public pageConnection()
        {
            InitializeComponent();
            
            WindowStyle = WindowStyle.None;
            

        }

        private void butConnection_Click(object sender, RoutedEventArgs e)
        {
            user = txtLogin.Text;
            password = txtMDP.Password;
            DialogResult = true;
            
        }

        private void butAnnuler_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}