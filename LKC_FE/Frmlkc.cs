using System;
using System.Net;
using Wisej.Web;
using System.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web;

namespace LKC_FE
{
    public partial class frmlkc : Form
    {
        private static HttpClient httpClient = new HttpClient();
    
        public frmlkc()
        {
            InitializeComponent();
        }

        private async void getlistbook(string tagsearch)
        {
            
            string baseURLAPI = ConfigurationManager.AppSettings["webapi_url"];
            //var myUsri = $"{baseURLAPI}/api/buku";
            var myUsri = $"{baseURLAPI}/api/buku?txtsearch={Uri.EscapeDataString(tagsearch)}";
            var response = await httpClient.GetAsync(myUsri);
            /*
            string baseURLAPI = ConfigurationManager.AppSettings["webapi_url"];
            var builder = new UriBuilder($"{baseURLAPI}/api/buku");
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["txtsearch"] = this.tagsearch.Text;
            builder.Query = query.ToString();
            string myUsri = builder.ToString();
            var response = await httpClient.GetAsync(myUsri);
            */
            if (response.StatusCode == HttpStatusCode.OK)
            {

                string responseContent = await response.Content.ReadAsStringAsync();
                var bukuList = JsonConvert.DeserializeObject<List<BukuModel>>(responseContent);
                var dataSource = new BindingList<BukuModel>(bukuList);

                //dataRepeater1.DataSource = dataSource;
                //this.namaBuku.DataBindings.Add("Text", responseContent, "namaBuku");
                //this.imageCoverBuku.DataBindings.Add("ImageSource", dataSource, @"images/" + "imageCoverBuku");
                // Hapus semua binding yang ada terlebih dahulu
                foreach (Control control in dataRepeater1.ItemTemplate.Controls)
                {
                    if (control is Label label)
                    {
                        label.DataBindings.Clear();
                    }
                    else if (control is PictureBox pictureBox)
                    {
                        pictureBox.DataBindings.Clear();
                    }
                }

                foreach (Control control in dataRepeater1.ItemTemplate.Controls)
                {
                    if (control is Label && control.Name == "namaBuku")
                    {
                        ((Label)control).DataBindings.Add("Text", dataSource, "namaBuku");
                    } else if (control is PictureBox && control.Name == "imageCoverBuku")
                    {
                        ((PictureBox)control).DataBindings.Add("ImageSource", dataSource, "imageCoverBuku", true);
                    }
                    else if (control is Label && control.Name == "description")
                    {
                        ((Label)control).DataBindings.Add("Text", dataSource, "description");
                    }
                    else if (control is Label && control.Name == "tahunTerbit")
                    {
                        ((Label)control).DataBindings.Add("Text", dataSource, "tahunTerbit");
                    }
                    else if (control is Label && control.Name == "authorby")
                    {
                        ((Label)control).DataBindings.Add("Text", dataSource, "authorBy");
                    }

                }

                dataRepeater1.DataSource = dataSource;
                dataRepeater1.Refresh();
                Application.Update(this);
                return;
            }
            
      
        }

        public class BukuModel
        {
            public string namaBuku { get; set; }
            public string imageCoverBuku { get; set; }
            public string authorBy { get; set; }
            public int tahunTerbit { get; set; }
            public string description { get; set; }

        }

        private void frmlkc_Load(object sender, EventArgs e)
        {

        }

        private void frmlkc_Appear(object sender, EventArgs e)
        {
            this.getlistbook("");
        }

         private void btnSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.txtsearch.Text);
            getlistbook(this.txtsearch.Text);
        }
    }
}
