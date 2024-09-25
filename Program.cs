/*void Main()
{
    double radie = 2.4;
    Console.WriteLine("Cirklens omkrets: "+CirkelOmkrets(radie));
    Console.WriteLine("Cirklens area: "+CirklensArea(radie));

}

double CirkelOmkrets(double r)
{
    return (r *2 * Math.PI); 
}

double CirklensArea(double r)
{
    return (r * r * Math.PI);
}

Main();
*/
void Main()
{
    Console.WriteLine("Skriv tre tal");
    float a = Convert.ToInt32(Console.ReadLine());
    float b = Convert.ToInt32(Console.ReadLine());
    float c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Mv(a, b, c));
}

float Mv(float a, float b, float c)
{
    return (a + b + c)/3;
}
Main();


