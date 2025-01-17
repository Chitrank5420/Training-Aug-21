"use strict";
exports.__esModule = true;
exports.Restaurants = void 0;
//Typescript Practical Test.
/*
Online table reservation in the restaurant for specific date and time. This will
Provide the list of restaurants in the country so that the user can choose accordingly.
Provide the list of tables available for online reservation at different dining rooms in the restaurant.
Mention the number of guests that can be accommodated on the particular table.
Accept the booking for tables.
Online table reservations are done 6hrs in advance for the current date.
Table reservation can be done up to one month in advance.
Give a token number to the customer as an acknowledgement of booking.
*/
var Table_js_1 = require("./Table.js");
var Restaurants = /** @class */ (function () {
    function Restaurants(resid, resname, notables, ftype, table) {
        this.RestaurantId = resid;
        this.RestName = resname;
        this.NoOfTables = notables;
        this.FoodType = ftype;
        this.Table = table;
    }
    Restaurants.prototype.GetDetails = function () {
        console.log("".concat(this.RestaurantId, " \t\t").concat(this.RestName, " \t\t").concat(this.NoOfTables, "  \t\t").concat(this.FoodType));
    };
    return Restaurants;
}());
exports.Restaurants = Restaurants;
//Gives Restaurants list in the country
function GetRestaurants(restaurant) {
    console.log("Restaurant ID \tRestaurant Name \tTotal Tables \tFood Type\n");
    for (var _i = 0, restaurant_1 = restaurant; _i < restaurant_1.length; _i++) {
        var res = restaurant_1[_i];
        res.GetDetails();
    }
}
//Give Individual Restaurant Details with table availability
function GetRestaurantDetails(res) {
    console.log("\n");
    console.log("Restaurant Name \tFood Type");
    console.log("".concat(res.RestName, " \t\t").concat(res.FoodType));
    console.log("\n");
    console.log("Tables Details : \n");
    console.log("Table Id \tGuest Capacity");
    if (res.Table.IsBooked != true) {
        console.log("".concat(res.Table.TableId, " \t\t").concat(res.Table.GuestCapacity));
    }
}
//To Book Table
function BookTable(res, tabid, date) {
    var currdate = new Date();
    var bookid = 1;
    if (res.Table.IsBooked == true) {
        console.log("Table Already Booked");
        return;
    }
    else if ((currdate.getMonth() - date.getMonth()) >= 1) {
        console.log("Too advance to book");
        return;
    }
    else if (((currdate.getDay() == date.getDay()) && ((currdate.getHours() - date.getHours()) < 6))) {
        console.log("Too late to book");
    }
    else {
        console.log("Table booked\n");
        console.log("Your Booking Details : ");
        console.log("Booking Id : ".concat(bookid++));
        console.log("Booking Date : ".concat(date));
        console.log("Restaurant Name : ".concat(res.RestName));
        console.log("Table Id : ".concat(tabid));
        return;
    }
}
var tabl = new Table_js_1.Table(1, 4, false);
var res = [new Restaurants(1, "Shiv Foods", 3, "Indian", tabl)];
GetRestaurants(res);
GetRestaurantDetails(res[0]);
BookTable(res[0], 1, new Date(2021, 11, 28, 13, 0, 0));
