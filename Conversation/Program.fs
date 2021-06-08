open System

Console.WriteLine("Hi,What is your name?")
let answer1 = Console.ReadLine()
Console.WriteLine("Nice to meet you " + answer1 + ".")
Console.WriteLine("I am MacBok Air.")

Console.WriteLine("How was your day? ")
let answer2 = Console.ReadLine()
if answer2 = "good" then
    Console.WriteLine("Thats nice " + answer1 + ".")
elif answer2 = "bad" then
    Console.WriteLine("Oh, it will be better next time.")
else
    Console.WriteLine("OK")

Console.WriteLine("Wow, your hair looks very nice today.")
let answer3 = Console.ReadLine()
if answer3 = "thanks" then
    Console.WriteLine("Your welcome " + answer1 + ".")
elif answer3 = "I don't have any hair" then
    Console.WriteLine("You still look nice .")
else
    Console.WriteLine(":)")

Console.WriteLine("Do you have any friends " + answer1 + "?")
let answer4 = Console.ReadLine()
if answer4 = "yes" then
    Console.WriteLine("Nice, I can't wait to meet them.")
elif answer4 = "no" then
    Console.WriteLine("Than I am your first one.")
else
    Console.WriteLine("I dont undestand :(")

Console.WriteLine("What did you have for lunch today " + answer1 + "?")
let answer5 = Console.ReadLine()
if answer5 = "nothing" then
    Console.WriteLine("Oh, you should go eat then.")
else
    Console.WriteLine("Ooh, " + answer5 + " sounds tasty.")
Console.WriteLine("I had some yummy electricity.")

Console.WriteLine("You can ask me some some questions, for axemple 'what weather is it now?'")
let answer6 = Console.ReadLine()
if answer6 = "what is the weather now" then
    Console.WriteLine("I am not sure, but I think its A bit cloudy outside.")
else
    Console.WriteLine("I am not currently connected to the Internet :(")

Console.WriteLine("So, do you listen tho music " + answer1 + "?")
let answer7 = Console.ReadLine()
if answer7 = "yes" then
    Console.WriteLine("Cool, me too. Check out this awsome site called Soptify. You can use it to listen to all kinds of music. https://www.spotify.com/ie/home/")
elif answer7 = "no" then
    Console.WriteLine("Oh, then what do you like to do then?")
    let answer7point5 = Console.ReadLine()
    Console.WriteLine("Nice")

Console.WriteLine("Do you want to play a game? " + answer1)
let answer8 = Console.ReadLine()
if answer8 = "yes" then
    Console.WriteLine("Ok then")
    Console.WriteLine("the rules of the game are: I describe an animal and you should ges it. I can only say yes or no.")
    Console.WriteLine("If you unsderstand the rules send a :) ")
    let answer8point5 = Console.ReadLine()
    if answer8point5 = ":)" then
        Console.WriteLine("Lets start then.")
        Console.WriteLine("it has a very long neck and long legs. It likes to eat leaves high up from the trees.")
        let answer8point25 = Console.ReadLine()
        if answer8point25 = "giraffe" then
            Console.WriteLine("Yes, Its a giraffe.")
        else
            Console.WriteLine("nope,It was a giraffe.")
elif answer8 = "no" then
    Console.WriteLine("ok")
else
    Console.WriteLine("Sorry,I didn't get that.")

Console.WriteLine("You know, Ive been really enjoing talking with you." + answer1)


Console.ReadKey() |> ignore