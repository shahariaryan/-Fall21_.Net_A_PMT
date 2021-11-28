﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class EnrollmentRepo : IRepo<int, int>
    {

        PMTAppEntities db;
        public EnrollmentRepo(PMTAppEntities db)
        {
            this.db = db;
        }

        public void Add(int pId, int mId)
        {
            var e = new Enrollment();
            e.ProjectId = pId;
            e.MemberId = mId;
            e.Status = "Applied";

            db.Enrollments.Add(e);
            db.SaveChanges();
        }



        public void Confirm(int eId)
        {
            var enrollment = db.Enrollments.FirstOrDefault(enr => enr.Id == eId);

            var project = db.Projects.FirstOrDefault(pr => pr.Id == enrollment.ProjectId);
            if (project.Status == "Open")
            {
                
                enrollment.Status = "Confirmed";
                db.SaveChanges();
            }
            else
            {
           
                enrollment.Status = "Declined";
                db.SaveChanges();
            }
        }

        public void Decline(int eId)
        {
            var enrollment = db.Enrollments.FirstOrDefault(enr => enr.Id == eId);
            enrollment.Status = "Declined";
            db.SaveChanges();
        }
    }
}