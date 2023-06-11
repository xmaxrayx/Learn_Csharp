// See https://aka.ms/new-console-template for more information
Console.WriteLine("Good bye world");
Console.Write("tell me");
Console.Write(" Why");
Console.Write('?');
Console.Write("???");
Console.WriteLine("i feel I'm unsafe");
Console.WriteLine("I'm sad");
Console.WriteLine(123);
Console.WriteLine(12.5f);
Console.WriteLine(12.5F);
Console.WriteLine(2.625); //double as defoult
Console.WriteLine(12.39816m); //Decimal
Console.WriteLine(12.39816M);
Console.WriteLine(true);//bool
Console.WriteLine(false); 
/*
string: for words, phrases, or any alphanumeric data for presentation, not calculation
char" for a single alphanumeric character
int: for a whole number
decimal: for a number with a fractional component
bool for: a true/false value
*/

string nekoTheGirlCatFighter;
//Variable names can contain alphanumeric characters and the underscore character names can contain alphanumeric characters and the underscore character
//variable can not spicial charcter or under score
//Variable names must begin with an alphabetical letter or an underscore, not a number.
//Variable names are case-sensitive, meaning that string Value; and string value; are two different variables.
//Variable names must not be a C# keyword. For example, you cannot use the following variable declarations: decimal decimal; or string string;.


//namming rules

/*
Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. For example, string thisIsCamelCase;.
Variable names should begin with an alphabetical letter. Developers use the underscore for a special purpose, so try to not use that for now.
Variable names should be descriptive and meaningful in your app. Choose a name for your variable that represents the kind of data it will hold.
Variable names should be one or more entire words appended together. Don't use contractions or abbreviations because the name of the variable (and therefore, its purpose) may be unclear to others who are reading your code.
Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strValue;. That advice is no longer current.
*/

String nekoTheThif;
nekoTheThif  = "meeeewo nek neko ne";
Console.WriteLine(nekoTheThif);

nekoTheThif = "gg";
Console.WriteLine(nekoTheThif);
/*
You must assign (set) a value to a variable before you can retrieve (get) a value from a variable.
You can initialize a variable by assigning a value to the variable at the point of declaration.
Assignment happens from right to left.
You use a single equals character as the assignment operator.
To retrieve the value from the variable, you merely use the variable's name.
*/

var message = "gg neko";

Console.WriteLine(message);

//message = 10.703m; //you cant because Var set message automaticly to string 


/*
Here's what you've learned about the var keyword so far:

The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.
You'll likely see the var keyword as you read other people's code; however, you should use the data type when possible.
*/


string name = "Cat girl";
int item;
item = 3;
decimal temp;
temp = 34.4m;


Console.WriteLine("Hello,");
Console.Write(name);
Console.Write(" you have ");
Console.Write(item);
Console.Write(" Bottle milk in your inbox and the temperature outside is ");
Console.Write (temp);
Console.Write ('C');

Console.WriteLine("");
// \n sequence will add a new line, and a \t sequence will add a tab.
// use "\" to escape from error
Console.Write("Helooow !!! \nmy neko \tdo u want fish?");
Console.WriteLine("");
Console.Write("Do u want \"spicial\" gift my neko ^^ ?");
Console.WriteLine("\n");
Console.WriteLine("C:\\Heart\\Felling\\Love");
Console.WriteLine("sorry this folder is \"empty\"");

Console.WriteLine("\n\n");

Console.WriteLine("genrating love for neco neco neeeee \"ice club \" girls ...... \n");
Console.WriteLine("Love Power:\t101\tERR");
Console.WriteLine("Love Power:\t101\tERR");
Console.WriteLine("\noutput Directory:\t C:\\Lovepower\\History ");

//"@" will keep all whitespace and characters without the need to escape the backslash

Console.WriteLine(@"                    C:  \love\heart\power
                            (this is where your well goes)");

Console.WriteLine("gg");


string firstname = "bob";
message = "Hello " + firstname;
Console.WriteLine (message);

firstname = "neko";
message = "meew";
Console.WriteLine(firstname + " " + message + ":3" );


message = $"{message} {firstname} !";
Console.WriteLine(message);
//interpolation expression is a variable surrounded by an opening and closing curly brace symbol { }. The literal string becomes a template when it's prefixed by the $ character.

int version = 11;
string updateText = "update to Brom-chan";
message = $"{updateText} OS {version}-v neko neko ne ";
Console.WriteLine(message);
//verbatim literals = @
//string interpolation$
string projectName = "Neco project";
Console.WriteLine($@"C:\output\{projectName}\Data");
Console.WriteLine(@$"C:\output\{projectName}\Data");
//
projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434" ;

Console.WriteLine("Vew English output:" + "\n \t" + @$"c:\Exercise\{projectName}\date.text");
Console.WriteLine($"{russianMessage}:" + "\n \t" + @$"c:\Exercise\{projectName}\date.text");

/*
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\\data.txt";
Console.WriteLine($"View English output:\n\t\t\n");
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\\ru-RU\data.txt";
Console.WriteLine($":\n\t\t\n");
*/



int firstNumber =12;
int secondNumber =7;
Console.WriteLine(firstNumber+secondNumber);

string firstName = "cat"; 
int foodContainer = 7;

Console.WriteLine(firstName + " eat " +  foodContainer + " fish.");
Console.WriteLine("but now " + firstName + " eat " + foodContainer + 8 + " fish.");
Console.WriteLine("but now " + firstName + " eat " +  (foodContainer + 8) +" fish.");
//() becomes another overloaded operator. 
//Both string concatenation and addition use the plus + symbol. This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.


int sum = 7 + 5;
int difference = 7 -5;
int product = 7 *5;
int quotient = 7 /5;

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//


decimal decimalQuotient = 7.9m / 5.3m;
Console.WriteLine($"Decimal quotient: {decimalQuotient} ");
