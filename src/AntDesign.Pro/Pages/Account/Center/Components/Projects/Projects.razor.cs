using System.Collections.Generic;
using AntDesign.Pro.Models;
using Microsoft.AspNetCore.Components;

namespace AntDesign.Pro.Pages.Account.Center
{
    public partial class Projects
    {
        private readonly ListGridType _listGridType = new ListGridType
        {
            Gutter = 24,
            Column = 4
        };

        [Parameter]
        public IList<ListItemDataType> List { get; set; }
    }
}