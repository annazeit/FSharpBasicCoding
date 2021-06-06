open System

let a = Console.ReadLine() |> int
let b = Console.ReadLine() |> int

let sortedAB =
    if a > b then [a; b]
    else [b; a]