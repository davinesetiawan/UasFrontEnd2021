using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUas.Models;
using BlazorUas.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUas.Pages
{
    public partial class MahasiswaPage
    {
        public IEnumerable<Student> Mahasiswa { get; set; }

        [Inject]
        public IMahasiswaServices MahasiswaService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Mahasiswa = (await MahasiswaService.GetAll()).ToList();
        }
    }
}