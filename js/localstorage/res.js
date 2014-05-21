$.jStorage.set("d1","sds/ad,ada/sd,dasd/as,dwq/re");



var _a=$.jStorage.get("d1");

var x=_a.split(",");

x
Result :
["sds/ad", "ada/sd", "dasd/as", "dwq/re"]

$.each(x,function(i,a){
	console.log(a);
})
Result :
sds/ad 
ada/sd 
dasd/as 
dwq/re 

$.each(x,function(i,a){
	console.log(a.split("/"));
})
Result :
["sds", "ad"] 
["ada", "sd"] 
["dasd", "as"] 
["dwq", "re"] 


$.each(x,function(i,a){
	console.log((a.split("/"))[0]);
})
Result :
sds 
ada 
dasd 
dwq 

$.each(x,function(i,a){
	console.log((a.split("/"))[1]);
})
Result :
ad 
sd
as 
re 
