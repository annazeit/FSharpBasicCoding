open System

Console.Write("Enter with: ")
let w = Int32.Parse(Console.ReadLine())
Console.Write("Enter lenght: ")
let l = Int32.Parse(Console.ReadLine())

for rowIndex in 0..(l - 1) do
    for columnIndex in 0..(w - 1) do
        if (rowIndex + columnIndex) % 2 = 1 then Console.Write("# ")
        else Console.Write("* ")
    Console.WriteLine()

Console.ReadKey() |> ignore
