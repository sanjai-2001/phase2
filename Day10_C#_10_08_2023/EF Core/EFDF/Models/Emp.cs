using System;
using System.Collections.Generic;

namespace EFDF.Models;

public partial class Emp
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpAdd { get; set; }

    public int? DeptNo { get; set; }

    public virtual Dept? DeptNoNavigation { get; set; }
}
