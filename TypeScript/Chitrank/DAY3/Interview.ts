import { CreateVacancy } from "./Vacancy.js";
import { Applications, CheckApplications, CheckVacancy, checkValidApplicants } from "./Applications.js";

export class ScheduleInterview {
    
    constructor(private x?:number) {
        
    }
    Applicant: Applications;
    InterviewDate : Date;
    InterviewerName : string;
    ScheduleInterview(arr:Applications,dt:Date,iname:string):void
    {
        this.Applicant = arr;
        this.InterviewDate=dt;
        this.InterviewerName=iname;
    }
    DisplayInterviewDetails():void{
        console.log(`ApplicantId : ${this.Applicant.ApplicationID} \nApplicant Name : ${this.Applicant.Name} \nInterview Date : ${this.InterviewDate} \nInterviewerName : ${this.InterviewerName}\n`)
    }
    
}


