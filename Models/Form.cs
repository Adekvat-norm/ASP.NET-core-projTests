using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Form
    {
        [Display(Name="Имя")]
        [Required(ErrorMessage ="Заполните поле Имя")]
        public string Name { get; set; }

        [Display(Name = "Дата покупки")]
        [Required(ErrorMessage = "Заполните поле Дата покупки")]
        public DateTime DatePuchase { get; set; }

        [Display(Name = "Цена покупки")]
        [Required(ErrorMessage = "Заполните поле Цена покупки")]
        public int Price { get; set; }

        [Display(Name = "Производитель")]
        [Required(ErrorMessage = "Заполните поле Производитель")]
        public string Manufacturer { get; set; }

        [Display(Name = "Количество купленных товаров")]
        [Required(ErrorMessage = "Заполните поле Количество купленных товаров")]
        public int Quantity_purchase { get; set; }
    }
}
