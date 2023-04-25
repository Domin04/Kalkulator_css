using Kalkulator.models;


namespace Kalkulator;

public partial class HistoryPage : ContentPage
{
    public ICalculatorData CalculatorData = DependencyService.Get<ICalculatorData>();

   
    public HistoryPage()
	{
		InitializeComponent();
        HistoryList.ItemsSource = CalculatorData.operation; 

    }
    
    
}