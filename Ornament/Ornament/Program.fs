open System

Console.Write("Enter with: ")
let w = Int32.Parse(Console.ReadLine())
Console.Write("Enter length: ")
let l = Int32.Parse(Console.ReadLine())

for rowIndex in 0..(l - 1) do
    for columnIndex in 0..(w - 1) do
        Console.Write("* ")
    Console.WriteLine()

Console.ReadKey() |> ignore