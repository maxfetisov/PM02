using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film_service
{
    static class DBContext
    {
        public static film_serviceEntities context;
        public static string login;
        public static void createContext()
        {
            context = null;
            context = new film_serviceEntities();
        }
        public static void createContext(string connectionString)
        {
            context = null;
            context = new film_serviceEntities(connectionString);  
        }
        public static bool isFullAccess()
        {
            try
            {
                string str = (from u in context.user
                              select u.login).FirstOrDefault();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string Login { set => login = value; 
        }
    }

}
