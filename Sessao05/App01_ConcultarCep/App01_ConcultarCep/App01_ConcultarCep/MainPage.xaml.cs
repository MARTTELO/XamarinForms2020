using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConcultarCep.Servico.Modelo;
using App01_ConcultarCep.Servico;


namespace App01_ConcultarCep
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //To do - Logica do Programa
            string cep = CEP.Text.Trim();

            if (isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {0}, {1}/{2}", end.logradouro, end.localidade, end.uf);
                    }
                    else
                    {
                        DisplayAlert("Erro", "Não foi encontrado endereço pro CEP informado: " + cep,"OK");
                    }
                   
                }
                catch (Exception ex)
                {
                    DisplayAlert("ERRO CRÍTICO:", ex.Message, "OK");
                   
                }
                
            }
      

        }

        private bool isValidCEP(string cep)
        {

            bool valido = true;

            //if(cep.Length != 8)
            //{
            //    //ERRO
            //    DisplayAlert("Erro", "Cep inválido! O Cep deve ter 8 caracteres","OK");
            //    valido = false;
            //}
        
            int NovoCEP = 0;

            if(!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("Erro", "Cep inválido! O Cep deve ser numérico", "OK");
                valido = false;
            }
            return valido;

        }
    }
}
