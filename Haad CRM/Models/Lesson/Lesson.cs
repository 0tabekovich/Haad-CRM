﻿namespace Haad_CRM.Models.Lesson;

using Haad_CRM.Models.Common;
using System;

public class Lesson:Auditable
{
    public string Name { get; set; }
    public int GroupId { get; set; }
    public DateTime LFromDate { get; set; }
    public DateTime LToDate { get; set; }
}
