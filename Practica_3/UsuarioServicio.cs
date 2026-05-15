using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Practica_3
{
    public class UsuarioServicio: IUsuarioServicio
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<Usuario> GetUserAsync()
        {
            string url = "https://randomuser.me/api/";

            try
            {
                HttpResponseMessage response =
                    await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string json =
                    await response.Content.ReadAsStringAsync();

                APIResponse data =
                    JsonSerializer.Deserialize<APIResponse>(
                        json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                return data.Results[0];
            }
            catch
            {
                Console.WriteLine("Error obteniendo usuario.");
                return null;
            }
        }
    }
}
