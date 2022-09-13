using ProyectoDeAula;
 
var numeros = new List<int> {0, 1, 2};




    bool cosas = false;
    do
    {
        int a = new Random().Next(0, 10);
        
        Console.WriteLine("nuevo a: " + a);

        if (!numeros.Contains(a))
        {
            numeros.Add(a);
            cosas = true;
        } 
    }
    while (cosas is false);
    



numeros.ToList().ForEach(Console.WriteLine);





