using System;
using System.Collections.Generic;
using System.Text;
using dbexlib;

namespace InventoryTrackingSystem
{
    class GeneralItemGRN
    {
        ItemCategories _itemCategory = new ItemCategories();
        Location _location = new Location();
        static string TABLE = "its_stock_trans";
        

        public List<Dictionary<string, string>> TableFill()
        {
            string qry = @"SELECT
                              IFNULL(`item_cat`,'Null')  AS `item_cat`,
                              IFNULL(SUM(`qty`)-GDN('GE',item_cat),0)AS current_qty,
                               `value`*IFNULL(SUM(`qty`)-GDN('GE',item_cat),0)  AS `value`,
                              its_item_category.cat_name
                            FROM its_stock_trans
                              INNER JOIN `its_item_category`
                                ON (`its_stock_trans`.`item_cat` = `its_item_category`.`cat_code`)
                            WHERE (`its_stock_trans`.`stock_code` = 'GE')
                            GROUP BY item_cat";
           return DB.Select(qry);
        }

        public string getCurrentCode()
        {
            string qry = @" SELECT
                                  IFNULL(MAX(trans_code),'null') AS code
                            FROM its_stock_trans
                            WHERE stock_code='GE'
                                    AND trans_type='GRN' AND `from`='USR'";
            int a;
            string code = "";

            var res = DB.Select(qry);

            code = ((res[0])["code"] == "null") ? "0" : res[0]["code"];
           
            a = Convert.ToInt32(code) + 1;
            
            code = a.ToString();
            if (a < 10)
            {
                code = "0000" + code;
            }
            else if (a >= 10 && a < 100)
            {
                code = "000" + code;
            }
            else if (a >= 100 && a < 1000)
            {
                code = "00" + code;
            }else if (a >= 1000 && a < 10000)
            {
                code = "0" + code;
            }

            return code;
        }

        #region Autocomlete
        public string GetItemCat(string code)
        {
          return _itemCategory.Get(code, "GE");
        }

        public string GetLocation(string code)
        {
            return _location.exLocation(code);
        }

        #endregion

        public int Save(TransFields data)
        {
            string qry = "INSERT INTO "+ TABLE
                         +" (`trans_date`,`trans_code`,`ref_no`,`item_cat`,`qty`,`value`,`location_code`,`remark`,`stock_code`,`trans_type`,`from`)VALUES ("
                         + DB.Escape(data.Date)+","
                         + DB.Escape(data.TransCode) + ","
                         + DB.Escape(data.RefNo) + ","
                         + DB.Escape(data.ItemCategory) + ","
                         + DB.Escape(data.Qty) + ","
                         + DB.Escape(data.Price) + ","
                         + DB.Escape(data.Location) + ","
                         + DB.Escape(data.Remark) + ","
                         +"'GE','GRN','USR');";
            Log.write(qry);
            return DB.NonQuery(qry);
        }

        public TransFields getDataByCode(string code)
        {
            TransFields fld = new TransFields();

            string qry = @"SELECT * FROM its_stock_trans WHERE trans_code =" + DB.Escape(code) + " AND stock_code = 'GE' AND trans_type = 'GRN' AND `from`='USR'";
            var res = DB.Select(qry);
            if (res.Count > 0)
            {
                foreach (var data in res)
                {
                   fld.Date= data["trans_date"];
                   fld.RefNo=data["ref_no"];
                   fld.ItemCategory= data["item_cat"];
                   fld.Qty=data["qty"];
                   fld.Price=data["value"];
                   fld.Location=data["location_code"];
                   fld.Remark = data["remark"];
                }

                return fld;
            }
            else
            {
                return null;
            }
        }
       
        public int Delete(string code)
        {
            string qry = "DELETE FROM its_stock_trans WHERE trans_code=" + DB.Escape(code) + " AND trans_type='GRN' AND stock_code='GE' AND `from`='USR'";
            return DB.NonQuery(qry);
        }

        public int Update(TransFields data)
        {
            string qry = @"UPDATE its_stock_trans SET `trans_date` ="
                                      +DB.Escape(data.Date)+",`ref_no` = " 
                                      +DB.Escape(data.RefNo)+",`item_cat` = "
                                      +DB.Escape(data.ItemCategory) +",`qty` ="
                                      +DB.Escape(data.Qty) +",`value` = "
                                      +DB.Escape(data.Price) +",`location_code` ="
                                      +DB.Escape(data.Location) +",`remark` = "
                                      +DB.Escape(data.Remark) + " WHERE trans_code ="
                                      +DB.Escape(data.TransCode) + " AND stock_code = 'GE' AND trans_type = 'GRN' AND `from`='USR'";

            //Log.write(qry);
            return DB.Update(qry);
            
        }

        public Fields loadExData()
        {
            return null;
        }
    }
}
