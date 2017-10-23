using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public User()
    {
    }

    //Overload procedure
    public User(string pUname, string  pPsw, string pFullName)
    {
        this.Name = pUname;
        this.Password = pPsw;
        this.FullName = pFullName;
    }

    //Ovo su svojstva u C# i prisupamo im kao varijjablama
    public string Name
    {
        get;set;
    }

    public string Password
    {
        get; set;
    }

    public string FullName
    {
        get; set;
    }
}