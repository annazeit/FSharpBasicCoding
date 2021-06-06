open System
    Console.WriteLine("Enter number: ")
    let number = Console.ReadLine()
    let n = Int32.Parse(number)
    for i in 0..(n - 1) do
        Console.Write("*")