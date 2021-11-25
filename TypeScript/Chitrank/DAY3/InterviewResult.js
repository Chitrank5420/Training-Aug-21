"use strict";
exports.__esModule = true;
exports.InterviewResult = void 0;
var InterviewResult = /** @class */ (function () {
    function InterviewResult(x) {
        this.x = x;
    }
    InterviewResult.prototype.StoreResult = function (arr, mark) {
        this.Applicant = arr;
        this.Marks = mark;
        if (this.Marks > 50) {
            this.isHired = true;
        }
        else {
            this.isHired = false;
        }
    };
    InterviewResult.prototype.DisplayResult = function () {
        console.log("Applicant ID : ".concat(this.Applicant.ApplicationID, " \nMarks : ").concat(this.Marks, " \nHired : ").concat(this.isHired));
    };
    return InterviewResult;
}());
exports.InterviewResult = InterviewResult;
