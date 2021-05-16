using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filters
{
    public class BasePageModel : PageModel
    {

        public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            //...
        }
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            //...
        }
    }
    public class IndexModel : BasePageModel
    {
        public void OnGet()
        {
            //...
        }
    }
}
