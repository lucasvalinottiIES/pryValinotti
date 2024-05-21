using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace pryValinotti
{
    public class clsAPI
    {
        public void getData(string monstruo, TextBox txtJson)
        {
            try
            {
                string url = $"https://www.dnd5eapi.co/api/monsters/{monstruo}";
                using(var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();
                    var response = client.GetAsync(url).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    dynamic r = JObject.Parse(res);
                    txtJson.Text = r.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
