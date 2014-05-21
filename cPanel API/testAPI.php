<?php
 //$var=Email::addpop('stest','stesthec12','hairuec.com');
 //print_r($var);
include 'xmlapi.php';

$xip = "50.87.102.208";                // should be server IP address or 127.0.0.1 if local server
$account = "hairuec1";            // cPanel user account name
$passwd ="#@1&U3c1";            // cPanel user password
$port =2083;                    // cpanel secure authentication port
$email_domain = 'hairuec.com';   // email domain (usually same as cPanel domain)
$email_quota = 50; 
$email_user ="xxxtest";               // default amount of space in megabytes +
$email_pass ="TxtestHec12";

$xmlapi = new xmlapi($xip);

//set port number. cpanel client class allow you to access WHM as well using WHM port.
$xmlapi->set_port($port);                        

// authorization with password. Not as secure as hash.
$xmlapi->password_auth($account, $passwd);   

// cpanel email addpop function Parameters
$call = array(domain=>$email_domain, email=>$email_user,password=>$email_pass, quota=>$email_quota);

// cpanel email fwdopt function Parameters
//$call_f  = array(domain=>$email_domain, email=>$email_user,
//fwdopt=>"fwd", fwdemail=>$dest_email);

//output to error file  set to 1 to see
$xmlapi->set_debug(0);      
//error_log.

// making call to cpanel api
$result = $xmlapi->api2_query($account, "Email", "addpop",$call);
print_r($result);

//create a forward
//$result_forward = $xmlapi->api2_query($account, "Email", "addforward",
//$call_f);  
?>