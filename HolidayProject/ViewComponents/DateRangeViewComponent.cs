using HolidayProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.ViewComponents;

public class DateRangeViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(DateRangePickerViewModel model)
    {
        return View(model);
    }
}
