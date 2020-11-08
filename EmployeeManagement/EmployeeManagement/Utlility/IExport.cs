using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utlility
{
    public interface IExport
    {
       public Task<bool> ExportToCSV(IEnumerable<UsersResponse> exportSource,string path);
    }
}
