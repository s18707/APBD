using Cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Services
{
    public interface IDbService
    {
        public List<Doctor> GetDoctors();

        public Doctor UpdateDoctors(Doctor doctor);

        public Doctor DeleteDoctors(Doctor doctor);

        public Doctor InsertDoctors(Doctor doctor);
    }
}
