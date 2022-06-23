using Bizland_FrontToBack.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bizland_FrontToBack.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private AppDbContext _context { get; }
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
//        public async Task<IActionResult> InvokeAsync()
//        {
//var model= await _context.Sett
//        }
    }
}
