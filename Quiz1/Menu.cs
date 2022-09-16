public class Menu{
    public void ShowMenu(){
        Console.WriteLine("1.Shop Menu");
        Console.WriteLine("2.Shop Co-Founder");
        Console.WriteLine("3.Shop Employee");
        Console.WriteLine("4.Shop Income-Outcome");
    }
    public void SelectMenu(){
        ShopDetail Detail = new ShopDetail();
        string Selection = Console.ReadLine();
        switch (Selection)
        {
            case "1":
                Detail.ShowShopDetail();
                break;
            case "2":
                Detail.ShowFounderDetail();
                break;
            case "3":
                Detail.ShowEmployeeDetail();
                break;
            case "4":
                Detail.ShowInOutCome();
                break;
            default:
                Console.WriteLine("Please Select 1-4");
                break;
        }
    }
    
}