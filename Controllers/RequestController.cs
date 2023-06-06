using Karpaty.Models;
using Karpaty.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Karpaty.Controllers
{

    public class RequestController : Controller
    {
        ApplicationContext _context;

        public RequestController( ApplicationContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            AddRequestModel model = new AddRequestModel();
            model.Houses = new SelectList(_context.Houses.Select(x => new { x.Name, HouseId = x.HouseId.ToString()}).ToList(), "HouseId", "Name");
            model.PeopleDropdown = new SelectList(new[] {
                    new  { Value="1", Text="1"},
                    new  { Value="2", Text="2"},
                    new  { Value="3", Text="3"},
                    new  { Value="4", Text="4"} }, "Value", "Text");
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string ClientPIB, string ClientPhone, string ClientEmail,
                    int? PersonCount, DateTime? DateStart, DateTime? DateEnd, int? HouseId, string Comment)
        {
            Booking model = new Booking()
            {
                ClientEmail = ClientEmail,
                ClientPhone = ClientPhone,
                ClientPIB = ClientPIB,
                DateEnd = DateEnd,
                DateStart = DateStart,
                HouseId = HouseId,
                PersonCount = PersonCount,
                Comment = Comment,
                DateCreated = DateTime.Now
            };
            await _context.Bookings.AddAsync(model);
            await _context.SaveChangesAsync();
            TempData["Message"] = "Ваша заявка успішно подана. Найближчим часом з вами зв'яжеться менеджер для поточнення деталей";
            return RedirectToAction("Index", "Home");
        }
    }
}
