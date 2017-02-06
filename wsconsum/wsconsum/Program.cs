using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace wsconsum
{
    
        class Program
        {
        //localhost:4962
        private static readonly String ws1 = "http://localhost:4962/api/contacte/";
            static void Main(string[] args)
            {
                Program p = new Program();
                p.List(0, 60);
            }

            void List(int first, int last)
            {
                for (int i = first; i < last; i++)
                {
                    String jsonStr = this.GET(string.Concat(ws1, i));
                    JsonSerializerSettings prop = new JsonSerializerSettings();
                    contacte c = JsonConvert.DeserializeObject<contacte>(jsonStr, prop);
                    if (c != null)
                    {
                        Console.WriteLine("Id= {0};  Nom i cognoms: {1}-{2}", c.contacteId, c.nom, c.cognoms);
                    }
                }
                Console.ReadLine();
            }

            string GET(string url)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                try
                {
                    WebResponse response = request.GetResponse();
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        return reader.ReadToEnd();
                    }
                }
                catch (WebException ex)
                {
                    WebResponse errorResponse = ex.Response;
                    using (Stream responseStream = errorResponse.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                        String errorText = reader.ReadToEnd();
                        // log errorText
                    }
                    throw;
                }
            }
        }
    }