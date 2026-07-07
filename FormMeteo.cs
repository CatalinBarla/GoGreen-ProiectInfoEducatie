using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Xml;

namespace GoGreen
{
    public partial class FormMeteo : Form
    {
        public static readonly string apiKey = "22e3e1edb28f67462e3bcbda75785564";
        public static readonly string baseUrl = "https://api.openweathermap.org/data/2.5/";

        public FormMeteo()
        {
            InitializeComponent();
            IncarcaOraseInComboBox();
        }

        private void IncarcaOraseInComboBox()
        {
            string[] orase = new string[]
            {
             "București", "Cluj-Napoca", "Iași", "Constanța", "Timișoara",
             "Brașov", "Craiova", "Galați", "Oradea", "Ploiești",
             "Brăila", "Arad", "Pitești", "Bacău", "Sibiu",
             "Târgu Mureș", "Baia Mare", "Buzău", "Râmnicu Vâlcea", "Suceava",
             "Piatra Neamț", "Drobeta-Turnu Severin", "Bistrița", "Târgu Jiu", "Târgoviște",
             "Focșani", "Alba Iulia", "Satu Mare", "Vaslui", "Botoșani",
             "Tulcea", "Slatina", "Călărași", "Giurgiu", "Voluntari",
             "Popești-Leordeni", "Roman", "Zalău", "Hunedoara", "Slobozia",
             "Alexandria", "Bragadiru", "Bârlad", "Lugoj", "Mediaș",
             "Turda", "Miercurea Ciuc", "Năvodari", "Sighișoara", "Petroșani",
             "Făgăraș", "Mangalia", "Deva", "Odorheiu Secuiesc", "Pașcani",
             "Reșița", "Câmpina", "Dej", "Săcele", "Mioveni",
             "Sighetu Marmației", "Fălticeni", "Huși", "Caransebeș", "Turnu Măgurele",
             "Oltenița", "Câmpulung", "Lupeni", "Codlea", "Vulcan",
             "Rădăuți", "Năsăud", "Sebeș", "Gheorgheni", "Aiud",
             "Chitila", "Blaj", "Târgu Secuiesc", "Târgu Neamț", "Adjud",
             "Buftea", "Dorohoi", "Carei", "Bocșa", "Roșiori de Vede",
             "Urziceni", "Pucioasa", "Breaza", "Pantelimon", "Câmpia Turzii",
             "Vișeu de Sus", "Salonta", "Marghita", "Băicoi", "Calafat",
             "Oravița", "Vatra Dornei", "Luduș", "Sinaia", "Gura Humorului"
            };

            Array.Sort(orase);
            cmbLista.Items.Clear();

            foreach (string oras in orase)
            {
                cmbLista.Items.Add(oras);
            }

            if (cmbLista.Items.Count > 0)
            {
                cmbLista.SelectedIndex = -1;
            }
        }

        private async void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLista.SelectedItem == null) return;

            string orasSelectat = cmbLista.SelectedItem.ToString();
            cmbLista.Enabled = false;

            try
            {
                ActualizeazaVremeaAsync(orasSelectat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la preluarea datelor: {ex.Message}", "Eroare rețea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmbLista.Enabled = true;
            }
        }

        private async void ActualizeazaVremeaAsync(string oras)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; App)");
                    string url = baseUrl + $"weather?q={Uri.EscapeDataString(oras)}&appid={apiKey}&units=metric&lang=ro";
                    string response = await client.GetStringAsync(url);
                    var node = JsonNode.Parse(response);

                    lblOras.Text = oras;
                    lblTemperatura.Text = node["main"]["temp"].ToString() + " °C";
                    lblPresiune.Text = node["main"]["pressure"].ToString() + " hPa";
                    lblUmiditate.Text = node["main"]["humidity"].ToString() + " %";

                    double lat = node["coord"]["lat"].GetValue<double>();
                    double lon = node["coord"]["lon"].GetValue<double>();

                    string svgHtml = await BuildSvgHtmlWithMarkerAsync(client, lat, lon);
                    wbHarta.DocumentText = svgHtml;
                }
            }
            catch (System.Runtime.InteropServices.COMException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> BuildSvgHtmlWithMarkerAsync(HttpClient client, double lat, double lon)
        {
            string svgUrl = "https://ro.wikipedia.org/wiki/Special:FilePath/Fi%C8%99ier:Romania_location_map.svg";
            string svg = await client.GetStringAsync(svgUrl);

            string apiUrl = "https://ro.wikipedia.org/w/api.php?action=query&titles=Template:Location%20map/data/Romania&prop=revisions&rvprop=content&format=json";
            string apiResponse = await client.GetStringAsync(apiUrl);

            double left = double.NaN, right = double.NaN, top = double.NaN, bottom = double.NaN;
            var m = Regex.Matches(apiResponse, @"(?m)^\s*(left|right|top|bottom)\s*=\s*([0-9\.\-]+)");
            foreach (Match match in m)
            {
                string key = match.Groups[1].Value.ToLowerInvariant();
                double val = double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
                switch (key)
                {
                    case "left": left = val; break;
                    case "right": right = val; break;
                    case "top": top = val; break;
                    case "bottom": bottom = val; break;
                }
            }
            if (double.IsNaN(left) || double.IsNaN(right) || double.IsNaN(top) || double.IsNaN(bottom))
            {
                left = 20.26; right = 29.75; top = 48.6; bottom = 43.35;
            }

            var xml = new XmlDocument();
            xml.LoadXml(svg);
            var svgNode = xml.DocumentElement;

            double vbMinX = 0, vbMinY = 0, vbW = 0, vbH = 0;
            string viewBox = svgNode.GetAttribute("viewBox");
            if (!string.IsNullOrEmpty(viewBox))
            {
                var parts = viewBox.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length >= 4)
                {
                    vbMinX = double.Parse(parts[0], CultureInfo.InvariantCulture);
                    vbMinY = double.Parse(parts[1], CultureInfo.InvariantCulture);
                    vbW = double.Parse(parts[2], CultureInfo.InvariantCulture);
                    vbH = double.Parse(parts[3], CultureInfo.InvariantCulture);
                }
            }

            if (vbW == 0 || vbH == 0)
            {
                var wAttr = svgNode.GetAttribute("width").Replace("px", "");
                var hAttr = svgNode.GetAttribute("height").Replace("px", "");
                if (!string.IsNullOrEmpty(wAttr) && !string.IsNullOrEmpty(hAttr))
                {
                    vbW = double.Parse(wAttr, CultureInfo.InvariantCulture);
                    vbH = double.Parse(hAttr, CultureInfo.InvariantCulture);
                    vbMinX = 0;
                    vbMinY = 0;
                }
            }

            if (vbW == 0 || vbH == 0)
            {
                vbW = 800; vbH = 1000; vbMinX = 0; vbMinY = 0;
            }

            double x = vbMinX + (lon - left) / (right - left) * vbW;
            double y = vbMinY + (top - lat) / (top - bottom) * vbH;

            var ns = svgNode.NamespaceURI;
            XmlElement circle = xml.CreateElement("circle", ns);
            circle.SetAttribute("cx", x.ToString(CultureInfo.InvariantCulture));
            circle.SetAttribute("cy", y.ToString(CultureInfo.InvariantCulture));
            circle.SetAttribute("r", "16");
            circle.SetAttribute("fill", "#e53935");
            circle.SetAttribute("stroke", "#ffffff");
            circle.SetAttribute("stroke-width", "2");
            svgNode.AppendChild(circle);

            svgNode.SetAttribute("width", "100%");
            svgNode.SetAttribute("height", "100%");
            svgNode.SetAttribute("preserveAspectRatio", "xMidYMid meet"); 

            string wrapped = @"<!DOCTYPE html>
            <html>
            <head>
             <meta http-equiv='X-UA-Compatible' content='IE=Edge'>
            <style>
              html, body { height: 100%; margin: 0; padding: 0; overflow: hidden; }
             svg { width: 100%; height: 100%; display: block; }
             </style>
            </head>
            <body>" +
                   xml.OuterXml +
                   "</body></html>";
            return wrapped;
        }

        private void btniesire_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
