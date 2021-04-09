using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessProject.DB_Access
{
    class StudenAccess
    {
        myDBDataContext db = new myDBDataContext();

        public IQueryable getAllStudents()
        {
           return from std in db.students
                  select new
                  {
                      ID = std.C01_id,
                      LastName = std.C03_lastname,
                      FirstName = std.C02_firtsname,
                      BirthDay = std.C04_birthday,
                      Gender = std.C05_gender,
                      Phone = std.C06_phonenumber,
                      Address = std.C07_address
                  };
        }

        public IQueryable getStudents(string key)
        {
            return (from std in db.students
                    where std.C01_id.ToString().Contains(key) ||
                          std.C02_firtsname.Contains(key) ||
                          std.C03_lastname.Contains(key) ||
                          std.C07_address.Contains(key)
                    select std);
        }

        public student getStudent(int ID)
        {
            return (from std in db.students
                    where std.C01_id == ID
                    select std).SingleOrDefault();
        }

        public void Add(student source)
        {
            db.students.InsertOnSubmit(source);
            db.SubmitChanges();
        }

        public void Edit(student source)
        {
            var query = (from std in db.students
                        where std.C01_id == source.C01_id
                        select std).SingleOrDefault();

            if(null != query)
            {
                query.C01_id = source.C01_id;
                query.C02_firtsname = source.C02_firtsname;
                query.C03_lastname = source.C03_lastname;
                query.C04_birthday = source.C04_birthday;
                query.C05_gender = source.C05_gender;
                query.C06_phonenumber = source.C06_phonenumber;
                query.C07_address = source.C07_address;
                query.C08_avatar = source.C08_avatar;

                db.SubmitChanges();
            }
        }

        public void Remove(student source)
        {
            var query = (from std in db.students
                         where std.C01_id == source.C01_id
                         select std).SingleOrDefault();

            db.students.DeleteOnSubmit(query);
            db.SubmitChanges();
        }
    }
}
