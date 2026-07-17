using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoGreen
{
    public partial class FormIntreaba_ma : Form
    {
        private const string ApiKey = "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";

        private static readonly HttpClient httpClient = new HttpClient()
        {
            Timeout = TimeSpan.FromSeconds(60)
        };

        public FormIntreaba_ma()
        {
            ServicePointManager.SecurityProtocol =
                SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;

            InitializeComponent();
        }

        private void FormIntreaba_ma_Load(object sender, EventArgs e)
        {
            AplicaTemeCulori();
            Culori.CuloriSchimbate += Culori_CuloriSchimbate;

            lblRaspuns.AutoSize = false;
            lblRaspuns.Width = 520;
            lblRaspuns.Height = 250;
        }

        private void Culori_CuloriSchimbate(object sender, EventArgs e)
        {
            AplicaTemeCulori();
        }

        private void AplicaTemeCulori()
        {
            BackColor = Culori.Backgroundcolor;

            foreach (Control c in Controls)
                c.ForeColor = Culori.TextColor;
        }

        private async void btnIntreaba_ma_Click(object sender, EventArgs e)
        {
            string intrebare = tboxIntrebare.Text.Trim();

            if (string.IsNullOrWhiteSpace(intrebare))
            {
                lblRaspuns.Text = "Introdu o întrebare.";
                return;
            }

            btnIntreaba.Enabled = false;
            lblRaspuns.Text = "Se generează răspunsul...";

            try
            {
                string context = "";

                string fisier = Path.Combine(
                    Application.StartupPath,
                    "res",
                    "instructiuni.txt");

                if (File.Exists(fisier))
                    context = File.ReadAllText(fisier);

                string prompt =
                    context +
                    "\n\nÎntrebarea utilizatorului:\n" +
                    intrebare;

                var body = new
                {
                    model = "google/gemma-4-26b-a4b-it:free",

                    messages = new object[]
                    {
                        new
                        {
                            role = "user",
                            content = prompt
                        }
                    }
                };

                string json = JsonSerializer.Serialize(body);

                var request = new HttpRequestMessage(
                    HttpMethod.Post,
                    "https://openrouter.ai/api/v1/chat/completions");

                request.Headers.Add("Authorization", $"Bearer {ApiKey}");
                request.Headers.Add("HTTP-Referer", "https://gogreen.local");
                request.Headers.Add("X-Title", "GoGreen");

                request.Content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                HttpResponseMessage response =
                    await httpClient.SendAsync(request);

                string rezultat =
                    await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    lblRaspuns.Text = rezultat;
                    return;
                }

                JsonDocument document =
                    JsonDocument.Parse(rezultat);

                string raspuns =
                    document.RootElement
                        .GetProperty("choices")[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString();

                lblRaspuns.Text = raspuns;
            }
            catch (Exception ex)
            {
                lblRaspuns.Text = ex.Message;
            }
            finally
            {
                btnIntreaba.Enabled = true;
            }
        }
    }
}