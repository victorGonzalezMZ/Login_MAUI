using Login_MAUI.Helpers;
using Login_MAUI.Interfaces;
using Login_MAUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Login_MAUI.Services
{
    public class LoginService : ILogin
    {

        HttpClient client;
        string WebAPIUrl = string.Empty;

        public LoginService()
        {
            client = new HttpClient();
        }

        public async Task<Login> Authenticate(UserMin user)
        {
            await Task.Delay(1000);
            user.Password = Functions.GetSHA256(user.Password).ToUpper();


            WebAPIUrl = "http://189.254.239.133/LoginAppApi/api/login/autenticar";

            var uri = new Uri(WebAPIUrl);

            try
            {
                HttpContent _content = new StringContent(JsonConvert.SerializeObject(user));
                _content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                var response = await client.PostAsync(uri, _content);

                if (response.IsSuccessStatusCode)
                {
                    Login login = new Login();
                    var content = await response.Content.ReadAsStringAsync();
                    login = JsonConvert.DeserializeObject<Login>(content);
                    return login;
                }
            }
            catch (Exception ex){
                throw new Exception(ex.Message, ex);
            }

            return null;
        }

    }
}
