using System.ComponentModel.DataAnnotations;
//added so that we can decorate the properties of our class with attributes.

namespace NorthwindMvc.Models
{
    public class Thing
    {
        // now we can add attributes. in this case we are using validation attributes. 
        [Range(1, 10)]
        public int? ID { get; set; }

        [Required]
        public string Color { get; set; }
    }
}

