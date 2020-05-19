using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Cell.modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextCellPAge : ContentPage
    {
        public TextCellPAge()
        {
            InitializeComponent();
            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome="Jose", Cargo="Presidente"});
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }
    }
}