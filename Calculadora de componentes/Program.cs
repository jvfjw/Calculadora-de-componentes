using Calculadora_de_componentes;

string input = "";
int count = 0;
bool número = false;
while (!número)
{
    Console.WriteLine("Quantas placas Dy8RL a serem feitas?");
    try
    {
        input = (Console.ReadLine() ?? "").Trim();
        count = Convert.ToInt32(input);
        if (count > 0)
        {
            número = true;
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido maior que zero.");
        }
    }
    catch { }
}
número = false;
string input2;
int count2 = 0;
while (!número)
{
    try
    {
        Console.WriteLine("Quantos relés por placa?");
        input2 = (Console.ReadLine() ?? "").Trim();
        count2 = Convert.ToInt32(input2);
        if (count2 > 0 && count2 < 9)
        {
            número = true;
        }
        else
        {


            Console.WriteLine("Por favor, insira um número válido.");
        }
    }
    catch { }
}
Dy8RL dy8RL = new Dy8RL(count, count2);

dy8RL.ExibirComponentes();