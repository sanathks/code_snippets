using System;
using System.Collections.Generic;
using System.Text;
using dbexlib;

namespace InventoryTrackingSystem
{
    class Employee
    {
        static string TABLE = "its_employee";

        public string empCurrentCode()
        {
            string qry = "SELECT  MAX(emp_code)AS `emp_code` FROM " + TABLE;
            string code = "";
            int a = 0;
            var res = DB.Select(qry);
            foreach (var data in res)
            {
                code = data["emp_code"];
                a = Convert.ToInt32(code)+1;
            }
            code = a.ToString();
            if (a < 10)
            {
                code = "000"+code;
            }
            else if (a >= 10 && a < 100)
            {
                code = "00" + code;
            }
            else if (a >= 100 && a < 1000)
            {
                code = "0" + code;
            }
            
            return code;
        }

        public int Save(EmpField data)
        {
            string qry = "INSERT INTO " + TABLE + "(`emp_code`,`emp_title`,`emp_name`,`company_code`,`location`,`emp_designation`,`emp_phone`,`emp_email`,`is_working`) VALUES (" +
                          DB.Escape(data.Code) + "," +
                          DB.Escape(data.Title) + "," +
                          DB.Escape(data.Name) + "," +
                          DB.Escape(data.CompanyName) + "," +
                          DB.Escape(data.Location) + "," +
                          DB.Escape(data.Designation) + "," +
                          DB.Escape(data.PhoneNumber) + "," +
                          DB.Escape(data.Email) + "," +
                          DB.Escape("1") + ")";

            int res = DB.NonQuery(qry);
            return res;
        }

        public int Update(EmpField data)
        {
            string qry = "UPDATE  " + TABLE
                          + " SET `emp_code` =" + DB.Escape(data.Code)
                          + ",`emp_title` =" + DB.Escape(data.Title)
                          + ",`emp_name`=" + DB.Escape(data.Name)
                          + ",`company_code` =" + DB.Escape(data.CompanyName)
                          + ",`location`=" + DB.Escape(data.Location)
                          + ",`emp_designation` =" + DB.Escape(data.Designation)
                          + ",`emp_phone`=" + DB.Escape(data.PhoneNumber)
                          + ",`emp_email` =" + DB.Escape(data.Email)
                          + "WHERE `emp_code`=" + DB.Escape(data.Code);

            int res = DB.NonQuery(qry);
            return res;
        }

        public int Delete(string code)
        {
            DB.Where("emp_code", code);
            return DB.Delete(TABLE);
        }

        public EmpField checkExData(string name)
        {
            EmpField fld = new EmpField();
            DB.Where("emp_name", name);
            var res = DB.SelectAllFrom(TABLE);
            if(res.Count > 0)
            {
                foreach (var data in res)
                {
                    fld.Code = data["emp_code"];
                    fld.Name = data["emp_name"];
                    fld.Title = data["emp_title"];
                    fld.CompanyName = data["company_code"];
                    fld.Location = data["location"];
                    fld.Designation = data["emp_designation"];
                    fld.PhoneNumber = data["emp_phone"];
                    fld.Email = data["emp_email"];
                }

                return fld;
            }
            else
            {
                return null;
            }
        }

        public EmpField getDataByCode(string code)
        {
            EmpField fld = new EmpField();
            DB.Where("emp_code", code);
            var res = DB.SelectAllFrom(TABLE);
            if (res.Count > 0)
            {
                foreach (var data in res)
                {
                    fld.Code = data["emp_code"];
                    fld.Name = data["emp_name"];
                    fld.Title = data["emp_title"];
                    fld.CompanyName = data["company_code"];
                    fld.Location = data["location"];
                    fld.Designation = data["emp_designation"];
                    fld.PhoneNumber = data["emp_phone"];
                    fld.Email = data["emp_email"];

                }

                return fld;
            }
            else
            {
                return null;
            }
        }

        public string exEmp(string code)
        {
            return DB.GetToAutocomplete(TABLE, "emp_Name", code);
        }


    }
}
