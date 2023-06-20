using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Web.Models
{
    public class GameDeveloperViewModel
    {
        public List<Game>? Games { get; set; }
        public SelectList? Developers { get; set; }
        public string? GameDeveloper { get; set; }
        public string? SearchString { get; set; }
    }
}
