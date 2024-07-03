namespace Week92;
using Week92.Models;

public partial class Page3 : ContentPage
{
    private int memorySize = 8;
    private int storageSize = 256;
    private int monitorSize = 24;
    private const double memoryPricePerGB = 10.0; // �rnek fiyatlar, istedi�iniz �ekilde de�i�tirebilirsiniz
    private const double storagePricePerGB = 0.5;
    private const double monitorPricePerInch = 50.0;

    public Page3()
    {
        InitializeComponent();
        InitializeDefaultValues(); // Ba�lang�� de�erlerini ayarla
        UpdateTotalLabel();
    }

    private void InitializeDefaultValues()
    {
        // Ba�lang�� de�erlerini belirle
        Entry_Memory.Text = memorySize.ToString();
        Entry_Storage.Text = storageSize.ToString();
        Entry_Monitor.Text = monitorSize.ToString();

        UpdateTotal(); // Ba�lang�� de�erlerine g�re toplam� g�ncelle
    }
    private void UpdateTotalLabel()
    {
        Label_Total.Text = GlobalViewModel.Instance.Total.ToString("C2");
    }

    private void DecreaseButton1_Clicked(object sender, EventArgs e)
    {
        memorySize /= 2;
        Entry_Memory.Text = memorySize.ToString();
        UpdateTotal();
    }

    private void DecreaseButton2_Clicked(object sender, EventArgs e)
    {
        storageSize /= 2;
        Entry_Storage.Text = storageSize.ToString();
        UpdateTotal();
    }

    private void DecreaseButton3_Clicked(object sender, EventArgs e)
    {
        monitorSize -= 3;
        Entry_Monitor.Text = monitorSize.ToString();
        UpdateTotal();
    }

    private void IncreaseButton1_Clicked(object sender, EventArgs e)
    {
        memorySize *= 2;
        Entry_Memory.Text = memorySize.ToString();
        UpdateTotal();
    }

    private void IncreaseButton2_Clicked(object sender, EventArgs e)
    {
        storageSize *= 2;
        Entry_Storage.Text = storageSize.ToString();
        UpdateTotal();
    }

    private void IncreaseButton3_Clicked(object sender, EventArgs e)
    {
        monitorSize += 3;
        Entry_Monitor.Text = monitorSize.ToString();
        UpdateTotal();
    }

    private void UpdateTotal()
    {
        double memoryPrice = memorySize * memoryPricePerGB;
        double storagePrice = storageSize * storagePricePerGB;
        double monitorPrice = monitorSize * monitorPricePerInch;
        double total = memoryPrice + storagePrice + monitorPrice;
        GlobalViewModel.Instance.Total = total; // GlobalViewModel'deki Total �zelli�ini g�ncelle
        Label_Total.Text = total.ToString("C2");
    }

}