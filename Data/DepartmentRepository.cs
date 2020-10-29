using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using smsapi.Data;
using smsapi.Model;

namespace Data
{
    public class DepartmentRepository : IRepository<Department>
    {
        private readonly DataContext _context;
        public DepartmentRepository(DataContext context)
        {
            _context = context;
        }
        public Task<bool> DeleteData(Department student)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Department>> GetData()
        {
            //    Getting database data here
            return await _context.Department.ToListAsync();
        }

        public async Task<Department> GetDataById(int id)
        {
            return await _context.Department.FirstOrDefaultAsync(x => x.DepartmentId == id);
        }

        public async Task<Department> UpdateData(Department dept)
        {
            _context.Department.Add(dept);
            await _context.SaveChangesAsync();
            return dept;
        }
    }
}
