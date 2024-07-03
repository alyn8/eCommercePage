namespace Week92;
using Week92.Models;

public partial class Page2 : ContentPage
{
    private double cpuPrice = 0;
    private double storagePrice = 0;

    public Page2()
    {
        InitializeComponent();
        InitializeRadioButtons();
        UpdateTotal();
    }

    private void InitializeRadioButtons()
    {
        Radio_i3.CheckedChanged += RadioButton_CheckedChanged;
        Radio_i5.CheckedChanged += RadioButton_CheckedChanged;
        Radio_i7.CheckedChanged += RadioButton_CheckedChanged;
        Radio_i9.CheckedChanged += RadioButton_CheckedChanged;

        Radio_SSD.CheckedChanged += RadioButton_CheckedChanged;
        Radio_HDD.CheckedChanged += RadioButton_CheckedChanged;
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender == Radio_i3 && e.Value)
            cpuPrice = 100;
        else if (sender == Radio_i5 && e.Value)
            cpuPrice = 200;
        else if (sender == Radio_i7 && e.Value)
            cpuPrice = 300;
        else if (sender == Radio_i9 && e.Value)
            cpuPrice = 400;

        if (sender == Radio_SSD && e.Value)
            storagePrice = 0.5;
        else if (sender == Radio_HDD && e.Value)
            storagePrice = 0.2;

        UpdateTotal(); // Seçim yapýldýðýnda toplamý güncelle
    }

    private void UpdateTotal()
    {
        double total = cpuPrice + storagePrice;
        GlobalViewModel.Instance.Total = total;
    }
}