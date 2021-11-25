"use strict";
exports.__esModule = true;
exports.checkValidApplicants = exports.CheckApplications = exports.CheckVacancy = exports.Applications = void 0;
var Vacancy_js_1 = require("./Vacancy.js");
var Applications = /** @class */ (function () {
    function Applications(x, y, z, a, b, c, d) {
        this.x = x;
        this.y = y;
        this.z = z;
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.ApplicationID = x;
        this.Name = y;
        this.Age = z;
        this.Qualification = a;
        this.Experience = b;
        this.AppliedPostId = c;
        this.isValid = d;
    }
    Applications.prototype.display = function () {
        console.log("Applicant ID : ".concat(this.ApplicationID, " \nName : ").concat(this.Name, " \nAge : ").concat(this.Age, " \nQualification : ").concat(this.Qualification, " \nExperience : ").concat(this.Experience, " Years \nApplied Post Id : ").concat(this.AppliedPostId, " \nIsValid : ").concat(this.isValid, " \n"));
    };
    return Applications;
}());
exports.Applications = Applications;
//function to Check All Vacancies
function CheckVacancy(arr) {
    for (var i = 0; i < arr.length; i++) {
        arr[i].display();
    }
}
exports.CheckVacancy = CheckVacancy;
//Function To check Applications
function CheckApplications(arr) {
    for (var i = 0; i < arr.length; i++) {
        if (arr[i].isValid != false) {
            arr[i].display();
        }
        console.log("-------------------------------------------");
    }
}
exports.CheckApplications = CheckApplications;
//Check Valid Applications
function checkValidApplicants(arr, arr2) {
    for (var i = 0; i < arr.length; i++) {
        var temp = (0, Vacancy_js_1.SearchVacancy)(arr2, arr[i].AppliedPostId);
        if (temp == 0) {
            arr[i].isValid = false;
        }
        else
            arr[i].isValid = true;
    }
}
exports.checkValidApplicants = checkValidApplicants;
