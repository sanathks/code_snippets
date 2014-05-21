using System;
using System.Collections.Generic;
using System.Text;
using dbexlib;

namespace InventoryTrackingSystem
{
    class Companies
    {
        static string TABLE = "its_company"; 
        public string exCompanies(string code)
        {
            return DB.GetToAutocomplete(TABLE,"company_code",code);
        }

        public string CompaniesName(string code)
        {
            return DB.GetToAutocomplete(TABLE, "company_code", "company_name", code);
        }

        public int Save(Fields data)
        {
            string qry = "INSERT INTO " + TABLE + "(`company_code`,`company_name`,`company_desc`) VALUES (" +
                          DB.Escape(data.Code) +","+
                          DB.Escape(data.Name) +","+
                          DB.Escape(data.Description) +")";

            int res = DB.NonQuery(qry);
            return res;
        }

        public int Update(Fields data)
        {
            string qry = "UPDATE  " + TABLE 
                          + " SET `company_code` =" + DB.Escape(data.Code) 
                          + ", `company_name` =" + DB.Escape(data.Name) 
                          + ", `company_desc`=" + DB.Escape(data.Description)
                          + "WHERE `company_code`=" + DB.Escape(data.Code) ;
                       
            int res = DB.NonQuery(qry);
            return res;
        }

        public Fields getData(string code)
        {
            Fields fld = new Fields();
            DB.Where("company_code", code);
            var res = DB.SelectAllFrom(TABLE);
            foreach (var data in res)
            {
                fld.Code=data["company_code"];
                fld.Name=data["company_name"];
                fld.Description = data["company_desc"];

            }
            return fld;
        }

        public int Delete(string code)
        {
            DB.Where("company_code", code);
            return DB.Delete(TABLE);
        }

        public Fields checkExData(string code)
        {
            Fields fld = new Fields();
            DB.Where("company_code", code);
            var res = DB.SelectAllFrom(TABLE);
            if (res.Count > 0)
            {
                foreach (var data in res)
                {
                    fld.Code = data["company_code"];
                    fld.Name = data["company_name"];
                    fld.Description = data["company_desc"];

                }

                return fld;
            }
            else
            {
                return null;
            }
        }

        public string getCompany(string code)
        {
            DB.Where("company_code", code);
            var res = DB.SelectAllFrom(TABLE);
            string com_name = "";
            if (res.Count > 0)
            {
                foreach (var data in res)
                {
                    com_name = data["company_name"];
                }

                return com_name;
            }
            else
            {
                return null;
            }
        }
    }
}
