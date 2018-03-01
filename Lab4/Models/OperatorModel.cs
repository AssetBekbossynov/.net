using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FormsTagHelper.ViewModels
{
    public class OperatorModel
    {
        public string Operator { get; set; }

        public List<SelectListItem> Operators { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "+", Text = "+" },
            new SelectListItem { Value = "-", Text = "-" },
            new SelectListItem { Value = "*", Text = "*"  },
            new SelectListItem { Value = "/", Text = "/"  },
        };
    }
}
