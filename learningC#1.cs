

Console.WritleLine("Learning 1 - Tutorial");


 a dot, or period, that separates the class name Console and the method name WriteLine(). The period is the member access operator.
 
 
//char literal
Console.WriteLine('b');

// int
Console.WriteLine(123);

// decimal
  // m or M= literal suffix = we want t work with decimals
Console.WriteLine(12.30M);
    // without m, it will be a double


// bool
Console.WriteLine(true);
Console.WriteLine(false);


// strings and char are used for presentations not calculation


// variable

string firstName;
char userOptions;
int ganeScore;
decimal particlesPerMillion;
bool processedCustomer;



string firstName;
firstName = "Bob";
Console.WriteLine(firstName);


// implicitly typed local varables
var message = "Hello World!";  // the type is locked in at the time of declaration
// once you use the var key word you shoulsd initialise it else- error


// Hello Bob You have 3 messgaes in your inbox. The temperature is 34.4 celcius

int numberOfMessages = 3;
decimal temperatureReading = 34.4M;
string firstName = "Bob";
Console.Write("Hello ");
Console.Write(firstName);
Console.Write(" You have "); 
Console.Write(numberOfMessages);
Console.Write(" messgaes in your inbox. The temperature is ");
Console.Write(temperatureReading);
Console.Write(" celcius");





 the \" escape sequence.
 
 the \\ to display a single backslash.
 
 \t sequence
 
 Console.WriteLine("c:\\source\\repos");

// Verbatim String Literal
// A verbatim string literal will keep all 
//whitespace and characters without the need to 
//escape the backslash. To create a verbatim string, 
//use the @ directive before the literal string.
/*
Two consecutive double-quote characters ("") are 
printed as a single double-quote character (") in the output string.
*/

Console.WriteLine(@" As it is 
("" okay "" ) ");

// Unicode Escape Characters
/*
using the \u escape sequence, 
then a four-character code representing some character in Unicode (UTF-16)
*/
Console.WriteLine("\u3093");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

/*
There are several caveats here. First, some consoles like the Windows Command Prompt 
will not display all Unicode characters. It will replace those characters with question-mark characters instead. Also, the examples used here are UTF-16. Some 
characters require UTF-32, and therefore require a different escape sequence.
*/

Console.WriteLine("=========\n=========");
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");



 
 
 /*

Concatenate a literal string and a variable.

*/

string firstName = "frank";
string message = "Hello " + firstName;
Console.WriteLine("The message is " + message);


 
 
 
 
 
 
 
 
 
 
 
 
 


