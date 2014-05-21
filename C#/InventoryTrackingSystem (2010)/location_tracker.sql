SELECT
      `its_stock_trans`.`item_name`
    , `its_stock_trans`.`qty`
    , `its_stock_trans`.`serial_code`
    , `its_stock_trans`.`ref_no`
    , `its_employee`.`emp_name`
    , `its_company`.`company_name`
    , `its_location`.`location_name`
    , `its_item_category`.`cat_name`
    , `its_stock_trans`.`location_code`
FROM
    `hec_its`.`its_stock_trans`
    INNER JOIN `hec_its`.`its_location` 
        ON (`its_stock_trans`.`location_code` = `its_location`.`location_code`)
    INNER JOIN `hec_its`.`its_employee` 
        ON (`its_stock_trans`.`current_user` = `its_employee`.`emp_code`)
    INNER JOIN `hec_its`.`its_item_category` 
        ON (`its_stock_trans`.`item_cat` = `its_item_category`.`cat_code`)
    INNER JOIN `hec_its`.`its_company` 
        ON (`its_stock_trans`.`company_code` = `its_company`.`company_code`)
WHERE (`its_stock_trans`.`location_code` ="FD");