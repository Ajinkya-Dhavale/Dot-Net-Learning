using System;
using System.Collections.Generic;

namespace UserCrud.DataModel;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserMobile { get; set; }

    public string? UserPassword { get; set; }
}
