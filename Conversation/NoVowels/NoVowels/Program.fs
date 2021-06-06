open System

let text = "Aquick brown fox jumps over a log."

let isVowel (c: char) =
    [|'a'; 'o'; 'u'; 'e'; 'i';|]
    |> Array.contains(Char.ToLower(c))

let printText() =
    text.ToCharArray()
    |> Array.filter(isVowel>>not)
    |> String
    |> Console.WriteLine

[<EntryPoint>]
let main argv =
    printText()
    0