using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;


namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public  static listaPizze pizze;
        public IActionResult Index()
        {
            Pizza margherita = new Pizza(0,"Pizza Margherita", "pomodoro , mozzarella campana , basilico", "/img/pizza-margherita-2-6yehdnu31vrv1puavcja7g753ipcgihq8vyh1ifv5pw.jpg",3);
            Pizza capricciosa = new Pizza(1,"Pizza Capricciosa", "Che soddisfa ogni capriccio", "/img/salsicciaepatate.jpg", 4);
            Pizza salsicciaPatate = new Pizza(2,"Pizza Salsiccia e Patate", "salsiccia , patate , mozzarella capana", "/img/salsicciaepatate.jpg", 5);
            Pizza marinara = new Pizza(3,"Pizza Marinara", "Grande classico", "/img/marinara.jpg", 3);
            Pizza quattroStagioni = new Pizza(4,"Pizza Quattro Stagioni", "La quattro Stagioni", "/img/Pizza_Quattro_Stagioni_transparent.png", 4);
            pizze = new();
            pizze.listaDiPizze.Add(margherita);
            pizze.listaDiPizze.Add(capricciosa);
            pizze.listaDiPizze.Add(salsicciaPatate);
            pizze.listaDiPizze.Add(marinara);
            pizze.listaDiPizze.Add(quattroStagioni);
            return View(pizze);
        }

        public IActionResult Show(int id)
        {
            return View("Show",pizze.listaDiPizze[id]);  
        }
    }


}