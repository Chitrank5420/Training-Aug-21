"use strict";
exports.__esModule = true;
exports.Subtraction = exports.Addition = void 0;
var Addition = /** @class */ (function () {
    function Addition(x, y) {
        this.x = x;
        this.y = y;
    }
    Addition.prototype.Sum = function () {
        console.log("Sum : " + (this.x + this.y));
    };
    return Addition;
}());
exports.Addition = Addition;
var Subtraction = /** @class */ (function () {
    function Subtraction(a, b) {
        this.a = a;
        this.b = b;
    }
    Subtraction.prototype.Subtraction = function () {
        console.log("Subtraction : " + (this.a - this.b));
    };
    return Subtraction;
}());
exports.Subtraction = Subtraction;
