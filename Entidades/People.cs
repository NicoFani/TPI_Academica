using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class People
    {
        int _idPerson;
        string _name;
        string _surname;
        string _address;
        string _email;
        string _telephone;
        DateTime _birthDate;
        int _fileId;
        int _personType;
        int _idPlan;
        string _username;
        string _password;
        Boolean _enabled;
        Boolean _changePassword;

        public int IdPerson { get { return _idPerson; } set { _idPerson = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Telephone { get { return _telephone; } set { _telephone = value; } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } }
        public int FileId { get { return _fileId; } set { _fileId = value; } }
        public int PersonType { get { return _personType; } set { _personType = value; } }
        public int IdPlan { get { return _idPlan; } set { _idPlan = value; } }
        public string Username { get { return _username;  } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public Boolean Enabled { get { return _enabled; } set { _enabled = value; } }
        public Boolean ChangePassword { get { return _changePassword; } set { _changePassword = value; } }
        public People(int idPerson, string name, string surname, string address, string email, string telephone, DateTime birthDate, int fileId, int personType, int idPlan, string username, string password, Boolean enabled, Boolean changePassword )
        {
            this.IdPerson = idPerson;
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.Email = email;
            this.Telephone = telephone;
            this.BirthDate = birthDate;
            this.FileId = fileId;
            this.PersonType = personType;
            this.IdPlan = idPlan;
            this.Username = username;
            this.Password = password;
            this.Enabled = enabled;
            this.ChangePassword = changePassword;
        }
    }
}
