void arreglos()
{
    string[] nombre = new string[]
    {
"juan","maria","pedro"

    };

foreach (string n in nombre){
        Console.WriteLine(n);
    }

    int[] notas = new int[] {


50,30,90
};
    int promedio = 0;
    foreach (int i in notas) {
        promedio = promedio + i;
    }
    promedio=promedio/notas.Length;
    
    Console.WriteLine($"El promedio es: {promedio}");







}
arreglos();