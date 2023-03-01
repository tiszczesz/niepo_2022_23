using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace cw9_mvc1.Views.Second
{
    public class Index2 : PageModel
    {
        private readonly ILogger<Index2> _logger;

        public Index2(ILogger<Index2> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}