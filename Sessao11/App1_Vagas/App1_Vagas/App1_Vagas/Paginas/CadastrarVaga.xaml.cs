using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Modelos;
using App1_Vagas.Banco;
namespace App1_Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastrarVaga : ContentPage
    {
        public CadastrarVaga()
        {
            InitializeComponent();

        }

      public void SalvarAction(Object sender, EventArgs args)
        {
            //TODO - Obter dados da tela

            Vagas vaga = new Vagas();
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = Double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT" ;
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;


            //TODO - Salvar dados no banco

            DataBase database = new DataBase();
            database.Cadastro(vaga);


            //TODO - VOltar para tela de pesqusia
            App.Current.MainPage = new NavigationPage(new ConsultarVagas());
        }
    }
}