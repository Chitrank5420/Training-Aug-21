"use strict";
exports.__esModule = true;
exports.ScheduleInterview = void 0;
var ScheduleInterview = /** @class */ (function () {
    function ScheduleInterview(x) {
        this.x = x;
    }
    ScheduleInterview.prototype.ScheduleInterview = function (arr, dt, iname) {
        this.Applicant = arr;
        this.InterviewDate = dt;
        this.InterviewerName = iname;
    };
    ScheduleInterview.prototype.DisplayInterviewDetails = function () {
        console.log("ApplicantId : ".concat(this.Applicant.ApplicationID, " \nApplicant Name : ").concat(this.Applicant.Name, " \nInterview Date : ").concat(this.InterviewDate, " \nInterviewerName : ").concat(this.InterviewerName, "\n"));
    };
    return ScheduleInterview;
}());
exports.ScheduleInterview = ScheduleInterview;
