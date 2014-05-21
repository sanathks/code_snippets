using System;
using System.Collections.Generic;
using System.Text;
using dbexlib;

namespace InventoryTrackingSystem
{
    class GenGTN
    {
        Location _location = new Location();
        Companies _companies = new Companies();
        GeneralItemGRN _genGRN = new GeneralItemGRN();


        #region Basic
        public string getCurrentCode()
        {
            string qry = @" SELECT
                                  IFNULL(MAX(trans_code),'null') AS code
                            FROM its_stock_trans
                            WHERE stock_code='GE'
                                    AND trans_type='GTN'";
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

        public string getItemName(string code)
        {
            string qry = @"SELECT
                            `cat_code`
                        FROM
                            `its_item_category`
                        WHERE (`stock_code` ='GE'
                            AND `cat_code` LIKE " + DB.Escape(code + "%") + ") GROUP BY `cat_code`";

            Log.write(qry);
            return DB.GetToAutocomplete(qry);
        }

        public string GetLocation(string code)
        {
            return _location.exLocation(code);
        }
        public string GetCompanies(string code)
        {
            return _companies.exCompanies(code);
        } 
        #endregion


        public int Save(Entity.GTN data)
        {
            int a = 0;            

           
                string qryGTNBasic = "INSERT INTO its_gtn_basic(`trans_code`,`stock_code`,`ref_no`,`desc`,`dDate`)VALUE ("
                                      + DB.Escape(data.TransCode) + ",'GE',"
                                      + DB.Escape(data.RefNo) + ","
                                      + DB.Escape(data.Description) + ","
                                      + DB.Escape(data.Date) + ")";

                //string qryGTNdetais = "INSERT INTO its_gtn_details(`trans_code`,`stock_code`,`ex_location`,`ex_company`,`qty`,`nw_user`,`nw_location`,`nw_company`)VALUE ("
                //                     + DB.Escape(data.TransCode) + ","
                //                     + "'GE',"
                //                     + DB.Escape("") + ","
                //                     + DB.Escape("") + ","
                //                     + DB.Escape("") + ","
                //                     + DB.Escape("") + ","
                //                     + DB.Escape("") + ","
                //                     + DB.Escape("") + ","
                //                     + ");";


                DB.Start_Transaction();

                a = DB.NonQuery(qryGTNBasic);

                foreach (var res in data.TableData)
                {
                    string qryGTN = "INSERT INTO its_stock_trans"
                           + " (`trans_date`,`trans_code`,`ref_no`,`item_cat`,`qty`,`location_code`,`company_code`,`remark`,`stock_code`,`trans_type`,`from`)VALUES ("
                           + DB.Escape(data.Date) + ","
                           + DB.Escape(data.TransCode) + ","
                           + DB.Escape(data.RefNo) + ","
                           + DB.Escape(res["item_name"]) + ","
                           + DB.Escape(res["qty"]) + ","
                           + DB.Escape(res["ex_location"]) + ","
                           + DB.Escape(res["ex_company"]) + ","
                           + DB.Escape(res["remark"]) + ","
                           + "'GE','GTN','USR');";

                  a+= DB.NonQuery(qryGTN);
                    Log.write(qryGTN);

                    string qryGRN = "INSERT INTO its_stock_trans"
                            + " (`trans_date`,`trans_code`,`item_cat`,`qty`,`location_code`,`company_code`,`remark`,`stock_code`,`trans_type`,`from`)VALUES ("
                            + DB.Escape(data.Date) + ","
                            + DB.Escape(data.TransCode) + ","
                            + DB.Escape(res["item_name"]) + ","
                            + DB.Escape(res["qty"]) + ","
                            + DB.Escape(res["ne_location"]) + ","
                            + DB.Escape(res["ne_company"]) + ","
                            + DB.Escape(res["remark"]) + ","
                            + "'GE','GRN','GTN');";

                   a+= DB.NonQuery(qryGRN);
                    Log.write(qryGRN);

                    string qryGTNdetais = "INSERT INTO its_gtn_details(`trans_code`,`stock_code`,`ex_location`,`ex_company`,`qty`,`nw_location`,`nw_company`,`item_cat`,`remarks`)VALUE ("
                                     + DB.Escape(data.TransCode) + ","
                                     + "'GE',"
                                     + DB.Escape(res["ex_location"]) + ","
                                     + DB.Escape(res["ex_company"]) + ","
                                     + DB.Escape(res["qty"]) + ","
                                     + DB.Escape(res["ne_location"]) + ","
                                     + DB.Escape(res["ne_company"]) + ","
                                     + DB.Escape(res["item_name"]) + ","
                                     + DB.Escape(res["remark"])
                                     + ");";

                    a += DB.NonQuery(qryGTNdetais);
                    Log.write(qryGTNdetais);

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

        public List<Dictionary<string,string>> getDataByCode(string code)
        {
            string qry=@"SELECT
                        `its_gtn_basic`.`trans_code`
                        , `its_gtn_basic`.`dDate`
                        , `its_gtn_basic`.`ref_no`
                        , `its_gtn_basic`.`desc`
                        , `its_gtn_details`.`item_cat`
                        , `its_gtn_details`.`ex_location`
                        , `its_gtn_details`.`ex_company`
                        , `its_gtn_details`.`qty`
                        , `its_gtn_details`.`nw_location`
                        , `its_gtn_details`.`nw_company`
                         , `its_gtn_details`.`remarks`
                        FROM
                            `its_gtn_details`
                            INNER JOIN `its_gtn_basic` 
                                ON (`its_gtn_details`.`trans_code` = `its_gtn_basic`.`trans_code`) 
                                AND (`its_gtn_basic`.`stock_code` = `its_gtn_details`.`stock_code`)
                        WHERE (`its_gtn_basic`.`trans_code`=" + DB.Escape(code) + ") AND (`its_gtn_basic`.`stock_code` ='GE')";

            return DB.Select(qry);
        }

        public int Delete(string code)
        {
            string qryBasic = "DELETE FROM its_gtn_basic WHERE trans_code=" + DB.Escape(code) + " AND stock_code='GE'";
            string qryDetails = "DELETE FROM its_gtn_details WHERE trans_code=" + DB.Escape(code) + " AND stock_code='GE'";
            string qryGTNTrans = "DELETE FROM its_stock_trans WHERE trans_code=" + DB.Escape(code) + " AND stock_code='GE' AND trans_type='GTN'";
            string qryGRNTrans = "DELETE FROM its_stock_trans WHERE trans_code=" + DB.Escape(code) + " AND stock_code='GE' AND trans_type='GRN' AND `from`='GTN'";

            DB.Start_Transaction();

           int a  = DB.NonQuery(qryBasic);
               a += DB.NonQuery(qryDetails);
               a += DB.NonQuery(qryGTNTrans);
               a += DB.NonQuery(qryGRNTrans);

            if(a>0)
            {
                DB.End_Transaction();
                return 1;
            }else
            {
                DB.Rollback();
                return 0;
            }

            
        }

        public bool QtyValidate(string item_cat,string location,string qty)
        {
           // string qry = "SELECT";
            return false;
        }

        public int Update(Entity.GTN _data)
        {
           int a= Delete(_data.TransCode);
           if (a > 0)
           {
             a+= Save(_data);
           }

           if (a > 0)
           {
               return 1;
           }
           else
           {
               return 0;
           }

        }
    }
}
