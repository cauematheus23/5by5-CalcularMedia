float nota1, nota2, media;
Console.WriteLine("Digite a primeira nota");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota"); 
nota2 = float.Parse(Console.ReadLine());
if (nota1 >= 0 && nota2 >= 0)
{
    
    media = (nota1 + nota2) / 2;
    Console.Write($"A media ficou em {media}, ");
    if (media <= 3)
    {
        Console.WriteLine("Aluno Reprovado");
    }
    else
    {
        if (media > 3 && media <= 5)
        {
            Console.WriteLine("Aluno de Exame");
        }
        else
        {
            Console.WriteLine("Aluno Aprovado");
        }
    }

}
else
{
    Console.WriteLine("Digite valores reais maiores que 0");
}
