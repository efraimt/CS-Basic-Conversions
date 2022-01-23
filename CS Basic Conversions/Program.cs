
/*********************************************/
/*****             המרות            **********/
/*****             Convertions      **********/
/*********************************************/
// Copy the code to your program and add
//     "Console.WritLine" to see the results
/*********************************************/

//===========     ToString()  ================/
int x = 75; 
string sX = x.ToString(); // int to string

double d1 = 0.475;
string sD1 = d1.ToString(); //"0.475" double to string

bool b1 = true;
string sB1 = b1.ToString(); //"true" bool to string

//===========     From String  ================/
Console.WriteLine("Enter age");
string inputAge = Console.ReadLine(); //get string from user
int age = int.Parse(inputAge);  // Convert the string to int

double d1 = double.Parse("2.35");

bool b1 = bool.Parse("tru");

// *****************************
//int.Parse("Moti"); // Don't run this line, it will throw an Exception!
//******************************

//===========       Int --> Double    ========/
int myInt = 65;
double myDouble1 = myInt; // implicit conversion
double myDouble2 = 65; // same as above - 65 is an int but we can put it in a double variable

//===========       Double --> Int    ========/
Double myDouble3 = 69.91;
int myInt3 = (int) myDouble2; // explicit conversion - value in myInt3 = 69
int myInt4 = Convert.ToInt32(myDouble3); // explicit conversion - value in myInt3 = 70

//===========      String conatination with the + operator    ========/
string s = "Yaakov " + "Levi";
Console.WriteLine(s); // Yaakov Levi

Console.WriteLine(s + " you are " + 50 + " years old!"); // Yaakov levi you are 50 years old
//The above line includes an implicit conversion of the int literal (50) to string

















/*
long l1 = 2274623874618764876238746; // 8 bytes
int age = 29; // 4 bytes
ushort s1 = 29; // 2 bytes
byte b1 = 129;  // 1 byte


double d1 = 5.1237;
Console.WriteLine(d1);
Console.WriteLine(58.618);

bool bool1 = true;
bool1 = false;


int age = 29;
string ageString = age.ToString();
ageString = (99 + 5).ToString();

double ageDouble = 6.5;
ageString=ageDouble.ToString();

bool b1 = false;
string s1 = b1.ToString();

Console.WriteLine("MASHHU!!");

*/


