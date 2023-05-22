using Binance.Net.Objects.Models.Spot.SubAccountData;
using CryptoExchange;
using CryptoExchange.Net.CommonObjects;
using Timer = System.Windows.Forms.Timer;

namespace CryptoApi
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private string binanceSymbolSelected;
        private string byBitSymbolSelected;
        private string kuCoinSymbolSelected;
        private BinanceExchange binanceExchange;
        private ByBitExchange byBitExchange;
        private KuCoinExchange kuCoinExchange;
        public Form1()
        {
            InitializeComponent();
            var items = new object[] { "BTCUSDT", "ETHUSDT" };
            comboBox1.Items.AddRange(items);
            comboBox2.Items.AddRange(items);
            comboBox3.Items.AddRange(items);
            binanceExchange = new BinanceExchange();
            byBitExchange = new ByBitExchange();
            kuCoinExchange = new KuCoinExchange();
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(binanceSymbolSelected))
            {
                var price = binanceExchange.GetPrice(binanceSymbolSelected);
                textBox2.Text = Math.Round(price, 2).ToString();
            }

            if (!string.IsNullOrEmpty(byBitSymbolSelected))
            {
                var price = byBitExchange.GetPrice(byBitSymbolSelected);
                textBox4.Text = Math.Round(price, 2).ToString();
            }

            if (!string.IsNullOrEmpty(kuCoinSymbolSelected))
            {
                var price = kuCoinExchange.GetPrice(kuCoinSymbolSelected);
                textBox6.Text = Math.Round(price, 2).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            binanceSymbolSelected = (sender as ComboBox)?.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            byBitSymbolSelected = (sender as ComboBox)?.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            kuCoinSymbolSelected = (sender as ComboBox)?.SelectedItem.ToString();
        }
    }
}