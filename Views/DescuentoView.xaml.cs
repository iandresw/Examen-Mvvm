using Examen_Mvvm.ViewModels;
namespace Examen_Mvvm.Views;

public partial class DescuentoView : ContentPage
{
	private DescuentoViewModel ViewModel;
	public DescuentoView()
	{
		InitializeComponent();
		ViewModel = new DescuentoViewModel();
		BindingContext = ViewModel;
	}
}