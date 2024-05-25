using System.ComponentModel.DataAnnotations;

namespace BlazorPizzas.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string[] Ingredients { get; set; }

        [Range(1, 99)] public int Price { get; set; }

        [Required] public string ImageName { get; set; }

    }
}
