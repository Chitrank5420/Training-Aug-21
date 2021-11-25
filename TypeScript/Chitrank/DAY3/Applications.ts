import { CreateVacancy, SearchVacancy } from "./Vacancy.js";

export class Applications {
    ApplicationID : number;
    Name : string;
    Age : number;
    Qualification : string;
    Experience : number;
    AppliedPostId : number;
    isValid : boolean;
    constructor(private x?:number,private y?:string,private z?:number,private a?:string,private b?:number,
        private c?:number,private d?:boolean) {
            this.ApplicationID=x;
            this.Name=y;
            this.Age=z;
            this.Qualification=a;
            this.Experience=b;
            this.AppliedPostId=c;
            this.isValid=d;
    }
    
    display(){
        console.log(`Applicant ID : ${this.ApplicationID} \nName : ${this.Name} \nAge : ${this.Age} \nQualification : ${this.Qualification} \nExperience : ${this.Experience} Years \nApplied Post Id : ${this.AppliedPostId}`);
    }
}

//function to Check All Vacancies
export function CheckVacancy(arr:Array<CreateVacancy>):void{
for(var i=0;i<arr.length;i++)
{
    arr[i].display();
}
}

//Function To check Applications
export function CheckApplications(arr:Array<Applications>):void{
for(var i=0;i<arr.length;i++)
{
    if(arr[i].isValid != false)
    {
        arr[i].display();
    }
    console.log("-------------------------------------------")
}
}

//Check Valid Applications
export function checkValidApplicants(arr:Array<Applications>,arr2:Array<CreateVacancy>):void{
    for(var i=0;i<arr.length;i++)
    {
        let temp = SearchVacancy(arr2,arr[i].AppliedPostId);
        if(temp ==0){
            arr[i].isValid = false;
        }
        else
        arr[i].isValid = true;
    } 
}

