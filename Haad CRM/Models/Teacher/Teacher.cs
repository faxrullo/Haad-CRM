﻿namespace Haad_CRM.Models.Teacher;

using System;
using Haad_CRM.Models.Common;

public class Teacher:Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
