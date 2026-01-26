using Avalonia.Controls;
using System.Linq;
using Avalonia.Interactivity;
using Avalonia.Media;
using System.Net.Http;
using Avalonia.Animation;
using System;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace PriceConvertor;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public class ExchangeRateResponse
    {
        [JsonPropertyName("result")]
        public string Result { get; set; } = string.Empty;

        [JsonPropertyName("documentation")]
        public string Documentation { get; set; } = string.Empty;

        [JsonPropertyName("terms_of_use")]
        public string TermsOfUse { get; set; } = string.Empty;

        [JsonPropertyName("time_last_update_unix")]
        public long TimeLastUpdateUnix { get; set; }

        [JsonPropertyName("time_last_update_utc")]
        public string TimeLastUpdateUtc { get; set; } = string.Empty;

        [JsonPropertyName("time_next_update_unix")]
        public long TimeNextUpdateUnix { get; set; }

        [JsonPropertyName("time_next_update_utc")]
        public string TimeNextUpdateUtc { get; set; } = string.Empty;

        [JsonPropertyName("base_code")]
        public string BaseCode { get; set; } = string.Empty;

        [JsonPropertyName("target_code")]
        public string TargetCode { get; set; } = string.Empty;

        [JsonPropertyName("conversion_rate")]
        public double ConversionRate { get; set; }

        [JsonPropertyName("conversion_result")]
        public double ConversionResult { get; set; }
    }
    public async void ConvertHandler(object sender, RoutedEventArgs args)
    {

        if (!double.TryParse(SumBox.Text, out double amount))
        {
            ConvertedPriceBox.Text = "Invalid sum";
            return;
        }

        var fromItem = CurrencyToConvertFromComboBox.SelectedItem as ComboBoxItem;
        var toItem = CurrencyToConvertComboBox.SelectedItem as ComboBoxItem;

        string fromCurrency = (CurrencyToConvertFromComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "USD";
        string toCurrency = (CurrencyToConvertComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "EUR";


        double convertedValue = await GetPriceconvertorAsync(fromCurrency, toCurrency, amount);

        // Console.WriteLine("Value: " + amount);
        // Console.WriteLine("From currency: " + fromCurrency);
        // Console.Write("To currency: " + toCurrency);
        // Console.Write("final amount: " + convertedValue);

        ConvertedPriceBox.Text = convertedValue + " " + toCurrency;


    }

    private async Task<double> GetPriceconvertorAsync(String fromCurrency, String toCurrency, double amount)
    {
        using HttpClient client = new HttpClient();

        string url = $"https://v6.exchangerate-api.com/v6/4ee637a56f3fba6838eda54f/pair/{fromCurrency}/{toCurrency}/{amount}";


        using HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        string jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine(jsonResponse);

        var data = JsonSerializer.Deserialize<ExchangeRateResponse>(jsonResponse);
        return data?.ConversionResult ?? 0.0;

    }
}