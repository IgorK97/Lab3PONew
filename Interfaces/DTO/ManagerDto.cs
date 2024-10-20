using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ManagerDto
    {
        public ManagerDto()
        {

        }
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string? surname { get; set; }
        public string login { get; set; }
        public string C_password { get; set; }
        public string phone { get; set; }
        public string? email { get; set; }
        public ManagerDto(Manager m)
        {
            Id = m.Id;
            first_name = m.FirstName;
            last_name = m.LastName;
            surname = m.Surname;
            login = m.Login;
            phone = m.Phone;
            email = m.Email;
            C_password = m.Password;
        }
    }
}
