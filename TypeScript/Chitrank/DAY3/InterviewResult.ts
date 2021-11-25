import { Applications } from "./Applications";
export class InterviewResult {
    constructor(private x?:number) {
        
    }
    Applicant : Applications;
    Marks : number;
    isHired : boolean;

    StoreResult(arr:Applications,mark:number):void{
        this.Applicant=arr;
        this.Marks=mark;
        if(this.Marks>50)
        {
            this.isHired=true;
        }
        else{
            this.isHired=false;
        }
    }
    DisplayResult(){
        console.log(`Applicant ID : ${this.Applicant.ApplicationID} \nMarks : ${this.Marks} \nHired : ${this.isHired}`)
    }
}
