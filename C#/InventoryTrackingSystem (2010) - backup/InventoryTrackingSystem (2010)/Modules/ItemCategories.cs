using System;
using System.Collections.Generic;
using System.Text;
using dbexlib;

namespace InventoryTrackingSystem
{
    class ItemCategories
    {
        static string TABLE = "its_item_category";

        public int Save(StockFields data)
        {
            string qry = "INSERT INTO " + TABLE + "(`cat_code`,`cat_name`,`cat_description`,`stock_code`) VALUES (" +
                          DB.Escape(data.Code) + "," +
                          DB.Escape(data.Name) + "," +
                          DB.Escape(data.Description) + "," + 
                          DB.Escape(data.Stock)
                          +")";
            //Log.write(qry);
            int res = DB.NonQuery(qry);
            return res;
        }
        //Upadate
        public int Update(StockFields data)
        {
            string qry = "UPDATE  " + TABLE
                          + " SET `cat_code` =" + DB.Escape(data.Code)
                          + ",`cat_name` =" + DB.Escape(data.Name)
                          + ",`cat_description` =" + DB.Escape(data.Description)
                          + ",`stock_code` =" + DB.Escape(data.Stock)
                          + "WHERE `cat_code`=" + DB.Escape(data.Code);
            Log.write(qry);
            int res = DB.Update(qry);
            return res;
        }

        //Autocomplete data 
        public string Get(string cat,string stk)
        {
            string qry = "SELECT cat_code FROM " + TABLE + " WHERE `cat_code` LIKE '" +cat+"%'" ;
            if (stk != "")
            {
                qry += " AND stock_code="+DB.Escape(stk);
            }
            Log.write(qry);
            return DB.GetToAutocomplete(qry);
        }

        //Load ex data
        public StockFields checkExData(string code)
        {
            StockFields fld = new StockFields();
            DB.Where("cat_code", code);
            var res = DB.SelectAllFrom(TABLE);
            if (res.Count > 0)
            {
                foreach (var data in res)
                {
                    fld.Code = data["cat_code"];
                    fld.Name = data["cat_name"];
                    fld.Description = data["cat_description"];
                    fld.Stock = data["stock_code"];
                    //Add More fields
                }

                return fld;
            }
            else
            {
                return null;
            }
        }
        //Delete
        public int Delete(string code)
        {
            DB.Where("cat_code", code);
            return DB.Delete(TABLE);
        }

    }
}
