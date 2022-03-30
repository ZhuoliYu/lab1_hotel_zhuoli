using System.ComponentModel.DataAnnotations;

namespace lab1_hotel_zhuoli.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Key]
        public string RoomNumber { get; set; }

        public int capacity { get; set; }

        public Section Section { get; set; }
    }

    public enum Section
    {
        [Display(Name = "1st")]
        First,
        [Display(Name = "2nd")]
        Second,
        [Display(Name = "3rd")]
        Third
    }
}

