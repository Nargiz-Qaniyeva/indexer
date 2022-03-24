using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace  utilities
{
    public bool Exist(string name,
                      string[] arr)
    {
        bool exist = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (name.ToLower() == arr[i].ToLower())
            {
                exist = true;
            }
        }
        if (exist==false )
        {
            throw new NotAvailableException($"{name} tapilmadi");
        }
        return exist;
    }

    
}
