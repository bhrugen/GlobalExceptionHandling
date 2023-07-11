namespace WhatsWrongAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int VillaId { get; set; }
        public int TotalPrice { get; set; }
        public int TotalNights { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime BookingDate { get; set; }
        public string Comment { get; set; }
    }
}
