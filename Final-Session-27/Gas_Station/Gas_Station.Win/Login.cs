using Gas_Station.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_Station.Win
{
    public partial class Login : Form
    {
        public static HttpClient _httpClient;
        public static LoginViewModel _login;

        public Login()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7296/");
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            _login = await _httpClient.GetFromJsonAsync<LoginViewModel>($"login/{username}/{password}");
            if (_login.IsLogin)
            {
                Thread t = new Thread(new ThreadStart(OpenApp));
                t.Start();
                this.Close();
            }           
        }
        public static void OpenApp()
        {
            Application.Run(new HomeF(_httpClient, _login));
        }
    }
}

