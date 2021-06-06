open System

let mqin argv =
    Console.Write("Enter a: ")
    let a = Console.ReadLine()
    let aDouble = Double.Parse(a)
    Console.WriteLine("Enter operator: ")
    let operator = Console.ReadLine()
    Console.WriteLine("Enter b: ")
    let b = Console.ReadLine()
    let bDouble = Double.Parse(b)

    let result =
        if operator = "+" then
            aDouble + bDouble
        elif operator = "-" then
            aDouble - bDouble
        elif operator = "*" then
            aDouble * bDouble
        elif operator = "/" then
            aDouble / bDouble
        else 0.0

    Console.WriteLine("The Answer is " + result.ToString())
    0// return an intager exit code