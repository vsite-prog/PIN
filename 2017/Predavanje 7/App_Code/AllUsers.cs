using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AllUsers
/// </summary>
public static class AllUsers
{
    static List<User> allUsers = new List<User>
    {
        new User("ana", "ana"),
        new User("mate", "mate"),
        new User("jan", "jan"),
    };

    //Vidi da li ima tog korisnika i vrati boolean
    public static bool Find(string usr, string psw)
    {
        foreach (User user in allUsers)
        {
            if (user.Name == usr && user.Password == psw)
                return true;
        }
        return false; 
    }
}