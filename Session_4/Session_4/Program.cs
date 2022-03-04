using Session_4;

//askisi 1
Console.WriteLine("Enter the name: ");
string name = Console.ReadLine();
var c1 = new Class1(); 

string reversedname = c1.Reverse(name);
Console.WriteLine(reversedname);

//askisi 2
Console.WriteLine("Enter the number: ");
int x = 12;
var c2 = new Class2();
Console.WriteLine(c2.GetProduct(x));
Console.WriteLine(c2.GetSum(x));





//askisi 3
string number = Console.ReadLine();
int numb  = Convert.ToInt32(number);
var c3 = new Class3();
c3.Prime(numb);


//askisi 4

int[] Array1 = { 2, 4, 9, 12 };
int[] Array2 = { 1, 3, 7, 10 };

var c4 = new Class4();
c4.ArrayNew(Array1, Array2);

//askisi 5

int[] myArray = new int[10] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
var c5 = new Class5();
c5.Sort(myArray);
for (int i = 0; i < myArray.Length; i++)
    Console.WriteLine(myArray[i]);

