open System

[<EntryPoint>]
let maqin argv =
        Console.Write("Enter a:")
        let a = Console.ReadLine()
        let aDouble = Double.Parse(a)
        Console.WriteLine("Enter operator:")
        let operator = Console.ReadLine()
        Console.Write("Enter b:")
        let b = Console.ReadLine()
        let bDouble = Double.Parse(b)

        if operator = "+" then
            let c = aDouble + bDouble
            Console.WriteLine("The answer is " + c.ToString())
        elif operator = "-" then
            let c = aDouble - bDouble
            Console.WriteLine("The answer is " + c.ToString())
        elif operator = "*" then
            let c = aDouble * bDouble
            Console.WriteLine("The answer is " + c.ToString())
        elif operator = "/" then
            let c = aDouble / bDouble
            Console.WriteLine("The answer is " + c.ToString())
        else
            Console.WriteLine("Unknown operator :(")
        0



