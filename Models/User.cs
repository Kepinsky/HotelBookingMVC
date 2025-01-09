namespace HotelBookingMVC.Models
{
    public class User
    {
        public int Id { get; set; } // Klucz główny
        public string Name { get; set; } = string.Empty; // Domyślna wartość - pusty ciąg
        public string Email { get; set; } = string.Empty; // Domyślna wartość - pusty ciąg
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>(); // Domyślna wartość - pusta lista
    }
}
