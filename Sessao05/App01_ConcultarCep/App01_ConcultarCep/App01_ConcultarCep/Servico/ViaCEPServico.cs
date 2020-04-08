using System;
using System.Collections.Generic;
using System.Text;
using App01_ConcultarCep.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConcultarCep.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoUrl = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoUrl = string.Format(EnderecoUrl, cep);

            System.Net.WebClient wc = new System.Net.WebClient();

            string Conteudo = wc.DownloadString(NovoEnderecoUrl);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null) return null;
           
            return end;
        }
    }
}
