using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using BlazorUas.Models;
using BlazorUas.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUas.Pages
{
    public partial class EditMahasiswa
    {
        public Student Mahasiswa { get; set; } = new Student();

        [Inject]
        public IMahasiswaServices MahasisaServices { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Mahasiswa = await MahasisaServices.GetById(int.Parse(Id));
        }

        protected async Task HandleValidSubmit()
        {
            var result = await MahasisaServices.Update(int.Parse(Id),Mahasiswa);
            NavigationManager.NavigateTo("/mhspage");
        }
    }
}