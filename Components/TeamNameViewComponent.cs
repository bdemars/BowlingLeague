using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Components
{
    public class TeamNameViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamNameViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["teamname"];

            return View(context.Teams);
        }
    }
}
