using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ApiService.App_Start
{
    /// <summary>
    /// Clase para el manejo de los permisos de las peticiones de clientes fuera del dominio
    /// </summary>
    public class CorsMessageHandler : DelegatingHandler
    {
        protected async override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            if (request.Headers.Contains("Origin"))
            {
                bool darAcceso = false;
                var response = await base.SendAsync(request, cancellationToken);
                //string host = request.Headers.GetValues("Origin").Single(a => a.Equals("c5363"));
                IEnumerable<string> hosts = request.Headers.GetValues("Origin");

                foreach (string item in hosts)
                {
                    switch (item.ToUpper())
                    {
                        case "HTTP://C5363":
                            darAcceso = true;
                            break;
                        case "HTTP://LOCALHOST":
                            darAcceso = true;
                            break;
                        default:
                            break;
                    }
                }

                if (darAcceso)
                {
                    response.Headers.Add("Access-Control-Allow-Origin", request.Headers.GetValues("Origin"));
                }

                return response;
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}