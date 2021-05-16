using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Utils
{
    public class CustomPageFilter : IAsyncPageFilter
    {
        private readonly IGeoService _geoService;
        public CustomPageFilter(IGeoService geoService)
        {
            _geoService = geoService;
        }
        public async Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            await Task.CompletedTask;
        }
        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            var ipAddress = context.HttpContext.Request.Host.ToString();
            //var countryCode = await _geoService.GetCountry(ipAddress);

            await next.Invoke();
        }
    }
}
