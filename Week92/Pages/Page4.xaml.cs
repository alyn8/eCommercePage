namespace Week92;
using Week92.Models;


public partial class Page4 : ContentPage
{
    public Page4()
    {
        InitializeComponent();
        UpdateTotalLabel();
    }

    private void UpdateTotalLabel()
    {
        Entry_Total.Text = GlobalViewModel.Instance.Total.ToString("C2");
    }

    private void ButtonPay_Clicked(object sender, EventArgs e)
    {

    }
}
