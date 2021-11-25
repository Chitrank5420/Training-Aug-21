"use strict";
exports.__esModule = true;
exports.SearchVacancy = exports.CreateVacancy = void 0;
var CreateVacancy = /** @class */ (function () {
    function CreateVacancy(x, y, z) {
        this.x = x;
        this.y = y;
        this.z = z;
        this.PostId = x;
        this.PostName = y;
        this.NoOfVacancy = z;
    }
    CreateVacancy.prototype.AddVacancy = function (a, b, c) {
        this.PostId = a;
        this.PostName = b;
        this.NoOfVacancy = c;
    };
    CreateVacancy.prototype.display = function () {
        //console.log("Current Openings : \n");
        //console.log("VacancyID \tVacancy Name \t\tNoOfPosts\n");
        //console.log(this.VacancyId + "\t\t" + this.VacancyName + "\t" + this.NoOfVacancy + "\n");
        console.log("".concat(this.PostId, " \t ").concat(this.PostName, " \t\t ").concat(this.NoOfVacancy, " \n"));
    };
    return CreateVacancy;
}());
exports.CreateVacancy = CreateVacancy;
function SearchVacancy(arr, id) {
    var num = 0;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i].PostId == id) {
            num = 1;
        }
    }
    if (num == 1) {
        return 1;
    }
    else {
        return 0;
    }
    /*
    for(var i =0;i<arr.length;i++)
    {
        var temp :number = 0;
        if(arr[i].PostId==id){
            temp=1;
            return temp;
        }
        else
        {
            temp=0;
            return temp;
        }
    }
    */
}
exports.SearchVacancy = SearchVacancy;
