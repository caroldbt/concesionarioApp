using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concesionarioApp
{
    class BaseDeDatos
    {
        public static string inforPhp(string url)
        {
            string response = "Incorrecto";
            var httpClient = new HttpClient();

            string contentType = "application/json";
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var userAgent = "d-fens HttpClient";
            httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
            try
            {
                response = httpClient.GetStringAsync(new Uri(url)).Result;
            }
            catch (WebException exception) {
                MessageBox.Show(exception.ToString());
                
            }
            catch (SocketException socket) {
                MessageBox.Show(socket.ToString());
            }
            catch (HttpRequestException http) {
                MessageBox.Show(http.ToString());
            }
            return response;
        }

    }
}
