using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelsAndRoomsMVC.Models
{
    public class Room : IValidatableObject
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [ForeignKey("Hotel")]
        [Display(Name = "Hotel")]
        public string HotelId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Num. of Occupants")]
        public int NumOccupants { get; set; }
        [Required]
        [Display(Name = "Num. of Adults")]
        public int NumAdults { get; set; }
        [Required]
        [Display(Name = "Num. Of Children")]
        public int NumChildren { get; set; }
        [Required]
        public decimal Price { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (NumOccupants != (NumChildren + NumAdults))
            {
                yield return new ValidationResult(
                    $"The number of occupants must be equal to the sum of number of children and number of adults.",
                    new[] { nameof(NumOccupants) });
            }
        }

    }
}
