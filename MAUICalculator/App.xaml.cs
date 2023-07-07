using MAUICalculator.MVVM.Views;

namespace MAUICalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Dark;
        MainPage = new CalculatorView();
	}
}
