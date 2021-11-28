using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MemberRepo
    {
        static PMTAppEntities db;

        static MemberRepo()
        {
            db = new PMTAppEntities();
        }

        public static Member GetLogin(string username, string password)
        {
            return db.Members.FirstOrDefault(e => e.Username == username && e.Password == password);

        }

    }
}