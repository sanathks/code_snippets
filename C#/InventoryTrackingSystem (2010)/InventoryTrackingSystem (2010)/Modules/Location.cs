using System;
using System.Collections.Generic;
using System.Text;
using dbexlib;

namespace InventoryTrackingSystem
{
    class Location
    {
        static string TABLE = "its_location";
        public string exLocation(string code)
        {
           // Log.write("OK");
            return DB.GetToAutocomplete(TABLE, "location_code", code);
        }
        public string LocationName(string code)
        {
            return DB.GetToAutocomplete(TABLE, "location_code", "location_Name", code);
        }
        public int Save(Fields data)
        {
            string qry = "INSERT INTO " + TABLE + "(`location_code`,`location_name`,`location_desc`) VALUES (" +
                          DB.Escape(data.Code) + "," +
                          DB.Escape(data.Name) + "," +
                          DB.Escape(data.Description) + ")";

            int res = DB.NonQuery(qry);
            return res;
        }
       
        public int Update(Fields data)
        {
            string qry = "UPDATE  " + TABLE
                          + " SET `location_code` =" + DB.Escape(data.Code)
                          + ", `location_name` =" + DB.Escape(data.Name)
                          + ", `location_desc`=" + DB.Escape(data.Description)
                          + "WHERE `location_code`=" + DB.Escape(data.Code);

            int res = DB.NonQuery(qry);
            return res;
        }

        public int Delete(string code)
        {
            DB.Where("location_code", code);
            return DB.Delete(TABLE);
        }

        public Fields checkExData(string code)
        {
            Fields fld = new Fields();
            DB.Where("location_code", code);
            var res = DB.SelectAllFrom(TABLE);
            if (res.Count > 0)
            {
                foreach (var data in res)
                {
                    fld.Code = data["location_code"];
                    fld.Name = data["location_name"];
                    fld.Description = data["location_desc"];

                }

                return fld;
            }
            else
            {
                return null;
            }
        }

        public string getLocation(string code)
        {
            string location = "";
            DB.Where("location_code", code);
            var res = DB.SelectAllFrom(TABLE);
            if (res.Count > 0)
            {
                foreach (var data in res)
                {

                    location = data["location_name"];
              

                }

                return location;
            }
            else
            {
                return null;
            }
        }
    }
}
