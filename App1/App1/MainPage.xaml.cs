using MySqlConnector;
using System;
using Xamarin.Forms;

namespace App1
{
    public partial class App1 : Application
    {
        public App1()
        {
            InitializeComponent();

            string name = "";
            string fffge = "server=10.0.0.34;user=strelovad;password=eXmOx2Z)Sg886ttG;database=strelovad";
            string nameSQL = $"SELECT * FROM `films` WHERE id = `1`";
            var connect = new MySqlConnection(fffge);
            connect.Open();
            var command = new MySqlCommand(nameSQL, connect);
            var read = command.ExecuteReader();
            if (read.Read())
            {
                name = read.GetString(1);
                byte[] pic = read.GetValue(2) as byte[];
            }


            MainPage = new NavigationPage(new MainPage());
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
