
open System

Console.WriteLine("Hello world")

Console.WriteLine("What is your name?")
let answer = Console.ReadLine()
Console.WriteLine("Hello " + answer + ", nice to meet you :)")

Console.WriteLine("What is your name?")
let answer1 = Console.ReadLine()
if answer1 = "Bob" || answer1 = "Alice" then
    Console.WriteLine("Hi " + answer + ", nice meeting you.")
else
    Console.WriteLine("I dont like you " + answer1)

Console.WriteLine("Enter n:")
let n = Console.ReadLine()
let N = Int32.Parse(n)
let mutable sum = 0
for i in 1 .. N do
    sum <- sum + i
Console.WriteLine(sum)
n

(
    Console.WriteLine("Enter n:")
    let n = Console.ReadLine()
    let N = Int32.Parse(n)
    Console.WriteLine("sum or product")
    let answer = Console.ReadLine()
    let result = 
        if answer = "sum" then
            let mutable sum = 0
            for i in 1 .. N do
                sum <- sum + i
            Console.WriteLine(sum)
            sum
        else
            let mutable product = 1
            for i in 1 .. N do
                product <- product * i
            Console.WriteLine(product)
            product
    Console.WriteLine("The answer is: " + result.ToString())
)

(
    Console.WriteLine("Enter n:")
    let n = Console.ReadLine()
    let N = Int32.Parse(n)
    Console.WriteLine("sum or product") 
    let answer = Console.ReadLine() = "sum"
    let mutable acumulator = if answer then 0 else 1
    for i in 1 .. N do
        if answer then
            acumulator <- acumulator + i
        else
            acumulator <- acumulator * i
    Console.WriteLine("The answer is: " + acumulator.ToString())
)

Console.WriteLine("Enter n:")
let a = Console.ReadLine()
let A = Int32.Parse(n)
Console.WriteLine("sum or product")
let answer2 = Console.ReadLine() = "sum"
let mutable acumulator = if answer2 then 0 else 1
let operation = if answer2 then (+) else (*)
for i in 1 .. N do
    acumulator <- operation acumulator i
Console.WriteLine("the answer is: " + answer2.ToString())