using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class DataBASE
    {
        private static DataBASE _instance;
        public static DataBASE Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataBASE();
                return _instance;
            }
        }
        public List<User> Users = new List<User>()
        {

        };
    }
}
