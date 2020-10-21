using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using smsapi.Model;

namespace smsapi.Data
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public Task<bool> DeleteData(Student student)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Student>> GetData()
        {
            return await _context.Student.ToListAsync();
        }

        public async Task<Student> GetDataById(int id)
        {
            return await _context.Student.FirstOrDefaultAsync(x => x.StudentId == id);
        }

        public Task<Student> UpdateData(Student student)
        {
            throw new System.NotImplementedException();
        }
    }
}