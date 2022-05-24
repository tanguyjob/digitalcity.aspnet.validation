using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DigitalCity.ASPNET.Validation.Models
{
    public class Dishes
    {
        public int Id { get; set; }

        [DisplayName("Nom")]
        public String? Name { get; set; }

        [DisplayName("Type de plat")]
        public string Type { get; set; }

        public List<String> Ingredients { get; set; }

        public String Description { get; set; }

    }


    public class DishesForm
    {
        [DisplayName("Nom")]
        [Required]
        public String? Name { get; set; }


        [Required]
        [DisplayName("Type de plat")]
        public string Type { get; set; }

        [Required]
        public List<String> Ingredients { get; set; }

        [Required]
        public String Description { get; set; }
    }
}
