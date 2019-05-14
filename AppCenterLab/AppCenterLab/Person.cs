using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenterLab
{
    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public DateTimeOffset Birthday { get; set; }
    }
}
