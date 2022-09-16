public class ShopDetail{
    public int RegisterCost = 1000000;
    public string BranchName="Bangkhuntian Chaitalae";
    public string LocationName="Chaitalae Bangkhuntian road Soi 27";
    public string[] FounderName = {"Tawee Jaidee","Yuth Tungjairean","James Rukrian"};
    public string[] FounderID = {"153-698-4561237","742-112-5687412","541-772-3215689"};
    public string[] EmployeeType = {"ShopEmployee","DeliveryEmployee"};
    public string[] EmployeeName = {"Chaidee Rukdee","Nondee Jaidee","Apaidee Riandee", "Tumdee Gnandee", "Nondee Riebdee"};
    public int[] EmployeeAge = {20,18,22,25,23};
    public int[] EmployeeSalary = {15000,12500};
    public int TransportCostPerDay = 275;
    public double SaleSharePercent = 0.025;
    public int DeliveryCostPerDay = 150;
    public int[] ShopSaleCount = {26,27,35,50};
    public int[] DeliverySaleCount = {78,96,159,271};
    public int[] OutcomeShopSaleCount = {25,52,61,0,0};
    public int[] OutcomeDeliverySaleCount = {201,201,202,300,304};
    

    
    public void ShowShopDetail(){
        Console.WriteLine("Register Cost: "+ RegisterCost);
        Console.WriteLine("Branch Name: "+ BranchName);
        Console.WriteLine("Location Name: "+ LocationName);
    }
    public void ShowFounderDetail(){
        Console.WriteLine("Co-Founder");
        for(int i =0;i<3;i++){
            Console.WriteLine(FounderName[i]+" "+FounderID[i]);
        }
    }
    public void ShowEmployeeDetail(){
        Console.WriteLine("Employee");
        for(int i =0;i<5;i++){
            if(i<3){
                Console.WriteLine(EmployeeType[0]+" "+EmployeeName[i]+" Age:"+EmployeeAge[i]+" Salary:"+EmployeeSalary[0]);
            }else
            {
                Console.WriteLine(EmployeeType[1]+" "+EmployeeName[i]+" Age:"+EmployeeAge[i]+" Salary:"+EmployeeSalary[1]);
            }
        }
    }
    public void ShowInOutCome(){
        Console.WriteLine("Income-OutCome");
        Income();
        OutCome();
    }
    public void Income(){
        Console.WriteLine("Income");
        int TotalIncome = 0;
        for(int i =0;i<4;i++){
            Console.WriteLine("Week {0} | ShopSaleCount:{1} ={2} bath | DeliverySaleCount:{3} ={4} bath",i+1,ShopSaleCount[i],ShopSaleCount[i]*127,DeliverySaleCount[i],DeliverySaleCount[i]*357);
            TotalIncome+=ShopSaleCount[i]*127+DeliverySaleCount[i]*357;
        }
        Console.WriteLine("Total: {0}",TotalIncome);
    }
    public void OutCome(){
        Console.WriteLine("Outcome");
        for(int i =0;i<5;i++){
            if(i<3){
                Console.WriteLine("{0} | {1} | Salary:{2} | SaleShare:{3:F3} | TransportCost:{4} | DeliveryCost:{5}",EmployeeName[i],EmployeeType[0],EmployeeSalary[0],(127*SaleSharePercent*OutcomeShopSaleCount[i])+(357*SaleSharePercent*OutcomeDeliverySaleCount[i]),TransportCostPerDay*30,MonthTransportCost(EmployeeType[0],OutcomeDeliverySaleCount[i],DeliveryCostPerDay));
            }else
            {
                Console.WriteLine("{0} | {1} | Salary:{2} | SaleShare:{3:F3} | TransportCost:{4} | DeliveryCost:{5}",EmployeeName[i],EmployeeType[1],EmployeeSalary[1],(127*SaleSharePercent*OutcomeShopSaleCount[i])+(357*SaleSharePercent*OutcomeDeliverySaleCount[i]),TransportCostPerDay*30,MonthTransportCost(EmployeeType[1],OutcomeDeliverySaleCount[i],DeliveryCostPerDay));
            }           
        }
    }
    private int MonthTransportCost(string EmpType,int DelivCount,int DelivCost){
        if(EmpType=="DeliveryEmployee"){
            return DelivCount*DelivCost;
        }
        return 0;
    }
}