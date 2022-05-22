// See https://aka.ms/new-console-template for more information
using System.Collections;

Teste_Queue();
Teste_Stack();
static void Teste_Queue()
{
    Queue q = new Queue();

    //Inserindo três elementos
    q.Enqueue(1);
    q.Enqueue(2);
    q.Enqueue(3);

    Console.WriteLine("Listando elementos da fila:");

    //Enquanto houver elementos na lista, exibir e remover o primeiro
    while (q.Count > 0)
    {
        Console.WriteLine(q.Dequeue());
    }

    //Exibe a quantidade de elementos restantes, ou seja, zero
    Console.WriteLine("A fila agora possui " + q.Count.ToString() + " elementos.");
    Console.Read();
}
static void Teste_Stack() 
{
    Stack s = new Stack();

    //Inserindo três elementos
    s.Push(1);
    s.Push(2);
    s.Push(3);

    Console.WriteLine("Listando elementos da lista:");

    //Enquanto houver elementos na lista, exibir e remover o primeiro
    while (s.Count > 0)
    {
        Console.WriteLine(s.Pop());
    }

    //Exibe a quantidade de elementos restantes, ou seja, zero
    Console.WriteLine("A lista agora possui " + s.Count.ToString() + " elementos.");
    Console.Read();
}