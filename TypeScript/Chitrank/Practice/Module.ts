export class Addition{
    constructor(private x?:number,private y?:number){}
    Sum(){
        console.log("Sum : " + (this.x+this.y));
    }
}

export class Subtraction{
    constructor(private a?:number,private b?:number){}
    Subtraction(){
        console.log("Subtraction : " + (this.a - this.b));
    }

}