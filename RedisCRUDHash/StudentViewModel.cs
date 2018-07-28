using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCRUDHash
{
    public class StudentViewModel
    {
        public StudentViewModel(int id, string name, string surname, string dni)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Dni = dni;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }

        public override bool Equals(object obj)
        {
            var model = obj as StudentViewModel;
            return model != null &&
                   Id == model.Id &&
                   Name == model.Name &&
                   Surname == model.Surname &&
                   Dni == model.Dni;
        }

        public override int GetHashCode()
        {
            var hashCode = -78767898;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            return hashCode;
        }
    }
}
