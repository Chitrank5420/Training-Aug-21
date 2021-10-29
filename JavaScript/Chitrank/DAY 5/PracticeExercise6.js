//Explain Function closure with practical

function x() {
    var a = 15;
    function y() {
        console.log(a);
    }
    y();
}
x();