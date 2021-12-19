using System.Threading.Tasks;
using BlazorUas.Models;
using BlazorUas.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUas.Pages
{
    public partial class AddMahasiswa
    {
        public Student Mahasiswa { get; set; } = new Student();

        [Inject]
        public IMahasiswaServices MahasiswaServices { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task HandleValidSubmit()
        {
            var result = await MahasiswaServices.Add(Mahasiswa);
            NavigationManager.NavigateTo("mhspage");
        }
    }
}