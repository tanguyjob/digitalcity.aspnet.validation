using DigitalCity.ASPNET.Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalCity.ASPNET.Validation.Controllers
{
    public class DishesController : Controller
    {

        #region Static data
        private static ICollection<Dishes> _Dishes = new List<Dishes>()
        {
            new Dishes {Id=1,Name="Borsch",Type="plat principale",Ingredients=new List<String> { "Betterave","pomme de terre","saucisse"}, Description="soupe" },
            new Dishes {Id=2,Name="Okonomiyaki",Type="plat principale",Ingredients=new List<String> { "oeuf","pomme de terre","choux"},Description="Omelette" },
            new Dishes {Id=3,Name="Sushi",Type="plat principale",Ingredients=new List<String> { "Riz","Saumon","avocat"},Description="poisson enroullé de riz" },

        };



        #endregion
        public IActionResult Index()
        {
            return View(_Dishes);
        }

        [Route("/Dishes/Detail/{id}")]
        public IActionResult Detail(int id)
        {
            Dishes dish= _Dishes.SingleOrDefault(d => d.Id==id);

            return View(dish);
        }

        public IActionResult Add(DishesForm dishesForm)
        {
            return View(new DishesForm());
        }
    }
}
