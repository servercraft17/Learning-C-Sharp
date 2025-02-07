// See https://aka.ms/new-console-template for more information
/*
You don't need a main function kinda like in python, but you can't put code or functions outside of a class in other 
    source files.
you can only do that in the main source file.
you also dont need to import other source files, only external libraries.
*/

// there are a lot of ways to print to console.
// here are two of them.
Console.Write("!dlroW ,olleH\n"); // prints like printf in C. if you don't append '\n' then the next message printed will be on the same line.
Console.WriteLine("Hello, World!"); // is Console.Write but it automatically appends '\n' to the end of your message.

// declaring variables are similar to C, {type} {name} = {value}; or {type} {name};
int myInt;
myInt = 0;

int myInt2 = 0;

//if statements are the same as in C/C++.
if (myInt == myInt2) {
    Console.WriteLine("if statements;");
}

// the CSharp Vscode extension is really nice and does a lot of auto completeing for you.

// Functions are also pretty much the same as in C/C++
void myFunction(string msg) {
    Console.WriteLine("myFunction: " + msg);
}

myFunction("Called myFunction!");

// Scopes are also a thing in C# the same as in C/C++
{
    int myInt_scoped = 0;
    Console.WriteLine($"myInt_scoped: {myInt_scoped}");
}
// Errors when uncommented
// \/ \/ \/ \/ \/ \/ \/ \/
//Console.WriteLine($"myInt_scoped: {myInt_scoped}");


Logger logger= new Logger();
logger.logDebug("Debug!");
logger.logInfo("Info!");
logger.logWarning("Warning!");
logger.logError("Error!");
logger.logFatal("Fatal!");
Logger logger1= new Logger();
{
Logger logger2= new Logger();
logger1.logInfo($"{Logger.getLoggerCount()} Loggers are initialized!");
}
logger1.logInfo($"{Logger.getLoggerCount()} Loggers are initialized!");

// for loops and while loops are also just like in C/C++
for (int i=0; i<10;i++) {
    Console.WriteLine("Goober");
}
int while_i = 0;
while (while_i < 10) {
    Console.WriteLine("While Goobler");
    while_i++;
}

// foreach also exists, it works like in python.
String[] kablam = { "rats", "rats", "rats"};
foreach (string kablom in kablam) {
    Console.Write(kablom);
}
Console.Write('\n');



//###################################
// Strings
//###################################
// there are two string types: 'string' and 'String'
// 'string' and 'String' are literally the same thing.
string Greetings = "Welcome, Traveler!";
String Farewell = "Goodbye, Traveler!";

// Concatination is simple:
string npc_dialog = Greetings + " " + Farewell;

// CSharp strings have a very nice Python-like way to format them.
npc_dialog = $"{Greetings} {Farewell}";
//           ^ Makes this a formattable string.
// This way of formatting only applies to constant strings, 
//   you can't string format string variables this way.
// you can also append strings like this.
npc_dialog += " Must have been the wind.";

Console.WriteLine(npc_dialog);
// strings have built in functions.
String[] tokens = npc_dialog.Split();
string final_dialog = "";
foreach (String token in tokens) {
    if (token.Contains("Traveler")) {
        final_dialog += token.Replace("Traveler", "Merchant");
    } else final_dialog += token;
    final_dialog += " "; // can only append a single character for some reason.
}
final_dialog=final_dialog.TrimEnd();
Console.WriteLine(final_dialog);