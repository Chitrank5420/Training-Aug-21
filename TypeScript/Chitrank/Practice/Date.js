var date0 = new Date();
console.log("Date = " + date); //Date = Tue Feb 05 2019 12:05:22 GMT+0530 (IST)  
var date2 = new Date("2019-01-16");
console.log("Date = " + date2); //Date = Wed Jan 16 2019 05:30:00 GMT+0530 (IST)  
var date3 = new Date(2018, 5, 5, 17, 23, 42, 11);
console.log("Date = " + date3); //Date = Tue Jun 05 2018 17:23:42 GMT+0530 (IST)  
var date1 = new Date(2017, 4, 4, 17, 23, 42, 11);
date1.setDate(13);
date1.setMonth(13);
date1.setFullYear(2013);
date1.setHours(13);
date1.setMinutes(13);
date1.setSeconds(13);
console.log("Year = " + date1.getFullYear());
console.log("Date = " + date1.getDate());
console.log("Month = " + date1.getMonth());
console.log("Day = " + date1.getDay());
console.log("Hours = " + date1.getHours());
console.log("Minutes = " + date1.getMinutes());
console.log("Seconds = " + date1.getSeconds());
