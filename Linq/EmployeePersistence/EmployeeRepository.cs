using EmployeePersistence;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace EmployeePersistence
{
    public class EmployeeRepository
    {
        private IEnumerable<Employee> employees = new List<Employee>();
        public EmployeeRepository()
        {
            using (StreamReader r = new StreamReader("empList.json"))
            {
                string json = r.ReadToEnd();
                employees = JsonConvert.DeserializeObject<List<Employee>>(json);
            }
        }
        public IEnumerable<Employee> Employees()
        {
            return employees;
        }
    }

}
