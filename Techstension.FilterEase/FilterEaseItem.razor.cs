using FilterEase.Data;
using Microsoft.AspNetCore.Components;

namespace Techstension.FilterEase
{
    public partial class FilterEaseItem
    {
        [Parameter]
        public CardDto? Card { get; set; }
    }
}
