
internal class Program
{
    private static void Main(string[] args)
    {   
        //Criação de um Array de inteiros do tipo List.
        List<int> numeros = new List<int>();

        System.Console.WriteLine("Introduza números inteiros, quando não qiuiser introduzir mais basta carregar numa tecla não numerica:");

        /*Recolhemos as respostas do utilizado, que são do tipo string, usamos o metodo "TryParse", que vai tentar converter o input
        para um número inteiro. Caso essa conversão não seja possivel, passa para o "else" que sai do ciclo, consequentemente
        termina o pedido de introdução de valores*/
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

        System.Console.WriteLine("_______________________________________________________________________________________________________________________________________________________________________________________");

        // Aqui usamos o metodo ".Sort()" para ordenar os valores por ordem crescente
        numeros.Sort();

        //Display do Array já ordenado
        foreach (var item in numeros)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("_________________________________________________________________________________________________________________________________________________________________________________________________");

        //Aqui obetemos e imprimimos o tamanho do Array

        int l = numeros.Count;
        System.Console.WriteLine(l); 

        System.Console.WriteLine("_____________________________________________________________________________________________________________________________________________________________________________________________________________");

        //Damos print aos três últimos valores do Array
        foreach (var item in numeros.GetRange(numeros.Count - 3, 3))
        {
            System.Console.WriteLine(item);
        }


        System.Console.WriteLine("_________________________________________________________________________________");

        //Verificarmos se o tamanho do Array é par (entra no "else") ou impar (entra no if)
        if (!(numeros.Count % 2 == 0))
        {
            //Aqui damos print aos valores que se encontram da posição 0 até à posição do meio do Array
            float q = numeros.Count / 2;
            int w = Convert.ToInt32(q);
            for (int i = 0; i <= w; i++)
            {
                System.Console.WriteLine(numeros[i]);
            }
        
        }


        else
        {

            //Aqui danos print em primeiro aos valores da posição 0 até à primeira posição do meio do Array
            int e = numeros.Count / 2;
            System.Console.WriteLine("Visto que o tamanho do Array é par a posição do meio é composta por dois números.");
            System.Console.WriteLine("As primeiras posição até ao segundo númeor do meio.");
            for (int i = 0; i <= e; i++)
            {
                System.Console.WriteLine(numeros[i]);

            }

            //Aqui danos print aos valores da posição 0 até à segunda posição do meio do Array
            System.Console.WriteLine("As primeiras posição até ao primeiro número do meio.");
            for (int i = 0; i < e; i++)
            {
                System.Console.WriteLine(numeros[i]);

            }

            // Sendo o tamanho da Array um número par, podemos considerar que temos dois valores na posição do meio.
            //Assim sendo faremos a média dos valores nessas posições

            decimal a = numeros [e];
            decimal b = numeros [e-1];
            System.Console.WriteLine("______________________________");
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            decimal r =(a+b)/2;
            System.Console.WriteLine("A média das duas posições do meio do Array é: " + r);
        }
    }
}

