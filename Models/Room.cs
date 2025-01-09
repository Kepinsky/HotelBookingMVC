namespace HotelBookingMVC.Models
{
    public class Room
    {
        public int Id { get; set; } // Klucz główny
        public string Name { get; set; } = string.Empty; // Domyślna wartość - pusty ciąg
        public int Capacity { get; set; } = 1; // Domyślna wartość - minimalna pojemność
        public decimal PricePerNight { get; set; } = 0.0m; // Domyślna wartość - 0.0
        public int HotelId { get; set; } // Klucz obcy do Hotelu
        public Hotel Hotel { get; set; } = null!; // Domyślna wartość dla relacji
    }
}
