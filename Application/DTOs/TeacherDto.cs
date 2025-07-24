﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class TeacherDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }

    public class CreateTeacherDto
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; // Ajouté pour cohérence
    }
}
