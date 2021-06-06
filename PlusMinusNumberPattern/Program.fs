open System
    
Console.WriteLine("Enter number: ")
let number = Console.ReadLine()
let n = Int32.Parse(number)
for i in 0..(n - 1) do
    let c =
        let remainder = i% 2
        if remainder = 0 then "+ "
        else "- "
    Console.Write(c)

Console.ReadKey() |>ignore   