"use strict";
exports.__esModule = true;
var Vacancy_1 = require("./Vacancy");
var Applications_1 = require("./Applications");
var Interview_1 = require("./Interview");
var InterviewResult_1 = require("./InterviewResult");
var Report = /** @class */ (function () {
    function Report(x) {
        this.x = x;
    }
    Report.prototype.CreateReport = function (a, b, c, d) {
        console.log("Application Id : ".concat(a.ApplicationID, " \nApplicant Name : ").concat(a.Name, " \nApplied For: ").concat(b.PostName, " \nInterview Date : ").concat(c.InterviewDate, " \nInterviewer Name : ").concat(c.InterviewerName, " \nInterview Result : ").concat(d.Marks, " \nIs Hired : ").concat(d.isHired));
    };
    return Report;
}());
//Create Vacancies
var vacObject = [new Vacancy_1.CreateVacancy(1, "Software Developer", 20),
    new Vacancy_1.CreateVacancy(2, "Database Engineer", 5),
    new Vacancy_1.CreateVacancy(3, "QA Analyst", 3),
    new Vacancy_1.CreateVacancy(4, "System Engineer", 3)];
//Create Applications
var myApplication = [new Applications_1.Applications(1001, "Chitrank", 21, "B.E.", 0, 4),
    new Applications_1.Applications(1002, "Harsh", 21, "B.E.", 1, 2),
    new Applications_1.Applications(1003, "Deep", 21, "B.E.", 1, 1),
    new Applications_1.Applications(1004, "Shreya", 21, "B.E.", 1, 3),
    new Applications_1.Applications(1005, "Kruti", 21, "B.E.", 1, 5)];
//Check All Vacancies
console.log("\nCheck All vacancies : \n");
(0, Applications_1.CheckVacancy)(vacObject);
console.log("-----------------------------------\n");
//Check Valid Applications
(0, Applications_1.checkValidApplicants)(myApplication, vacObject);
//Check All Applications
console.log("Check All Applications :\n");
(0, Applications_1.CheckApplications)(myApplication);
//Schedule Interview
var setInterview = new Interview_1.ScheduleInterview();
//ScheduleInterview(application,date,interviewername);
setInterview.ScheduleInterview(myApplication[0], new Date(2021, 8, 2, 10, 0, 0), "Mayur Patel");
//Interview Result
var ir = new InterviewResult_1.InterviewResult();
//StoreResult(application,marks)
ir.StoreResult(myApplication[0], 60);
//Final Report
console.log("Final Report : \n");
var rep = new Report();
rep.CreateReport(myApplication[0], vacObject[((myApplication[0].AppliedPostId) - 1)], setInterview, ir);
