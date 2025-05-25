using IdentityChatEmailNight.Context;
using IdentityChatEmailNight.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatEmailNight.ViewComponents
{
    public class _MessagesComponent : ViewComponent
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;

        public _MessagesComponent(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            string userMail = user.Email;

            ViewBag.inboxCount = _context.Messages.Where(x => x.ReceiverMail == userMail).Where(z => z.IsDeleted == false).Count();
            ViewBag.sendboxCount = _context.Messages.Where(x => x.SenderMail == userMail).Where(z => z.IsDeleted == false).Count();
            ViewBag.dustbinCount = _context.Messages.Where(x => x.ReceiverMail == userMail || x.SenderMail == userMail).Where(z => z.IsDeleted == true).Count();
            return View();
        }
    }
}
