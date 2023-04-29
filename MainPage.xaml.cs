using MvvmAppClassRef.ViewModels;

namespace MvvmAppClassRef;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        this.Loaded += MainPage_Loaded;
	}

    MainViewModel _vm = new MainViewModel();    
    private void MainPage_Loaded(object sender, EventArgs e)
    {
        this.BindingContext = _vm;
    }
}


