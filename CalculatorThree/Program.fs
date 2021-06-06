open System

[<EntryPoint>]
let main argv =
    Console.Write("Enter a: ")
    let a: string = Console.ReadLine()
    let aDouble: float = Double.Parse(a)
    Console.WriteLine("Enter operator: ")
    let operator: string = Console.ReadLine()
    Console.WriteLine("Enter b: ")
    let b: string  = Console.ReadLine()
    let bDouble: float = Double.Parse(b)

    let result =
        if operator = "+" then
            Some(aDouble + bDouble)
        elif operator = "-" then
            Some(aDouble - bDouble)
        elif operator = "*" then
            Some(aDouble * bDouble)
        elif operator = "/" then
            Some(aDouble / bDouble)
        else
            None

    let message =
        match result with
        | Some c -> "The answer is " + c.ToString()
        | None -> "Operator not entered :("

    Console.WriteLine(message)

    0