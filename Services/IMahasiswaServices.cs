using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUas.Models;

namespace BlazorUas.Services
{
    public interface IMahasiswaServices
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<Student> Add(Student student);
        Task<Student> Update(int id, Student student);
        Task Delete(int id);
    }
}