// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, \tWorld! ");
//Console.WriteLine("Hello, \nWorld!");


/*
int a = 12;
string b = "Mohib";
char c = 'k';
bool d = false;
int k = a;

int result = a + k;


Console.WriteLine(a);
Console.WriteLine("Hello! " + b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(b + k);
Console.WriteLine(result);

Console.WriteLine($"Hello {b} (1,2,4,6)");



var abc = true;
Console.WriteLine(abc);


int i = 2;
int j = 5;

Console.WriteLine(i+ " " + j);




Console.WriteLine(j - i);
Console.WriteLine(i * j);
Console.WriteLine(i / j);
Console.WriteLine(i % j);
i--;
Console.WriteLine(i);
Console.WriteLine(++i);
Console.WriteLine(--i);
Console.WriteLine(--i);
Console.WriteLine(--i);

*/


/*

var cda = 32;


Console.WriteLine(cda);

double pi = 3.14546456455;

pi = 45.3434;





Console.WriteLine(pi);

string a = "34234";
int b = 53452435;
string c = "true";

Console.WriteLine(Convert.ToInt32(a).GetType());
Console.WriteLine(Convert.ToString(b) + " " + Convert.ToString(b).GetType());
Console.WriteLine(Convert.ToBoolean(c) + " " + Convert.ToBoolean(c).GetType());

*/

// Math Class and Methods


/*
int num1 = 230;
int num2 = 2;

Console.WriteLine(Math.Pow(num1,num2));
Console.WriteLine(Math.Pow(10,3));
Console.WriteLine(Math.Abs(-560));
Console.WriteLine(Math.Round(2.7));
Console.WriteLine(Math.Ceiling(2.4));
Console.WriteLine(Math.Floor(2.9));
Console.WriteLine(Math.Max(20,30));
Console.WriteLine(Math.Min(20,30));
Console.WriteLine(Math.Sqrt(4444));

*/


//Random random = new Random();

//Console.WriteLine(random.Next(1,7));
//Console.WriteLine(Math.Round(random.NextDouble() * 100 + 1));


/*

string str = "This is string Paragraph";

Console.WriteLine(str.ToUpper());
Console.WriteLine(str.ToLower());
Console.WriteLine(str.Length);
Console.WriteLine(str.Insert(24,"!"));
Console.WriteLine(str.Replace("This","That"));
Console.WriteLine(str.Substring(0,14));

*/

/*
int age = 18;

if (age < 18)
{
    Console.WriteLine("You can't see me!");
}
else if(age > 18)
{
    Console.WriteLine("You can see me!");
}
else
{
    Console.WriteLine("You are not alive");
}
*/


// Try and Catch with Switch Statement

/*
try
{

Console.WriteLine("Enter your Day: ");
int days = Convert.ToInt32(Console.ReadLine());
    switch (days)
    {
        case 1:
            Console.WriteLine("Today is Monday");
            break;

        case 2:
            Console.WriteLine("Today is Tuesday");
            break;

        case 3:
            Console.WriteLine("Today is Wednesday");
            break;

        case 4:
            Console.WriteLine("Today is Thursday");
            break;

        case 5:
            Console.WriteLine("Today is Friday");
            break;
        case 6:
            Console.WriteLine("Today is Saturday");
            break;
        case 7:
            Console.WriteLine("Today is Sunday");
            Console.WriteLine("Its off day 🎉🎉🎉🎉👍😁😂🤣");
            break;
        default:
            Console.WriteLine("Kindly Enter single digit value between 1 to 7");
            break;

    }

}
catch (FormatException)
{
    Console.WriteLine("Kindly Enter Integer Value");
}


*/



/*
int dirverAge = 450;

if (dirverAge >= 18 && dirverAge <= 50)
{
    Console.WriteLine("You Eligible for driving!");
}

else
{
    Console.WriteLine("You are not Eligible");
}


if (dirverAge >= 18 || dirverAge <= 50)
{
    Console.WriteLine("You Eligible for driving!");
}

else
{
    Console.WriteLine("You are not Eligible");
}
*/

/*

Console.WriteLine("Kindly Enter your Name");
string userInput = Console.ReadLine();

while (userInput == "")
{
    Console.WriteLine("Kindly Enter your Name");
    userInput = Console.ReadLine();
}

Console.WriteLine($"Hello! {userInput}");
*/

/*
int a = 20;

while (a >= 2)
{
    Console.WriteLine(a);
    a-=2;
}
*/


//int a = 1;

//do
//{
//    Console.WriteLine(a);
//    a++;
//}
//while (a < 20);




//for(int i =0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}



//for(int i=0; i < 5; i++)
//{
//    for(int j=0; j < 5; j++)
//    {
//        Console.WriteLine($"{i} - {j}"); 
//    }
//}



//int[] numbers = new int[2];



//int[] numbers = { 1, 2, 4, 6, 7, 9 };


//Console.WriteLine(numbers);


//foreach (var (index, item) in numbers.Select((item, index) => (index, item)))
//{
//    Console.WriteLine($"{index} - {item}");
//}

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}



//int[,] numbers1 = { { 1, 2, 4 }, { 6, 7, 9 } };


//foreach(int number1 in numbers1)
//{
//    Console.WriteLine(number1);
//}




//List<string> movies = new List<string>();

//movies.Add("A");
//movies.Add("B");
//movies.Add("C");
//movies.Add("D");
//movies.Add("E");
//movies.Add("F");
//movies.Add("G");
//movies.Add("H");
//movies.Add("H");
//movies.Add("Moon Light");



//movies.Remove("D");
//movies.Add("D");

//movies.Insert(1, "Moon Light");

////movies.Clear();

//Console.WriteLine($"Contains: {movies.Contains("E")}");
//Console.WriteLine($"Count: { movies.Count()}");
//Console.WriteLine($"Index of: {movies.IndexOf("Moon Light")}");
//Console.WriteLine($"Last Index of: {movies.LastIndexOf("Moon Light")}");


//movies.Sort();
//movies.Reverse();

//Console.WriteLine("__________________________________________");





//string[] moviesArray = movies.ToArray();



//Console.WriteLine(moviesArray);
//Console.WriteLine(movies);



//Console.WriteLine(moviesArray.Length);


//moviesArray[11] = "A";


//foreach (var item in movies)
//{
//    Console.WriteLine(item);

//}

//foreach (string item in moviesArray)
//{
//    Console.WriteLine(item);
//}







//Game supermario = new Game();

//supermario.gameName = "Super Mario 7";
//supermario.company = "Nintendo";
//supermario.gameVersion = 2;


//Game supermario = new()
//{
//    gameName = "Super Mario 7",
//    company = "Nintendo",
//    gameVersion = 2
//};


//Game supermario = new Game("Super Mario 5",2,"Nintendo");
//Game GTA = new Game("GTA 5");


//Console.WriteLine(GTA.gameName);





//Console.WriteLine(supermario.gameName);







//Console.ReadKey();




//class Game
//{
//    public string gameName;
//    public int gameVersion;
//    public string company;



//    public Game(string gN, int gameVersion, string company)
//    {
//        this.gameName = gN;
//        this.gameVersion = gameVersion;
//        this.company = company;
//    }

//    public Game(string gN, int gameVersion)
//    {
//        this.gameName = gN;
//        this.gameVersion = gameVersion;
//    }

//    public Game(string gN)
//    {
//       this.gameName = gN;
//    }




//}












// Game supermario = new Game("Super Mario 7", "Nintendo", 2.4, 3);
// Console.WriteLine("{0} {2} {1} {3}",supermario.name,supermario.company, supermario.version,supermario.players);

// Console.WriteLine($"{supermario.name} hfdshfhdsh {supermario.company}");



// Console.ReadKey();


// class Game(string name, string company, double version, int players)
// {
//     public string name = name;
//     public string company = company;
//     public double version = version;
//     public int players= players;

    
// }











/*Nintendo supermario = new() { 
    name = "Super Mario 7",
    company = "Nintendo Corp",
    version = 3.4,
    players = 4
};

Console.WriteLine(supermario.name);
Console.WriteLine(supermario.company);
supermario.gamePrice(3);

supermario.isGameAvailable("Yes");

Ubisoft farcry = new()
{
    name = "Far Cry 3",
    company = "Ubisoft Ind",
    version = 4.4,
    players = 2
};

Console.WriteLine("___________________________________");
Console.WriteLine(farcry.name);

farcry.isGameAvailable("hfdjsh");
farcry.gamePrice(3);
farcry.totalPrice(30);

Console.WriteLine(farcry.ToString());*/

//Console.WriteLine(farcry.genralPrice);


/*Console.WriteLine("Enter your Name:");

string a = Console.ReadLine();

Console.WriteLine(a.ToLower());*/












/*
Console.ReadKey();


abstract class Game()
{
    public string name;
    public string company;
    public double version;
    public int players;
    protected int genralPrice = 300;

    public virtual void isGameAvailable(string value)
    {
    }
    public void totalPrice(double tax)
    {
        Console.WriteLine(tax + genralPrice);
    }
}

class Nintendo : Game
{

    public override void isGameAvailable(string value)
    {

        if (value == "Yes")
        {
            Console.WriteLine("You can download this game. Thank you for Purchasing");
        }
        else if (value == "No")
        {
            Console.WriteLine("You can not download this game.");
        }
        else
        {
            Console.WriteLine("Kindly enter valid value");
        }
    }
    public virtual void gamePrice(int quantity)
    {
        Console.WriteLine($"Your Nintendo Game the game name is {this.name} total Price is: $.{(quantity * 30) + 23}");
    }
    *//*public void totalPrice(double value)
    {
        Console.WriteLine(value + genralPrice);
    }*//*

    public override string ToString()
    {
        return $"Game Name: {this.name} \nGame Company: {this.company} \nGame Version: {this.version} \nGame Player: {this.players}";
    }



}

class Ubisoft : Nintendo
{

    public override void isGameAvailable(string value)
    {

        if (value == "Yes")
        {
            Console.WriteLine("You can download this game.");
        }
        else if (value == "No")
        {
            Console.WriteLine("You can not download this game.");
        }
        else
        {
            Console.WriteLine("Kindly enter valid value");
        }
    }
    public override void gamePrice(int quantity)
    {
        Console.WriteLine($"Your Ubisoft Game the game name is {this.name} total Price is: $.{(quantity * 50) + 30}");
    }
}*/




Audionic headphone = new()
{
    prodName = "Headset Bluetooth",
    prodPrice = 2000,
    prodRating = 2.3
};


HudaBeauty lipstick = new()
{
    prodName = "Saeed Ghani Lipstick",
    prodPrice = 340,
    prodRating = 4.3
};

Console.WriteLine(headphone.prodDesc());
Console.WriteLine(lipstick.prodDesc());
Console.WriteLine(headphone.totalPrice());
Console.WriteLine(lipstick.totalPrice());
Console.WriteLine(lipstick.colors());




interface IElectronics
{
    string prodDesc();
    double totalPrice();
}

interface ICosmetics
{
    string colors();
}


class Audionic : IElectronics
{
    public string prodName;
    public double prodRating;
    public double prodPrice;
    public string prodDesc()
    {
        return $"Product Name: {this.prodName} \nProduct Rating: {this.prodRating} \nProduct Price: {this.prodPrice}";
    }
    public double totalPrice()
    {
        return this.prodPrice + 23;
    }
}

class HudaBeauty : IElectronics, ICosmetics
{
    public string prodName;
    public double prodRating;
    public double prodPrice;
    public string prodDesc()
    {
        return $"Product Name: {this.prodName} \nProduct Rating: {this.prodRating} \nProduct Price: {this.prodPrice}";
    }
    public double totalPrice()
    {
        return this.prodPrice + 23;
    }
    public string colors()
    {
        return "Red, Purple, Pink, Red, Blue, Magenda";
    }
}





//Console.WriteLine((int)days.Wednesday);

//int userInput = Convert.ToInt32(Console.ReadLine());


/*days input = days.DAY;


switch(input)
    {
        case days.Monday:
            Console.WriteLine("Today is Monday");
            break;
        case days.Tuesday:
            Console.WriteLine("Today is Monday");
            break;
        case days.Wednesday:
            Console.WriteLine("Today is Monday");
            break;
        case days.Thursday:
            Console.WriteLine("Today is Monday");
            break;
        case days.Friday:
            Console.WriteLine("Today is Friday");
            break;
        case days.Saturday:
            Console.WriteLine("Today is Saturday");
            break;
        case days.Sunday:
        Console.WriteLine("Today is Sunday");
            break;
        default:
        Console.WriteLine("Kindly Enter valid value");
        break;
}





enum days
{
    Monday = 90,
    Tuesday = 25,
    Wednesday = 66, 
    Thursday = 87,
    Friday = 98,
    Saturday = 56,
    Sunday = 45,
    DAY

}*/


using System.Collections.Generic;

/*List<string> names = new List<string>();
names.Add("Arif");
names.Add("Zahid");
names.Add("Akmal");
names.Add("Haris");
names.Add("Safdar");
names.Add("Polard");



List<int> nums = new List<int>();
nums.Add(1);
nums.Add(3);
nums.Add(4);
nums.Add(7);
nums.Add(10);
nums.Add(14);


Print.printAll(names);


class Print
{
    public static void printAll<T>(List<T> value)
    {
        foreach(T item in value)
        {
            Console.WriteLine(item);
        }
    }
}
*/




Products headphone = new();
headphone[0] = 1;
headphone[1] = 6;
//headphone[2] = 4;
//headphone[3] = 3;
//headphone[4] = 5.1;


//Console.WriteLine(headphone[0]);
Console.WriteLine(headphone[1]);

for (int i = 0; i <= 100; i++)
{

    Console.WriteLine(headphone[i]);
}



class Products
{
  private double[] ratings = new double[100];

    public double this[int index]
    {
        get 
        {

            //if (ratings[index] > 0)
            //{
            //    return ratings[index];
            //}
            return ratings[index];
        }
        set 
        {
            if(value > 0 && value <= 5) 
            {
                ratings[index] = value;
                Console.WriteLine(ratings[index]);
            }
            else
            {
                Console.WriteLine("Enter ratings between 0 to 5");
            }
            
        }
    }


}









