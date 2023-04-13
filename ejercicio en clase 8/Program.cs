void arreglos()
{
    String[] nombre = new string[]
{
    "Fernanda", "Melvin", "Luis", "Brandon", "Yamileth"
};

    int[] notas = new int[]
    {
    70,90,43,85,30
    };

    int notaAlta = notas[0];
    int indNotaMasAlta = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > notaAlta)
        {
            notaAlta = notas[i];
            indiNotaMasAlta = i;
        }
    }
    Console.WriteLine($"La nota mas alta es:  {notaMasAlta}  del alumno {nombre[indiceNotaMasAlta]}");
};
arreglos();


