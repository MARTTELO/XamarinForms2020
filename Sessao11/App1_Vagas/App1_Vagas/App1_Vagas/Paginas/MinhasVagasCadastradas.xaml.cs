﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Vagas.Modelos;
using App1_Vagas.Banco;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhasVagasCadastradas : ContentPage
    {
        List<Vagas> Lista { get; set; }
        public MinhasVagasCadastradas()
        {
            InitializeComponent();
            ConsultarVagas();
        }
        private void ConsultarVagas()
        {
            DataBase database = new DataBase();
            Lista = database.Consultar();
            ListarVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString();
        }

        public void EditarAction(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Vagas vaga = tapGest.CommandParameter as Vagas;

            Navigation.PushAsync(new EditarVaga(vaga));
        }
        public void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Vagas vaga = tapGest.CommandParameter as Vagas;

            DataBase database = new DataBase();
            database.Exclusao(vaga);
            ConsultarVagas();
        }
        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListarVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }
    }
}
