open System

(
    Console.WriteLine("Enter number: ")
    let number = Console.ReadLine()
    let n = Int32.Parse(number)
    for i in 0..(n - 1) do
        let c =
            let remeinder = i% 3
            if remeinder = 0 then "A"
            elif remeinder = 1 then "B"
            else "C"
        Console.Write(c)
)

////////////////

(
    Console.WriteLine("Enter number: ")
    let number = Console.ReadLine()
    let n = Int32.Parse(number)
    for i in 0..(n - 1) do
        let c =
            match i % 3 with
            | 0 -> "A"
            | 1 -> "B" 
            | _ -> "C"
        Console.Write(c)
)