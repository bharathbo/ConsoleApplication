using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");

            string a = Console.ReadLine();
            Console.WriteLine("welcome to sharp,"+a+ "please select operation\n");
            
            while(true){
                try{
                    Console.WriteLine("Select op");

                    Console.WriteLine("1. Add");
                    Console.WriteLine("1. SUB");

                    Console.WriteLine("1. MULti");

                    Console.WriteLine("1. Div");

                    Console.Write("eneter your choice");
                    int choice =int.Parse(Console.ReadLine());

                    if (choice<1||choice>4){
                        Console.WriteLine("invalid");
                        continue;}
                    
                    Console.Write("enter value1;");
                    int value1=int.Parse(Console.ReadLine());
                    Console.Write("enter value2;");
                    int value2=int.Parse(Console.ReadLine());

                    using (ServiceReference1.Service1SoapClient client = new ServiceReference1.Service1SoapClient())
                    {
                        int result=0;

                        switch(choice){
                        case 1:
                        result= client.Add(value1,value2);
                        break;

                        case 2:
                                result=client.Subtract(value1,value2);

                                break;
                                case 3:
                                result=client.Subtract(value1,value2);

                                break;
                            case 4:
                                if(value2==0){
                                    Console.WriteLine("divide by zero error");
                                }
                                result=client.Subtract(value1,value2);

                                break;
                    }
                        Console.WriteLine("Result"+ result);

                    }}
                        catch(Exception ex)
                {
                            Console.WriteLine("error occured");
                        }


        
     
}
    }}
    
}

