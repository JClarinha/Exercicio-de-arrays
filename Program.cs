using System.Globalization;
using System.Runtime.InteropServices;

List<int> numeros = new List<int>(); 

System.Console.WriteLine("introduza numeros inteiros, quando não qiuiser introduzir mais basta carregar numa tecla não numerica:");

while (true)
{
    string i = System.Console.ReadLine();
    int a;

    if (int.TryParse(i, out a))
    {
        numeros.Add(a);   
    }

    else
    {
        break;
    }
}

System.Console.WriteLine("______________________________________________________________________________________________________________________\n_________________________________________________________________");

numeros.Sort(); 

foreach (var item in numeros)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("______________________________________________________________________________\n___________________________________________________________________________________________________________________");

int l = numeros.Count;
System.Console.WriteLine(l); //10

System.Console.WriteLine("___________________________________________________________________________________________________________________________________________\n__________________________________________________________________");

foreach (var item in numeros.GetRange(numeros.Count-3,3))
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("_________________________________________________________________________________");
if (!(numeros.Count % 2 ==0))
{
    float q = numeros.Count/2;
    int w = Convert.ToInt32(q);
    for (int i = 0; i <= w; i++)
    {
        System.Console.WriteLine(numeros[i]);
    }
}

else
{
    int e = numeros.Count/2;
    System.Console.WriteLine("Visto que o tamanho do Array é par a posição do meio é composta por dois números.");
    System.Console.WriteLine("As primeiras posição até ao segundo númeor do meio.");
    for (int i = 0; i <= e; i++)
    {
        System.Console.WriteLine(numeros[i]);
        
    }


    System.Console.WriteLine("As primeiras posição até ao primeiro número do meio.");
    for (int i = 0; i < e; i++)
    {
        System.Console.WriteLine(numeros[i]);
       
    }


    decimal r =((e+1)+e);
    System.Console.WriteLine("A média dos duas posições do meio do Array é: " + r/2);

}

