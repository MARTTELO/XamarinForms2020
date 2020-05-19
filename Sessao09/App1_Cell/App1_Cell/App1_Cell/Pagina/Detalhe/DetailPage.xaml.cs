using App1_Cell.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina.Detalhe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Funcionario Funcionario)
        {
            InitializeComponent();

            TxtNome.Text = Funcionario.Nome;
        }
    }
}