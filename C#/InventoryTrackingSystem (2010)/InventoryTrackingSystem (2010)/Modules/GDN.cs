using System;
using System.Collections.Generic;
using System.Text;
using dbexlib;

namespace InventoryTrackingSystem
{
    class GDN
    {
        ItemCategories _itemCategory = new ItemCategories();
        public string getCurrentCode()
        {
            string qry = @" SELECT
                                  IFNULL(MAX(trans_code),'null') AS code
                            FROM its_stock_trans
                            WHERE (stock_code='FA' OR stock_code='EC' OR stock_code='GE')
                                    AND trans_type='GDN'";
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
            }
            else if (a >= 1000 && a < 10000)
            {
                code = "0" + code;
            }

            return code;
        }

        public string GetSerialCode(string code, string type)
        {
            string qry = "";

            if (type == "FA")
            {
                qry = "SELECT ref_no FROM its_stock_trans WHERE stock_code='FA' AND `is_available`='Y' AND ref_no LIKE " + DB.Escape(code + "%") + " GROUP BY ref_no";
                return DB.GetToAutocomplete(qry);
            }
            else if (type == "EC")
            {
                qry = "SELECT serial_code FROM its_stock_trans WHERE stock_code='EC' AND `is_available`='Y' AND serial_code LIKE " + DB.Escape(code + "%") + " GROUP BY serial_code";
                return DB.GetToAutocomplete(qry);
            }
            else
            {
                return _itemCategory.Get(code, "GE");
            }

         //   Log.write(type);
            
        }

        public List<Dictionary<string, string>> getDataByCode(string code)
        {
             string qry=@"SELECT
                              trans_code,
                              stock_code,
                              item_code,
                              ex_location,
                              ex_company,
                              qty,
                              `value`,
                              remark
                            FROM its_gdn_details
                            WHERE trans_code ="+DB.Escape(code);

            return DB.Select(qry);
        }

        public int Update(Entity.GTN _data)
        {
            int res = 0;
            if (Delete(_data.TransCode,_data.Stock_Type) > 0)
            {
               res= Save(_data);
            }

            return res;
        }

        public int Save(Entity.GTN data)
        {
            int a = 0;
            string qryGDNBasic = "INSERT INTO its_gdn_basic(`trans_code`,`stock_code`,`desc`,`dDate`) VALUE ("
                                      + DB.Escape(data.TransCode) + ","
                                      + DB.Escape(data.Stock_Type) + ","
                                      + DB.Escape(data.Description) + ","
                                      + DB.Escape(data.Date) + ")";


            DB.Start_Transaction();


            a = DB.NonQuery(qryGDNBasic);

            foreach (var res in data.TableData)
            {
                string qryGDN = "";
                if (data.Stock_Type == "FA")
                {
                    _updateIsAvailable(res["code"], 1, false);
                    qryGDN = "INSERT INTO its_stock_trans (`trans_date`,`trans_code`,`ref_no`,`location_code`,`company_code`,`remark`,`stock_code`,`trans_type`,`from`)VALUES ("
                                   + DB.Escape(data.Date) + ","
                                   + DB.Escape(data.TransCode) + ","
                                   + DB.Escape(res["code"]) + ","
                                   + DB.Escape(res["ex_location"]) + ","
                                   + DB.Escape(res["ex_company"]) + ","
                                   + DB.Escape(res["remark"]) + ","
                                   + "'FA','GDN','USR');";
                }
                else if (data.Stock_Type == "EC")
                {
                    _updateIsAvailable(res["code"], 2, false);
                    qryGDN = "INSERT INTO its_stock_trans (`trans_date`,`trans_code`,`serial_code`,`location_code`,`company_code`,`remark`,`stock_code`,`trans_type`,`from`)VALUES ("
                                    + DB.Escape(data.Date) + ","
                                    + DB.Escape(data.TransCode) + ","
                                    + DB.Escape(res["code"]) + ","
                                    + DB.Escape(res["ex_location"]) + ","
                                    + DB.Escape(res["ex_company"]) + ","
                                    + DB.Escape(res["remark"]) + ","
                                    + "'EC','GDN','USR');";
                }
                else
                {
                    qryGDN = "INSERT INTO its_stock_trans (`trans_date`,`trans_code`,`item_cat`,`location_code`,`company_code`,`remark`,`stock_code`,`trans_type`,`from`)VALUES ("
                                   + DB.Escape(data.Date) + ","
                                   + DB.Escape(data.TransCode) + ","
                                   + DB.Escape(res["code"]) + ","
                                   + DB.Escape(res["ex_location"]) + ","
                                   + DB.Escape(res["ex_company"]) + ","
                                   + DB.Escape(res["remark"]) + ","
                                   + "'GE','GDN','USR');";
                }
                
                a += DB.NonQuery(qryGDN);

               string qryGDNdetais = "INSERT INTO its_gdn_details (`trans_code`,`stock_code`,`ex_location`,`ex_company`,`item_code`,`qty`,`value`,`remark`)VALUE ("
                                            + DB.Escape(data.TransCode) + ","
                                            + DB.Escape(data.Stock_Type) + ","
                                            + DB.Escape(res["ex_location"]) + ","
                                            + DB.Escape(res["ex_company"]) + ","
                                            + DB.Escape(res["code"]) + ","
                                            + DB.Escape(res["qty"]) + ","
                                            + DB.Escape(res["value"]) + ","
                                            + DB.Escape(res["remark"])
                                            + ");";

                a += DB.NonQuery(qryGDNdetais);
            // Log.write(qryGDNdetais);

            }

            if (a > 0)
            {
                DB.End_Transaction();
                return 1;
            }
            else
            {
                DB.Rollback();
                return 0;
            } 

        }

        private void _updateIsAvailable(string code, int var1, bool st)
        {
            string val = (st) ? "Y" : "N";
            string qry = "UPDATE its_stock_trans SET `is_available`='" + val + "' ";

            switch (var1)
            {
                case 1:
                    qry += "WHERE (`ref_no` =" + DB.Escape(code)
                           + "AND `stock_code` ='FA' AND `trans_type` ='GRN')";
                    break;
                case 2:
                    qry += "WHERE (`serial_code` =" + DB.Escape(code)
                             + "AND `stock_code` ='EC' AND `trans_type` ='GRN')";
                    break;

            }
            DB.NonQuery(qry);
        }

        private string _getPrivCode(string code)
        {
            string qry = "SELECT item_code FROM its_gdn_details WHERE trans_code=" + DB.Escape(code);
            //DB.Where("trans_code", DB.Escape(code));
            //var data1 = DB.SelectAllFrom("its_gtn_details");
            var data = DB.Select(qry);
            return data[0]["item_code"];
        }


        public int Delete(string code,string type)
        {
            string qryBasic = "DELETE FROM its_gdn_basic WHERE trans_code=" + DB.Escape(code) + " AND (stock_code='FA' OR stock_code='EC' OR stock_code='GE')";
            string qryDetails = "DELETE FROM its_gdn_details WHERE trans_code=" + DB.Escape(code) + " AND (stock_code='FA' OR stock_code='EC' OR stock_code='GE')";
            string qryGTNTrans = "DELETE FROM its_stock_trans WHERE trans_code=" + DB.Escape(code) + " AND (stock_code='FA' OR stock_code='EC' OR stock_code='GE') AND trans_type='GDN'";


            DB.Start_Transaction();

            if (type == "FA")
            {
                _updateIsAvailable(_getPrivCode(code), 1, true);
            }
            else if (type == "EC")
            {
                _updateIsAvailable(_getPrivCode(code), 2, true);
            }

            int a = DB.NonQuery(qryBasic);
            a += DB.NonQuery(qryDetails);
            a += DB.NonQuery(qryGTNTrans);
       
            if (a > 0)
            {
                DB.End_Transaction();
                return 1;
            }
            else
            {
                DB.Rollback();
                return 0;
            }
        }
    }
}
