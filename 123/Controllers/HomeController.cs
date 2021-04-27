using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Kursova9.Models;

namespace Kursova9.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsersContext db;
        public HomeController(UsersContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            //return Content(User.Identity.Name);
            return View();        
        }

        [HttpPost]
        public async Task<IActionResult> Messeng (Messeng mess)
        {
            if (mess != null)
            {
                try
                {
                    db.Messengs.Add(mess);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch
                {
                    ViewBag.Error = "Ошибка отправки сообщения";
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Error = "Ошибка отправки сообщения";
            return RedirectToAction("Index");
        }
    }
}
