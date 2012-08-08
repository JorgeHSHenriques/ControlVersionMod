using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace APIRISKMANAGER.Entity
{
    public class ConfToken 
    {
        private string Url { set; get; }
        private string ClienteId { set; get; }
        private string SecretyKey { set; get; }
        private string Grant_type { set; get; }

        public ConfToken()
        {

        }
        public ConfToken(string url, string idCliente, string secretyKey)
        {
            this.ClienteId = idCliente;
            this.SecretyKey = secretyKey;
            this.Url = url;
       
        }
        public void GerarPerimetrosGET(Token token)
        {
            try
            {
                if (token != null)
                {
                    this.Url = "https://mss-rj-378/RM.WebApplication/api/organization/perimeters";
                    WebRequest request = WebRequest.Create(Url);
                    request.Headers.Add("Authorization", "OAuth2 " + token.Access_token);

                    request.ContentLength = 0;
                    request.ContentType = "application/json";
                    request.Method = "GET";

                    WebResponse response = request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    string jsonRead = readStream(stream);
                    string PathPerimetros = readJsonPerimetros(jsonRead);
                    
                }
            }
            catch
            {
                throw;
            }
        }
         public Token GerarTokenPOST(ConfToken token)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += (a, b, c, d) => true;
                token.Grant_type = "client_credentials";

                string urlForm1 = this.Url;

                string urlRequestBody = string.Format("client_id={0}&client_secret={1}&grant_type={2}", this.ClienteId, this.SecretyKey, token.Grant_type);


                byte[] byteLenghtRequestBody = Encoding.UTF8.GetBytes(urlRequestBody);
                WebRequest request = WebRequest.Create(urlForm1);

                request.ContentLength = urlRequestBody.Length;
                request.ContentType = "application/x-www-form-urlencoded";
                request.Method = "POST";
                var dataServer = request.GetRequestStream();
                dataServer.Write(byteLenghtRequestBody, 0, byteLenghtRequestBody.Length);
                WebResponse response = request.GetResponse();
                dataServer.Close();
                Stream dataBaseServer = response.GetResponseStream();
                string json = readStream(dataBaseServer);
                Token tokenCreate = readJsonToken(json);
                return tokenCreate;
            }
            catch
            {
                throw;
            }
        }
         public string readStream(Stream dataBase)
         {
             try
             {
                 StreamReader sr = new StreamReader(dataBase);
                 string dataBaseRead = sr.ReadToEnd();
                 return dataBaseRead;
             }
             catch
             {
                 throw;
             }
         }
         public string readJsonPerimetros(string json)
         {
             Perimetros p = new Perimetros();
             p = JsonConvert.DeserializeObject<Perimetros>(json);
             return p.CreatedBy;
         }
         public Token readJsonToken(string readResponseServer)
         {
             try
             {
                 Token t = new Token();
                 t = JsonConvert.DeserializeObject<Token>(readResponseServer);
                 return t;
             }
             catch
             {
                 throw;
             }
         }

         internal void GerarPerimetrosGET()
         {
             throw new NotImplementedException();
         }
    }
}
