using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Examen_Mvvm.Models;

namespace Examen_Mvvm.ViewModels
{
    public partial class DescuentoViewModel: ObservableObject
    {
        [ObservableProperty]
        private decimal producto1;

        [ObservableProperty]
        private decimal producto2;

        [ObservableProperty]
        private decimal producto3;

        [ObservableProperty]
        private decimal subtotal;

        [ObservableProperty]
        private decimal descuento;

        [ObservableProperty]
        private decimal total;

        [RelayCommand]
        public void Calcular()
        {
            var model = new DescuentoModel
            {
                Producto1 = Producto1,
                Producto2 = Producto2,
                Producto3 = Producto3
            };

            Subtotal = model.Subtotal;
            Descuento = model.Descuento;
            Total = model.Total;
        }
        [RelayCommand]
        public void Limpiar()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }
    }

}
