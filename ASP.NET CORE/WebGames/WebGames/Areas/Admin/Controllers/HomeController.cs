using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebGame.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        [Authorize(Roles = "1")] // Phân quyền người dùng, chỉ định người dùng nào có quyền là "2" mới được vào trang này
        // Muốn lấy được Roles(Phân quyền) này thì khi người dùng vừa mới đăng nhập vào hệ thống thì phải lưu lại quyền(Role) của người dùng vào cookie
        // Có thể phân quyền người dùng ở trong file "program" cũng được
        public IActionResult Index()
        {
            return View();
        }
    }
}
