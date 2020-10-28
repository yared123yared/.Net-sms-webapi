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

        public Task<List<Department>> GetData()
        {
            //    Getting database data here
            return _context.Department.ToListAsync();
        }

        public Task<Department> GetDataById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Department> UpdateData(Department student)
        {
            throw new System.NotImplementedException();
        }
    }
}
