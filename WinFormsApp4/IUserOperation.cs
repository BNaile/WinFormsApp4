using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal interface IUserOperation
    {
         
        bool HasUser(User user, out User outUser);
        
    }
}

