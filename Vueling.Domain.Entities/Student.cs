using System;
using System.Collections.Generic;

namespace Vueling.Domain.Entities
{
    public class Student : IDomainObject
    {
        private Guid guid;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid Guid { get => guid; private set => guid = value; }

        public Student()
        {
            this.guid = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name &&
                   Lastname == student.Lastname &&
                   BirthDate == student.BirthDate &&
                   Guid.Equals(student.Guid);
        }

        public override int GetHashCode()
        {
            var hashCode = -2028737042;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lastname);
            hashCode = hashCode * -1521134295 + BirthDate.GetHashCode();
            hashCode = hashCode * -1521134295 + Guid.GetHashCode();
            return hashCode;
        }
    }
}
