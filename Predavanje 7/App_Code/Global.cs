using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Global
/// </summary>
public static class Global
{
    //Svi korisici hardkodirani u globalnoj klasi
    public static User[] allUsers = new User[]
    {
        new User("mate", "a", "Mate Matić"),
        new User("ivana", "a", "Ivana Matić"),
        new User("ana", "a", "Ana  Karabatić")
    };

    //Provjeri da li postoji user s tim imenom i lozinkom
    public static User UserExists(string uname, string psw)
    {
        for(int i=0; i < allUsers.Length; i++)
        {
            if (allUsers[i].Name == uname && allUsers[i].Password == psw)
            {
                return allUsers[i];
            }
        }
        return null;
    }
}