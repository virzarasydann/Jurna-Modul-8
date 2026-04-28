using System.Text.Json.Serialization;

namespace JurnalModul8_103082400034
{
    public class BankTransferConfigModel
    {
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        [JsonPropertyName("transfer")]
        public TransferConfig Transfer { get; set; } = new TransferConfig();

        [JsonPropertyName("methods")]
        public List<string> Methods { get; set; } = new List<string>();

        [JsonPropertyName("confirmation")]
        public ConfirmationConfig Confirmation { get; set; } = new ConfirmationConfig();
    }

    public class TransferConfig
    {
        [JsonPropertyName("threshold")]
        public long Threshold { get; set; }

        [JsonPropertyName("low_fee")]
        public long LowFee { get; set; }

        [JsonPropertyName("high_fee")]
        public long HighFee { get; set; }
    }

    public class ConfirmationConfig
    {
        [JsonPropertyName("en")]
        public string En { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
    }
}