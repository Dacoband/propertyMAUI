using PropertyApp1.ViewModel;

namespace PropertyApp1.View;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
		this.BindingContext = new LandingViewModel();
		(SectionList.Children[0] as RadioButton).IsChecked = true;

	}
}