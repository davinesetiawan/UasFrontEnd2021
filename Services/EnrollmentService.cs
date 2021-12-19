using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorUas.Models;

namespace BlazorUas.Services
{
    public class EnrollmentService : IEnrollmentServices
    {
        private HttpClient _httpClient;

        public EnrollmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Enrollment>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Enrollment>>("api/Student");
            return result;
        }

        public async Task<Enrollment> GetById(int id)
        {
            var results = await _httpClient.GetFromJsonAsync<Enrollment>($"api/Enrollment/{id}");
            return results;
        }
    }
}