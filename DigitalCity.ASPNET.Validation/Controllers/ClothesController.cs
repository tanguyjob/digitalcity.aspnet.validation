using DigitalCity.ASPNET.Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalCity.ASPNET.Validation.Controllers
{
    public class ClothesController : Controller
    {

        #region data
        private static ICollection<Clothes> _Clothes = new List<Clothes>()
        {
            new Clothes{ Id=1, Name="Test", Color="Cyan",Size=ClothesSize.M, WashTemp=30, DryerAllow=false, Price =42},
            new Clothes{ Id=2, Name="T-shirt",Color="Black", Size=ClothesSize.S, WashTemp=45, DryerAllow=true, Price =23.99}
        };

        #endregion

        public static int _LastId = 2;

        public IActionResult Index()
        {
            return View(_Clothes);
        }



        
        public IActionResult Add()
        {
            return View(new ClothesForm());            
        }

        [HttpPost]
        public IActionResult Add(Clothes clothesForm)
        {
            if (!ModelState.IsValid)
            {
                return View(clothesForm);
            }

            _Clothes.Add(new Clothes()
            {
                Id = ++_LastId,
                Name = clothesForm.Name,
                Color = clothesForm.Color,
                Size = clothesForm.Size,
                WashTemp = clothesForm.WashTemp,
                DryerAllow = clothesForm.DryerAllow,
                Price = clothesForm.Price

            });

            return RedirectToAction(nameof(Index));
                
                
        }
    }


}
