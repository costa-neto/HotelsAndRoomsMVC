using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelsAndRoomsMVC.Models
{
    public class Hotel
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        public ICollection<Room>? Rooms { get; set; }
        public ICollection<HotelPhotos>? Photos { get; set; }

    }
}
