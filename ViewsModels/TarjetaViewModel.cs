﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ValorantShop.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantShop.ViewsModels
{
    public partial class TarjetaViewModel : ObservableObject
    {
        private readonly ValorantShopDbContext _context;
        [ObservableProperty]
        public string numeroTarjeta;
        [ObservableProperty]
        public string nombreTarjeta;
        [ObservableProperty]
        public string mes;
        [ObservableProperty]
        public string anio;
        [ObservableProperty]
        public string cvv;

        [RelayCommand]
        async Task GuardarEvent()
        {

            if (string.IsNullOrEmpty(NombreTarjeta) ||
               string.IsNullOrEmpty(NumeroTarjeta) ||
               string.IsNullOrEmpty(Mes) ||
               string.IsNullOrEmpty(Anio) ||
               string.IsNullOrEmpty(Cvv)
               )
            {
                await Shell.Current.DisplayAlert("Mensaje", "Debe ingresar todos los campos", "Aceptar");
                return;
            }
            _context.Tarjetas.Add(new ValorantShop.Modelos.Tarjeta
            {
                NombreTarjeta = NombreTarjeta,
                NumeroTarjeta = NumeroTarjeta,
                Mes = Mes,
                Anio = Anio,
                Cvv = Cvv
            });

            await _context.SaveChangesAsync();
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async Task GetBackEvent()
        {
            await Shell.Current.GoToAsync("..");
        }

        public TarjetaViewModel(ValorantShopDbContext contex)
        {
            _context = contex;
        }
    }
}
