using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Manager: BaseEntity
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhotoPath { get; set; }
        public string? Profession { get; set; }
    }
}
