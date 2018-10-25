using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    //Ovo su C# svojstva, read only na zahtjev kolege
    public string Name { get; }
    public string Password { get;}
    public User(string uname, string psw)
    {
        Name = uname;
        Password = psw;
    }
}

