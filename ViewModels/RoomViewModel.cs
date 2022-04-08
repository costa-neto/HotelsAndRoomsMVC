using HotelsAndRoomsMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelsAndRoomsMVC.ViewModels
{
    public class RoomViewModel
    {
        public Room room { get; set; }
        public IEnumerable<SelectListItem> hotels { get; set; }
        public Hotel hotel { get; set; }
    }
}
