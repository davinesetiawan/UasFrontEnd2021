using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorUas.Models;

namespace BlazorUas.Services
{
    public interface IEnrollmentServices
    {
        Task<IEnumerable<Enrollment>> GetAll();

        Task<Enrollment> GetById(int id);
    }
}