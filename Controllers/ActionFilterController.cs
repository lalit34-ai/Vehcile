// we will be presenting this mvc

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

public class ActionsAttribute : ActionFilterAttribute
{
    Stopwatch? watch;

    public override void OnActionExecuted(ActionExecutedContext filterContext) // here by using we separated cross cuttting concerns(like logging)
    {
        watch?.Stop();

        Action("OnActionExecuted", filterContext.RouteData);
        // filterContext.HttpContext.Response.WriteAsync("Action Time"+
    }

    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        Action("OnActionExecuting", filterContext.RouteData); //This method is called before a controller action is executed.
        watch = Stopwatch.StartNew();
    }

    public override void OnResultExecuted(ResultExecutedContext filterContext)
    {
        Action("OnResultExecuted", filterContext.RouteData);
    }

    public override void OnResultExecuting(ResultExecutingContext filterContext)
    {
        Action("OnResultExecuting", filterContext.RouteData); //This method is called before a controller action result is executed.
    }

    private void Action(string methodName, RouteData routeData)
    {
        var controllerName = routeData.Values["controller"];
        var actionName = routeData.Values["action"];
        var message =
            methodName
            + " -Controller:"
            + controllerName
            + ",Action:"
            + actionName
            + ",Time of Use:"
            + watch?.ElapsedMilliseconds.ToString()
            + "\n";
        Console.WriteLine(message);
    }
}
