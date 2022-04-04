using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelsAndRoomsMVC.Models
{
    public class Room
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [ForeignKey("Hotel")]
        public string HotelId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int NumOccupants { get; set; }
        [Required]
        public int NumAdults { get; set; }
        [Required]
        public int NumChildren { get; set; }
        [Required]
        public decimal Price { get; set; }

    }
}
