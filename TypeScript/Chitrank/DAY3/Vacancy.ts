export class  CreateVacancy {
    PostId:number;
    PostName:string;
    NoOfVacancy : number;
    constructor(private x?:number,private y?:string,private z?:number) {
        this.PostId=x;
        this.PostName=y;
        this.NoOfVacancy=z;
    }
    
    AddVacancy(a:number,b:string,c:number){
        this.PostId=a;
        this.PostName=b;
        this.NoOfVacancy=c;
    }

    display():void{
        //console.log("Current Openings : \n");
        //console.log("VacancyID \tVacancy Name \t\tNoOfPosts\n");
        //console.log(this.VacancyId + "\t\t" + this.VacancyName + "\t" + this.NoOfVacancy + "\n");
        console.log(`${this.PostId} \t ${this.PostName} \t\t ${this.NoOfVacancy} \n`);
    }
    
}

export function SearchVacancy(arr:Array<CreateVacancy>,id:number):number{
    var num:number =0;
    for(var i=0;i<arr.length;i++)
    {
        if(arr[i].PostId == id){
            num=1;
        }
    }
    if(num==1)
    {
        return 1;
    }
    else
    {
        return 0;
    }
    
    
    /*
    for(var i =0;i<arr.length;i++)
    {
        var temp :number = 0;
        if(arr[i].PostId==id){
            temp=1;
            return temp;
        }
        else
        {
            temp=0;
            return temp;
        }   
    }
    */
}



