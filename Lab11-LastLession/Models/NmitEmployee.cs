using System;
using System.Collections.Generic;

namespace Lab11_LastLession.Models;

public partial class NmitEmployee
{
    public int NmitEmpId { get; set; }

    public string? NmitEmpName { get; set; }

    public string? NmitEmpLevel { get; set; }

    public DateOnly? NmitEmpStartDate { get; set; }

    public bool? NmitEmpStatus { get; set; }
}
