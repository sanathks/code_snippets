using System;
using System.Collections.Generic;
using System.Text;
using dbexlib;

namespace InventoryTrackingSystem
{
    class GTN
    {
        Location _location = new Location();
        Companies _companies = new Companies();
        FixtAssetGRN _fixtAssetGRN = new FixtAssetGRN();
        ElecDivice _elecDivice = new ElecDivice();

        public string getCurrentCode()
        {
            string qry = @" SELECT
                                  IFNULL(MAX(trans_code),'null') AS code
                            FROM its_stock_trans
                            WHERE (stock_code='FA' OR stock_code='EC')
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

        #region AutoComplete

        public string GetSerialCode(string code,string type)
        {
            string qry = "";

            if (type == "FA")
            {
                qry = "SELECT ref_no FROM its_stock_trans WHERE stock_code='FA' AND `is_available`='Y' AND ref_no LIKE " + DB.Escape(code + "%") + " GROUP BY ref_no";
            }
            else if(type == "EC")
            {
                qry = "SELECT serial_code FROM its_stock_trans WHERE stock_code='EC' AND `is_available`='Y' AND serial_code LIKE " + DB.Escape(code + "%") + " GROUP BY serial_code";
            }

            Log.write(type);
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
        public string GetEmp(string code)
        {
            string qry = @"SELECT
                              CONCAT(emp_name,'-',emp_code) AS `name`
                            FROM its_employee
                            WHERE emp_name LIKE" + DB.Escape(code + "%");
            return DB.GetToAutocomplete(qry);
        } 
        #endregion

        public int Save(Entity.GTN data)
        {
            int a = 0;
            string qryGTNBasic = "INSERT INTO its_gtn_basic(`trans_code`,`stock_code`,`desc`,`dDate`) VALUE ("
                                  + DB.Escape(data.TransCode) + ","
                                  + DB.Escape(data.Stock_Type) + ","
                                  + DB.Escape(data.Description) + ","
                                  + DB.Escape(data.Date) + ")";

            
            DB.Start_Transaction();

            a = DB.NonQuery(qryGTNBasic);

            foreach (var res in data.TableData)
            {
                string qryGTN="";
                if (data.Stock_Type == "FA")
                {
                    _updateIsAvailable(res["code"], 1,false);
                    qryGTN ="INSERT INTO its_stock_trans (`trans_date`,`trans_code`,`ref_no`,`location_code`,`company_code`,`current_user`,`remark`,`stock_code`,`trans_type`,`from`)VALUES ("
                           + DB.Escape(data.Date) + ","
                           + DB.Escape(data.TransCode) + ","
                           + DB.Escape(res["code"]) + ","
                           + DB.Escape(res["ex_location"]) + ","
                           + DB.Escape(res["ex_company"]) + ","
                           + DB.Escape(res["ex_currentUser"]) + ","
                           + DB.Escape(res["remark"]) + ","
                           + "'FA','GTN','USR');";
                }
                else
                {
                    _updateIsAvailable(res["code"], 2, false);
                    qryGTN ="INSERT INTO its_stock_trans (`trans_date`,`trans_code`,`serial_code`,`location_code`,`company_code`,`current_user`,`remark`,`stock_code`,`trans_type`,`from`)VALUES ("
                           + DB.Escape(data.Date) + ","
                           + DB.Escape(data.TransCode) + ","
                           + DB.Escape(res["code"]) + ","
                           + DB.Escape(res["ex_location"]) + ","
                           + DB.Escape(res["ex_company"]) + ","
                           + DB.Escape(res["ex_currentUser"]) + ","
                           + DB.Escape(res["remark"]) + ","
                           + "'EC','GTN','USR');";
                }


                a += DB.NonQuery(qryGTN);
                Log.write(qryGTN);

                string qryGRN = "";
                if (data.Stock_Type == "FA")
                {
                   var exData = GetDataFA(res["code"]);

                   qryGRN = "INSERT INTO its_stock_trans (`trans_date`,`trans_code`,`serial_code`,`ref_no`,`item_cat`,`item_name`,`value`,`location_code`,`company_code`,`current_user`,`desc`,`remark`,`stock_code`,`trans_type`,`from`,`is_available`)VALUES ("
                                     + DB.Escape(data.Date) + ","
                                     + DB.Escape(data.TransCode) + ","
                                     + DB.Escape(exData.Serial.Split('-')[1]) + ","
                                     + DB.Escape(res["ne_code"]) + ","
                                     + DB.Escape(exData.ItemCategory) + ","
                                     + DB.Escape(exData.Name) + ","
                                     + DB.Escape(exData.Price) + ","
                                     + DB.Escape(res["ne_location"]) + ","
                                     + DB.Escape(res["ne_company"]) + ","
                                     + DB.Escape(res["ne_currentUser"]) + ","
                                     + DB.Escape(exData.Description) + ","
                                     + DB.Escape(res["remark"]) + ","
                                     + "'FA','GRN','GTN','Y');";
                }
                else
                {
                    var exData = GetDataEC(res["code"]);
                    qryGRN = "INSERT INTO its_stock_trans (`trans_date`,`trans_code`,`serial_code`,`item_cat`,`brand`,`value`,`location_code`,`company_code`,`current_user`,`model`,`desc`,`remark`,`stock_code`,`trans_type`,`from`,`is_available`)VALUES ("
                                   + DB.Escape(data.Date) + ","
                                   + DB.Escape(data.TransCode) + ","
                                   + DB.Escape(res["code"]) + ","
                                   + DB.Escape(exData.ItemCategory) + ","
                                   + DB.Escape(exData.Brand) + ","
                                   + DB.Escape(exData.Price) + ","
                                   + DB.Escape(res["ne_location"]) + ","
                                   + DB.Escape(res["ne_company"]) + ","
                                   + DB.Escape(res["ne_currentUser"]) + ","
                                   + DB.Escape(exData.Model) + ","
                                   + DB.Escape(exData.Description) + ","
                                   + DB.Escape(res["remark"]) + ","
                                   + "'EC','GRN','GTN','Y');";
                }


                a += DB.NonQuery(qryGRN);
                Log.write(qryGRN);

                string qryGTNdetais = "INSERT INTO its_gtn_details (`trans_code`,`stock_code`,`ex_location`,`ex_company`,`ex_user`,`nw_location`,`nw_company`,`nw_user`,`ex_serial_code`,`nw_serial_code`,`remarks`)VALUE ("
                                     + DB.Escape(data.TransCode) + ","
                                     + DB.Escape(data.Stock_Type)+","
                                     + DB.Escape(res["ex_location"]) + ","
                                     + DB.Escape(res["ex_company"]) + ","
                                     + DB.Escape(res["ex_currentUser"]) + ","
                                     + DB.Escape(res["ne_location"]) + ","
                                     + DB.Escape(res["ne_company"]) + ","
                                     + DB.Escape(res["ne_currentUser"]) + ","
                                     + DB.Escape(res["code"]) + ","
                                     + DB.Escape(res["ne_code"]) + ","
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

        private void _updateIsAvailable(string code,int var1,bool st)
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

        public int Update(Entity.GTN _data)
        {

            return 0;
        }

        public bool NewCodeValidate(string code)
        {
            string qry = "SELECT ref_no FROM its_stock_trans WHERE ref_no =" + DB.Escape(code);
            var data = DB.Select(qry);
            if (data.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public
        FixtAssetData GetDataFA(string code)
        {
          return _fixtAssetGRN.getDataByAll(code, 2);
        }

        public 
        ECFieldData GetDataEC(string code)
        {
            return _elecDivice.getDataByAll(code,2);
        }

       
        public List<Dictionary<string,string>> getDataByCode(string code)
        {
             string qry = @"SELECT
                          `its_gtn_basic`.`trans_code`,
                          `its_gtn_basic`.`dDate`,
                          `its_gtn_basic`.`ref_no`,
                          `its_gtn_basic`.`desc`,
                          `its_gtn_details`.`stock_code`,
                          `its_gtn_details`.`ex_serial_code`,
                          `its_gtn_details`.`ex_location`,
                          `its_gtn_details`.`ex_company`,
                           CONCAT(GetEMP(`its_gtn_details`.`ex_user`),'-',`its_gtn_details`.`ex_user`) AS `ex_user`,
                          `its_gtn_details`.`qty`,
                          `its_gtn_details`.`nw_serial_code`,
                          `its_gtn_details`.`nw_location`,
                          `its_gtn_details`.`nw_company`,
                           CONCAT(GetEMP(`its_gtn_details`.`nw_user`),'-',`its_gtn_details`.`nw_user`) AS `nw_user`,
                          `its_gtn_details`.`remarks`
                        FROM `its_gtn_details`
                          INNER JOIN `its_gtn_basic`
                            ON (`its_gtn_details`.`trans_code` = `its_gtn_basic`.`trans_code`)
                              AND (`its_gtn_basic`.`stock_code` = `its_gtn_details`.`stock_code`)
                        WHERE (`its_gtn_basic`.`trans_code` = " + DB.Escape(code) + ") AND (`its_gtn_basic`.`stock_code` = 'FA' OR `its_gtn_basic`.`stock_code` = 'EC')";

            return DB.Select(qry);
        }

        private string _getPrivCode(string code)
        {
            string qry = "SELECT ex_serial_code FROM its_gtn_details WHERE trans_code="+DB.Escape(code);
            //DB.Where("trans_code", DB.Escape(code));
            //var data1 = DB.SelectAllFrom("its_gtn_details");
            var data =DB.Select(qry);
            return data[0]["ex_serial_code"];
        }
        public int Delete(string code,string type)
        {

            string qryBasic = "DELETE FROM its_gtn_basic WHERE trans_code=" + DB.Escape(code) + " AND (stock_code='FA' OR stock_code='EC')";
            string qryDetails = "DELETE FROM its_gtn_details WHERE trans_code=" + DB.Escape(code) + " AND (stock_code='FA' OR stock_code='EC')";
            string qryGTNTrans = "DELETE FROM its_stock_trans WHERE trans_code=" + DB.Escape(code) + " AND (stock_code='FA' OR stock_code='EC') AND trans_type='GTN'";
            string qryGRNTrans = "DELETE FROM its_stock_trans WHERE trans_code=" + DB.Escape(code) + " AND (stock_code='FA' OR stock_code='EC') AND trans_type='GRN' AND `from`='GTN'";

            DB.Start_Transaction();

            if (type == "FA")
            {
                _updateIsAvailable(_getPrivCode(code), 1, true);
            }
            else
            {
                _updateIsAvailable(_getPrivCode(code), 2, true);
            }
          

            int a = DB.NonQuery(qryBasic);
            a += DB.NonQuery(qryDetails);
            a += DB.NonQuery(qryGTNTrans);
            a += DB.NonQuery(qryGRNTrans);

           
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
