// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;

Console.WriteLine("----------Water Bill----------");

//khai bao ham xu li ctrinh
void BillCalc()
{
    Console.WriteLine("Enter customer name: ");
    string cusomer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Select your customer type: ");
    Console.WriteLine("Enter 1 if you are Household customers");
    Console.WriteLine("Enter 2 if you are Administrative agency");
    Console.WriteLine("Enter 3 if you are Production unit");
    Console.WriteLine("Enter 4 if you are Business services");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        //khach hang ho gia dinh
        Console.WriteLine("Enter number of family member:");
        int MemberNum = Convert.ToInt32(Console.ReadLine());
        if (MemberNum >= 1)
        {
            Console.WriteLine("Enter this month number index");
            int waterNumbetThisMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter last month number index");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumbetThisMonth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumbetThisMonth - waterNumberLastMonth;
                double waterNumberPeople = waterNumber / MemberNum;
                double money = 0;
                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                     money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople >= 10 && waterNumberPeople <= 20)
                {
                     money = waterNumber * 7050 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumber <=30)
                {
                     money = waterNumber * 8699 * 1.1;
                }
                else
                {
                     money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine("This month water bill is :{0}", money);
            }
            else
            {
                Console.WriteLine("Last month's water index cannot be greater than this month's water index");
            }
        }
        else
        {
            Console.WriteLine("You are not Household customers");
        }
    }

    else if (typeCustomer == 2)
    {
        //khach hang co quan hanh chinh
        Console.WriteLine("Enetr this month water index : ");
        int waterThisMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter last month water index : ");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        if (waterThisMonth >= waterLastMonth)
        {
            int waterNumber = waterThisMonth - waterLastMonth;
            double m = waterNumber * 9955 * 1.1;
            Console.WriteLine("This month’s water meter readings : {0}", waterThisMonth);
            Console.WriteLine("Last month’s water meter readings : {0}", waterLastMonth);
            Console.WriteLine("This month consumption is : {0}", waterNumber);
            Console.WriteLine("This month water bill is : {0}", m);
        }
        else
            Console.WriteLine("Last month's water index cannot be greater than this month's water index");
    }

    else if (typeCustomer == 3)
    {
        //khach hang san xuat

        Console.WriteLine("Enter water this month index : ");
        int waterThisMonth = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter last month water index : ");
        int waterLastMonth = (Convert.ToInt32(Console.ReadLine()));
        if (waterThisMonth >= waterLastMonth)
        {
            int waterNumber= waterThisMonth - waterLastMonth;
            double money = waterNumber * 11.615 * 1.1;
            Console.WriteLine("This month’s water meter readings : {0}", waterThisMonth);
            Console.WriteLine("Last month’s water meter readings : {0}", waterLastMonth);
            Console.WriteLine("This month consumption is : {0}", waterNumber);
            Console.WriteLine("This month water bill is : {0}", money);
        }
        else 
            Console.WriteLine("Last month's water index cannot be greater than this month's water index");

    }
    else if (typeCustomer == 4) 
    {
         //khach hang kinh doanh

        Console.WriteLine("Enter this month water index : ");
        int waterThisMonth = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter last month water index : ");
        int waterLastMonth = (Convert.ToInt32(Console.ReadLine()));
        if (waterThisMonth >= waterLastMonth)
        {
            int waterNum = waterThisMonth - waterLastMonth;
            double money = waterNum * 22.068 * 1.1;
            Console.WriteLine("This month’s water meter readings : {0}", waterThisMonth);
            Console.WriteLine("Last month’s water meter readings : {0}", waterLastMonth);
            Console.WriteLine("This month consumption is : {0}", waterNum );
            Console.WriteLine("This month water bill is : {0}",money);
        }
        else
            Console.WriteLine("Last month's water index cannot be greater than this month's water index");

    }
    else
    {
        Console.WriteLine("Please enter correct type of customer");
    }
}
//chay ctrinh
BillCalc();