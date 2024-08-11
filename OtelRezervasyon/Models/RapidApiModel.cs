namespace OtelRezervasyon.Models
{
    public class RapidApiModel
    {
        public int geoId { get; set; }
        public int locationId { get; set; }
        public string localizedName { get; set; }
        public string localizedAdditionalNames { get; set; }
        public string locationV2 { get; set; }
        public string placeType { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public bool isGeo { get; set; }
    }

    public class RapidApiResponseModel
    {
        public string Status { get; set; } // Örnek için status alanı
        public List<RapidApiModel> Data { get; set; }
    }
}
