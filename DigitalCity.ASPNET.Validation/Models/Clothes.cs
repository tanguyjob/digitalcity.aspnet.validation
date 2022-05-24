using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DigitalCity.ASPNET.Validation.Models
{
    public enum ClothesSize
    {
        XXS,XS,S,M,L, XL, XXL
    }
    public class Clothes
    {
        public int Id { get; set; }

        [DisplayName("Nom")]
        public string Name { get; set; }

        [DisplayName("Couleur")]
        public string Color { get; set; }

        [DisplayName("taille")]
        public ClothesSize Size { get; set; }

        [DisplayName("température de lavage")]
        [DisplayFormat(DataFormatString= " {0:F}  °C")]
        public int WashTemp { get; set; }
        [DisplayName("séchoir autorisé")]

        public bool DryerAllow { get; set; }

        [DisplayName("Prix")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }


    public class ClothesForm
    {
        [DisplayName("Nom")]
        [Required]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DisplayName("Couleur")]
        [Required]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string Color { get; set; }

        [DisplayName("taille")]
        [Required]
       
        public ClothesSize Size { get; set; }

        [DisplayName("température de lavage")]
        [Required]
        [Range(0,90)]
        [DataType(DataType.Text)]
        public int WashTemp { get; set; }


        [DisplayName("séchoir autorisé")]
        [Required]
        public bool DryerAllow { get; set; }


        [DisplayName("Prix")]
        [Required]
        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

    }



}
