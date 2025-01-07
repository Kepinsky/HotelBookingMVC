namespace HotelBookingMVC.Models
{
    public class Hotel
    {
        // Identyfikator hotelu (Primary Key)
        public int Id { get; set; }

        // Nazwa hotelu
        public string Name { get; set; }

        // Lokalizacja hotelu
        public string Location { get; set; }

        // Liczba dostępnych pokoi
        public int RoomsAvailable { get; set; }

        // Konstruktor domyślny
        public Hotel()
        {
            // Ustawienie domyślnych wartości, aby uniknąć ostrzeżeń
            Name = string.Empty;
            Location = string.Empty;
        }
    }
}
