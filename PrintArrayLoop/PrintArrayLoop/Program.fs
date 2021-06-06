open System

let printArray (a : int[]) : unit =
    Console.Write("[| ")
    for index in 0..(a.Length - 1) do
        let i = a.[index]
        Console.Write(i.ToString())
        if index < a.Length - 1 then
            Console.Write("; ")
    Console.Write("|] ")