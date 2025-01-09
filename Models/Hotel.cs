using System.ComponentModel.DataAnnotations;

namespace HotelBookingMVC.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Range(1, 1000, ErrorMessage = "Rooms Available must be between 1 and 1000")]
        public int RoomsAvailable { get; set; }


        // Default constructor
        public Hotel()
        {
            // Set default values to avoid warnings
            Name = string.Empty;
            Location = string.Empty;
        }
    }
}
