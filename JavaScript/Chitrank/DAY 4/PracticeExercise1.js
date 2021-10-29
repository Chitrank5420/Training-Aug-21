//Define a function called callback which receives an argument and prints the square of that number.


function square(a,callback){
    callback(a*a);
}
function ans(ans){
    console.log(ans)
}
square(4,ans)