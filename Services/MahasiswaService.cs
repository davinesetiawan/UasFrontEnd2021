using System;
using System.Runtime.Serialization.Json;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorUas.Models;
using System.Text.Json;

namespace BlazorUas.Services
{
    public class MahasiswaService : IMahasiswaServices
    {
        private HttpClient _httpClient;

        public MahasiswaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Student>>("api/Student");
            return results;
        }

        public async Task<Student> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Student>($"api/Student/{id}");
            return result;
        }

        public async Task<Student> Update(int id, Student student)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Student/",student);
            if(response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync());
            }
                else
                {
                    throw new Exception("Failed update Student Data");
                }
        }

        public async Task<Student> Add(Student obj)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/Student",obj);
            if(response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync());
            }
                else
                {
                    throw new Exception("Failed to Add Student Data");
                }
        }

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"api/Student/{id}");
        }
    }
}