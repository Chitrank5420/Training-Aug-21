import { CreateVacancy } from "./Vacancy";
import { Applications, CheckApplications, CheckVacancy, checkValidApplicants } from "./Applications";
import { ScheduleInterview } from "./Interview";
import { InterviewResult } from "./InterviewResult";

class Report {
    constructor(private x?:number) {
        
    }
    CreateReport(a:Applications,b:CreateVacancy,c:ScheduleInterview,d:InterviewResult):void{
        console.log(`Application Id : ${a.ApplicationID} \nApplicant Name : ${a.Name} \nApplied For: ${b.PostName} \nInterview Date : ${c.InterviewDate} \nInterviewer Name : ${c.InterviewerName} \nInterview Result : ${d.Marks} \nIs Hired : ${d.isHired}`);
    }
}
//Create Vacancies
let vacObject : Array<CreateVacancy> = [new CreateVacancy(1,"Software Developer",20),
new CreateVacancy(2,"Database Engineer",5),
new CreateVacancy(3,"QA Analyst",3),
new CreateVacancy(4,"System Engineer",3)];

//Create Applications
let myApplication : Array<Applications> = [new Applications(1001,"Chitrank",21,"B.E.",0,4),
new Applications(1002,"Harsh",21,"B.E.",1,2),
new Applications(1003,"Deep",21,"B.E.",1,1),
new Applications(1004,"Shreya",21,"B.E.",1,3),
new Applications(1005,"Kruti",21,"B.E.",1,5)];


//Check All Vacancies
console.log("\nCheck All vacancies : \n")
CheckVacancy(vacObject);
console.log("-----------------------------------\n");

//Check Valid Applications
checkValidApplicants(myApplication,vacObject);

//Check All Applications
console.log("Check All Applications :\n")
CheckApplications(myApplication);

//Schedule Interview
let setInterview = new ScheduleInterview();

//ScheduleInterview(application,date,interviewername);
setInterview.ScheduleInterview(myApplication[0],new Date(2021,8,2,10,0,0),"Mayur Patel");


//Interview Result
let ir = new InterviewResult();

//StoreResult(application,marks)
ir.StoreResult(myApplication[0],60);


//Final Report
console.log("Final Report : \n");
let rep = new Report();
rep.CreateReport(myApplication[0],vacObject[((myApplication[0].AppliedPostId)-1)],setInterview,ir);