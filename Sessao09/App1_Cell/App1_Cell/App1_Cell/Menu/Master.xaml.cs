using App1_Cell.Pagina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        public void GoPagina1 (Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.TextCellPAge());
            IsPresented = false;
        }

        public void GoPagina2(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ImageCellPage());
            IsPresented = false;
        }

        public void GoPagina3(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.EntryCellPage());
            IsPresented = false;
        }

        public void GoPagina4(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.SwitchCellPage());
            IsPresented = false;
        }


        public void GoPagina5(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ViewCellPage());
            IsPresented = false;
        }


        public void GoPagina6(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ListViewPage());
            IsPresented = false;
        }

        public void GoPagina7(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pagina.ListViewButtonPage());
            IsPresented = false;
        }



    }

}