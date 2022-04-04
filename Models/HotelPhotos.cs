using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelsAndRoomsMVC.Models
{
    public class HotelPhotos
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Image { get; set; }
    }
}