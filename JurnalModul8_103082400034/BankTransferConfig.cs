using System.Text.Json;

namespace JurnalModul8_103082400034
{
    public class BankTransferConfig
    {
        private const string ConfigFileName = "bank_transfer_config.json";
        private BankTransferConfigModel _config = new BankTransferConfigModel();

        public string Lang => _config.Lang;
        public long Threshold => _config.Transfer.Threshold;
        public long LowFee => _config.Transfer.LowFee;
        public long HighFee => _config.Transfer.HighFee;
        public List<string> Methods => _config.Methods;
        public string ConfirmationEn => _config.Confirmation.En;
        public string ConfirmationId => _config.Confirmation.Id;

        public BankTransferConfig()
        {
            LoadConfig();
        }

        public void LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigFileName))
                {
                    string jsonString = File.ReadAllText(ConfigFileName);
                    _config = JsonSerializer.Deserialize<BankTransferConfigModel>(jsonString)
                              ?? GetDefaultConfig();
                }
            }
            catch
            {
                
            }

            
            if (_config == null || string.IsNullOrEmpty(_config.Lang))
            {
                _config = GetDefaultConfig();
            }
        }

        private BankTransferConfigModel GetDefaultConfig()
        {
            return new BankTransferConfigModel
            {
                Lang = "en",
                Transfer = new TransferConfig
                {
                    Threshold = 25000000,
                    LowFee = 6500,
                    HighFee = 15000
                },
                Methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                Confirmation = new ConfirmationConfig
                {
                    En = "yes",
                    Id = "ya"
                }
            };
        }
    }
}