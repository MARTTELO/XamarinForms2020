using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Cell.modelo;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Jose", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void ItemSelecionadoAction(Object sender,SelectedItemChangedEventArgs args)
        {
            Funcionario func = (Funcionario)args.SelectedItem;
            Navigation.PushAsync(new Detalhe.DetailPage(func)); ;
        }

        private void FeriasAction(Object sender, EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("Titulo: " + func.Nome, "Mensagem: " + func.Nome + " - " + func.Cargo, "ok");
        }

        private void AbonoAction(Object sender, EventArgs args)
        {

        }
    }
}