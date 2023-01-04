

//static void Calculate()
//{

//    CalculateService calculate = new CalculateService();
//    Console.WriteLine("add firt num:");
//    string number1 = Console.ReadLine();
//    int checkNum1;
//    bool isParseNum1 =int.TryParse(number1, out checkNum1);



//    if (isParseNum1)
//    {
//        Console.WriteLine("correct num");

//    }
//    else
//    {
//        Console.WriteLine("no");

//    }

//    Console.WriteLine("add operation");
//    string operation = Console.ReadLine();
//    Console.WriteLine("add second num:");

//    string number2 = Console.ReadLine();
//    int checkNum2 = int.Parse(Console.ReadLine());


//    bool isParseNum2 = int.TryParse(number2, out checkNum2);






//    if (isParseNum2)
//    {
//        Console.WriteLine("correct num");

//    }
//    else
//    {
//        Console.WriteLine("no");

//    }

//    var result  calculate.SumNumbers(checkNum1, checkNum2, operation);
//    Console.WriteLine(result);
//}


using DomainLayer.Models;

  









static Employees[] GetEmployes()
{
    Employees emp1 = new Employees
    {
        Name = "Ali",
        Surname = "Alizade",
        Brithday= new DateTime(1999,10,05),
        Salary =2020



    };

    Employees emp2 = new Employees
    {


        Name = "Aydani",
        Surname = "Misgerli",
        Brithday = new DateTime(1996, 09, 07),
        Salary =1000



    };

    Employees emp3 = new Employees
    {

        Name= "Anar",
        Surname = "Alizade",
        Brithday = new DateTime(2000, 11, 10),
        Salary=1500


    };

    Employees[] employees= new Employees [] { emp1, emp2, emp3 };



    foreach (var item in employees)
    {
        item.Salary = 2000;
           Console.WriteLine(item.Salary);
    }
    return employees;


}



// 0,1,1,2,3,5,8,13,21,34

int next = 0;
int prev = 0;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(next);
    if (next == 0)
    {
        next = 1;

    }
    else
    {
        int temp = next;
        next = next + prev;
        prev = temp;


    }
    Console.ReadLine() ;


}















