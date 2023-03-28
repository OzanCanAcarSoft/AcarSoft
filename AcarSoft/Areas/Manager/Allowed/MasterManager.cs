using AcarSoft.Areas.Manager.Extension;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AcarSoft.Areas.Manager.Allowed
{
    public class MasterManager: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Model.Entities.Manager man = context.HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");

            if (man.Id == 1)
                return;

            context.Result = new RedirectToActionResult("Index", "ManagerHome", null);
        }
    }
}
