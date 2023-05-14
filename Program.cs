// Made by Silktz 

int qtdkid,qtdadult,qtdAdultND;

double carne,cerveja,acomp,soda,water; 

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=-=-=-=-=-CHURRASCO DO NORTE-=-=-=-=-=");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("adultos que consomem bebidas alcoólicas: ");
Console.ResetColor();

qtdadult = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("adultos que não consomem bebidas alcoólicas: ");
Console.ResetColor();

qtdAdultND = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Criancas: ");
Console.ResetColor();

qtdkid = Convert.ToInt32(Console.ReadLine());



int ALL_ADULTS = qtdAdultND + qtdadult;
carne = 0.4 * ALL_ADULTS + 0.2 * qtdkid;

int ALL = ALL_ADULTS + qtdkid;
acomp = 0.2 * ALL;

cerveja = 2 * qtdadult;

int AlcoolNO = qtdAdultND + qtdkid;
soda = 0.5 * AlcoolNO;

water = 0.4 * ALL;

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=-=-=-RESULTADO-=-=-=-");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"carnes : {carne:N1} kg");
Console.WriteLine($"acompanhamentos : {acomp:N1} kg");
Console.WriteLine($"cervejas : {cerveja:N1} L");
Console.WriteLine($"refrigerantes : {soda:N1} L");
Console.WriteLine($"águas : {water:N1} L");
Console.ResetColor();