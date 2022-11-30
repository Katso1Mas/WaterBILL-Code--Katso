using Assign_Katso;
using System.Net.Http.Headers;

internal class WaterBill
{
    string FirstName;
    string LastName;
    string PlotNumber;
    string Location;
    string UserType;
    double AmountOfWater;
    string UserName;
    string Password;
    double PotableCost;
    double WasteCost;
    double TotalCost;
    //instance variables that make up the objects

    WaterBill()
    {
        FirstName = "NoName";
        LastName = "NoLastName";
        PlotNumber = "Plot0000";
        Location = "Botswana";
        UserType = "None";
        AmountOfWater = 0;
        UserName = "***";
        Password = "***";
        //constructor-issues default values 
    }

    static void Main()
    {
        string[] UserName = new string[1];
        string[] Password = new string[1];
        Console.WriteLine("Create New UserName");
        UserName[0] = Console.ReadLine();
        Console.WriteLine("Create New Password");
        Password[0] = Console.ReadLine();
        Console.Clear();

        WaterBill Customer1 = new WaterBill();
        //creating a new object in class of waterbill
        //string MyUserName = "***";
        //string MyPassword = "***";
        string UserLogin;
        string UserPass;


        //declare variable

        // Customer1.UserName = MyUserName;
        // Customer1.Password = MyPassword;
                
        Console.WriteLine("ENTER UserName");
        UserLogin = Console.ReadLine();
        Console.WriteLine("ENTER Password");
        UserPass = Console.ReadLine();
        Console.Clear();

        if (UserLogin == UserName[0] && UserPass == Password[0])
        {
            //to create login instance 
           
            var Date=DateTime.Now;
            File.AppendAllText("Login Instance.txt", "Login Success " + Date + Environment.NewLine);

            Console.WriteLine("Valid!");

            Console.WriteLine("ENTER FirstName");
            Customer1.FirstName = Console.ReadLine();
            Console.WriteLine("ENTER LastName");
            Customer1.LastName = Console.ReadLine();
            Console.WriteLine("ENTER PlotNumber");
            Customer1.PlotNumber = Console.ReadLine();
            Console.WriteLine("ENTER Location");
            Customer1.Location = Console.ReadLine();
            Console.WriteLine("ENTER AmountOfWater");
            Customer1.AmountOfWater = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENTER UserType");
            Customer1.UserType = Console.ReadLine();

            if (Customer1.UserType == "Domestic" )
            {
               
                DOMESTICCalculation dOMESTICCalculation = new DOMESTICCalculation();
                Customer1.PotableCost = dOMESTICCalculation.PotablePriceOfWater(Customer1.AmountOfWater);
                Customer1.WasteCost = dOMESTICCalculation.WastePriceOfWater(Customer1.AmountOfWater);
                Customer1.TotalCost = dOMESTICCalculation.DOMESTICTotalPriceOfWater(Customer1.AmountOfWater);
            }
            else if (Customer1.UserType == "Commercial")
            {
                 
                 COMMERCIALCalculation calculationsCOMMERCIAL = new COMMERCIALCalculation();
                 Customer1.PotableCost = calculationsCOMMERCIAL.PotablePriceOfWater(Customer1.AmountOfWater);
                 Customer1.WasteCost = calculationsCOMMERCIAL.WastePriceOfWater(Customer1.AmountOfWater);
                 Customer1.TotalCost = calculationsCOMMERCIAL.COMMERCIALTotalPriceOfWater(Customer1.AmountOfWater);



            }
            else
            {
                Console.WriteLine("Invalid UserType");
            }
           
            Console.Read();
            Console.Clear();
            Console.WriteLine("Customer Name:"+Customer1.FirstName+" "+Customer1.LastName);
            Console.WriteLine("Location:" + Customer1.Location);
            Console.WriteLine("Plot Number:"+ Customer1.PlotNumber);
            Console.WriteLine("Amount of Water:" + Customer1.AmountOfWater+ "KL");
            Console.WriteLine("Potable Water Cost: P"+ Math.Round(Customer1.PotableCost,2));
            Console.WriteLine("Wastewater Cost: P"+ Math.Round( Customer1.WasteCost,2));
            Console.WriteLine("Total Cost: P"+ Math.Round(Customer1.TotalCost,2));



            //sytem will promt user to enter details after validation of Login

            StreamWriter WaterBillPrint = new StreamWriter("CustomerBill.txt");
            WaterBillPrint.WriteLine("Customer Name:" + Customer1.FirstName + " " + Customer1.LastName);
            WaterBillPrint.WriteLine("Location:" + Customer1.Location);
            WaterBillPrint.WriteLine("Plot Number:" + Customer1.PlotNumber);
            WaterBillPrint.WriteLine("Amount of Water:" + Customer1.AmountOfWater);
            WaterBillPrint.WriteLine("Potable Water Cost:" + Customer1.PotableCost);
            WaterBillPrint.WriteLine("Wastewater Cost:" + Customer1.WasteCost);
            WaterBillPrint.WriteLine("Total Cost:" + Customer1.TotalCost);
            WaterBillPrint.Close();

            StreamWriter ReportPrint = new StreamWriter("CustomerReport.txt");
            ReportPrint.WriteLine("Customer Name:" + Customer1.FirstName + " " + Customer1.LastName);
            ReportPrint.WriteLine("Amount of Water:" + Customer1.AmountOfWater);
            ReportPrint.WriteLine("Total Cost:" + Customer1.TotalCost);
            ReportPrint.Close();

        }
        else
        {
            //to create login instance 

            var Date = DateTime.Now;
            File.AppendAllText("Login Instance.txt", "Login Failed " + Date + Environment.NewLine);


            Console.WriteLine("Invalid!");

        }







    }
}








 
    
    
       



