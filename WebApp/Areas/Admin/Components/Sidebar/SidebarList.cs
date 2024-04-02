using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Admin.Components.Sidebar
{
    public class SidebarList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
