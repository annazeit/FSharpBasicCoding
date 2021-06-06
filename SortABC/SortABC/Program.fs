open System

let a = Console.ReadLine()|>int
let b = Console.ReadLine()|>int
let c = Console.ReadLine()|>int

let sortedABC =
    if a > b then
        if c> a then [c; a; b]
        else
            if b> c then [b; c; a]
            else [a; c; b]
    else //b > a
        if b>c then
            if c > a then [b; c; a]
            else [b; a; c]
        else //c > b
            [c; b; a]
