using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.IO;
/*
using System.Text.Json;
using System.Text.Json.Serialization;
*/
namespace JuegoRol
{
    static class Program
    {
        
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<string> namePersonajes = new List<string>();
            Application.Run(new CrearPlayer(namePersonajes));
        }

    }


        /*
        private static List<string> GetApi()
        {
            var url = $"https://pokeapi.co/api/v2/pokemon";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            List<string> listajugadores = new List<string>();

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return listajugadores;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            Personajes_json pokemones = JsonSerializer.Deserialize<Personajes_json>(responseBody);

                            foreach (Result pokemon in pokemones.Results)
                            {
                                listajugadores.Add(pokemon.Name);
                            }

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }

            return listajugadores;
        }

        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Result
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }

        public class Personajes_json
        {
            [JsonPropertyName("count")]
            public int Count { get; set; }

            [JsonPropertyName("next")]
            public string Next { get; set; }

            [JsonPropertyName("previous")]
            public object Previous { get; set; }

            [JsonPropertyName("results")]
            public List<Result> Results { get; set; }
        }
    }*/
}

