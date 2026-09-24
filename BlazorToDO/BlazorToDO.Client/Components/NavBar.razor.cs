using Microsoft.AspNetCore.Components;

namespace BlazorToDO.Client.Components
{
    public partial class NavBar
    {
        [Parameter]
        public string NavTitle { get; set; } = "Default Navbar Title";
        [Parameter]
        public RenderFragment? RightContent {  get; set; }
    }
}
