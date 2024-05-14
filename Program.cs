// See https://aka.ms/new-console-template for more information
int num;

Console.WriteLine("Escriba un numero:");
string cad = Console.ReadLine();
if(int.TryParse(cad,out num)){
    Console.Write(num);
}
