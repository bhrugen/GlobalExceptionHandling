namespace WhatsWrongAPI.Models
{
    public class VillaSummaryVM
    {
        public int VillaCount { get; set; }
        public double VillaAverage { get; set; }
        public double PriceDiff { get; set; }
        public Villa RandomVilla { get; set; }
        public string VillaIdList { get; set; }
    }
}
