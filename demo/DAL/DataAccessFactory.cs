using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
        public class DataAccessFactory
        {
            static PMTAppEntities db;
            static DataAccessFactory()
            {
                db = new PMTAppEntities();
            }

            public static IRepo<Project, int, string> ProjectDataAcess()
            {
                return new ProjectRepo(db);
            }


            public static IRepo<int, int> EnrollmentDataAcess()
            {
                return new EnrollmentRepo(db);
            }
        }
    }
