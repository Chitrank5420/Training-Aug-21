//Numeric Based Enums
enum Direction {  
    Up=1,  
    Down=3,  
    Left=6,  
    Right=10,  
}  
console.log(Direction);


enum AppStatus {  
    ACTIVE,  
    INACTIVE,  
    ONHOLD  
}   
function checkStatus(status: AppStatus): void {  
    console.log(status);  
}  
checkStatus(AppStatus.ONHOLD);  


//String Based Enums
enum AppStatus {  
    ACTIVE2 = 'ACT',  
    INACTIVE2 = 'INACT',  
    ONHOLD2 = 'HLD',  
    ONSTOP = 'STOP'  
}  
function checkStatus2(status: AppStatus): void {  
   
    console.log(status);  
}  
checkStatus2(AppStatus.ONSTOP);




