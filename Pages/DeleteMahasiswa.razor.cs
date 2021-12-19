using System.Reflection.Metadata;
using System.Threading.Tasks;
using BlazorUas.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUas.Pages
{
    public partial class DeleteMahasiswa
    {   
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IMahasiswaServices MahasiswaServices { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await MahasiswaServices.Delete(int.Parse(id));
            NavigationManager.NavigateTo("/mhspage");
        }
    }
}