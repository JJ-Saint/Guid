using ckecker.Models;
using ckecker.Controllers;
using ckecker.Data;


class MyClass
{
    static void guis()
    {
        Guid newGuid = Guid.NewGuid();
    }

    string guid = newGuid.Tostring();
    
    
    Console.WriteLine(guid);
}


