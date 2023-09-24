using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Http;
using System.Net;

namespace Estoque_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new HttpClient();

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=ragnatech.com.br;Database=ragnat92_estoque_system;Uid=ragnat92_master_user;Pwd=Chinelo00123@;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand comando = new MySqlCommand("SELECT `item` FROM `estoque` where `id` = 1", connection);
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            MessageBox.Show(dt.Rows[0]["item"].ToString());

            connection.Close();

        }


        private async Task<ClimaData.Root> httpGetClimaAsync()
        {

            var endpoint = $"https://api.hgbrasil.com/weather?woeid=455827";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(endpoint)
            };

            // request.Headers.Add("Authorization-Key", _accessToken);

            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var clima = JsonExtension.JsonToObject<ClimaData.Root>(json);
            return clima;


        }

        private async Task<ClimaData.Root> httpGetCidadeAsync()
        {
            try
            {
                var endpoint = $"https://api.hgbrasil.com/weather?woeid=455827";

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(endpoint)
                };

                // request.Headers.Add("Authorization-Key", _accessToken);

                var response = await _httpClient.SendAsync(request);

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                var clima = JsonExtension.JsonToObject<ClimaData.Root>(json);
                return clima;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var clima = httpGetClimaAsync().Result;

                txt_Cidade.Text = clima.results.city_name.ToString();
                txt_Clima.Text = clima.results.description.ToString();
                txt_Temp.Text = clima.results.temp.ToString() + "º C";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }
    }
}