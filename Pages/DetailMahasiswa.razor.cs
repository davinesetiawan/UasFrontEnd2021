using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUas.Models;
using BlazorUas.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


namespace BlazorUas.Pages
{
    public partial class DetailMahasiswa
    {
        [Parameter]
        public string id { get; set; }
        public Student Mahasiswa { get; set; } = new Student();

        [Inject]
        public IMahasiswaServices MahasiswaService { get; set; }

        public string ButtonText { get; set; } = "Hide Footer";
        public string CssClass { get; set; } = null;

        protected void Button_Click()
        {
            if(ButtonText == "Hide Footer")
            {
                CssClass = "Hide Footer";
                ButtonText = "Show Footer";
            }
                else
                {
                    CssClass = null;
                    ButtonText = "Hide Footer";
                }
        }

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Mahasiswa = await MahasiswaService.GetById(Convert.ToInt32(id));
        }
    }
}