using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XCommas.Net.Objects
{
    public class SimpleTradeData
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }
        [JsonProperty("units_to_buy")]
        public decimal Units { get; set; }
        [JsonProperty("buy_price")]
        public decimal Price { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("buy_method")]
        public SimpleTradeMethod TradeMethod { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }


    }


    #region "Version2 Defs"
    public class SimpleTradeDataVer2
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("pair")]
        public string Pair { get; set; }

        public bool Instant { private get; set; }

        [JsonProperty("instant")]
        public string instant => Instant.ToString();

        [JsonProperty("position")]
        public Position Position { get; set; }
    }


    public class Position
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public EntryType Type { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }

        [JsonProperty("units")]
        public Units Units { get; set; }
    }
    public class Units
    {

        [JsonProperty("value")]

        public decimal Value { get; set; }

    }


    public enum EntryType { buy, sell }

    public enum OrderType { market, limit, stop }



    #endregion







}
