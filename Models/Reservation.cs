namespace HotelBookingMVC.Models
{
    public class Reservation
    {
        public int Id { get; set; } // Klucz główny
        public DateTime StartDate { get; set; } = DateTime.Now; // Domyślna wartość - obecna data
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1); // Domyślna wartość - 1 dzień później
        public int RoomId { get; set; } // Klucz obcy do pokoju
        public Room Room { get; set; } = null!; // Domyślna wartość dla relacji
        public int UserId { get; set; } // Klucz obcy do użytkownika
        public User User { get; set; } = null!; // Domyślna wartość dla relacji
    }
}
