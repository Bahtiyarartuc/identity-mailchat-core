using IdentityChatEmailNight.Context;
using IdentityChatEmailNight.Entities;
using IdentityChatEmailNight.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace IdentityChatEmailNight.Controllers
{
    public class ProfileController : Controller
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> ProfileDetail()
        {
            ViewBag.page = "Profilim";

            ProfileEditViewModel model = new ProfileEditViewModel();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.username = user.UserName;
            ViewBag.name = user.Name;
            ViewBag.surname = user.Surname;
            ViewBag.email = user.Email;
            ViewBag.phonenumber = user.PhoneNumber;
            ViewBag.city = user.City;
            ViewBag.profileimage = user.ProfileImageUrl;


            model.Name = user.Name;
            model.Surname = user.Surname;
            model.Email = user.Email;
            model.PhoneNumber = user.PhoneNumber;
            model.City = user.City;
            model.ImageUrl = user.ProfileImageUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProfileDetail(ProfileEditViewModel model)
        {


            if (model.Password == model.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.City = model.City;
                user.ProfileImageUrl = model.ImageUrl;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("InBox", "Message");
                }

                return View();
            }

            return View();
        }
    }
}
