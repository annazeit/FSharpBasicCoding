open System

let main argv =
    let array = [|5; 19; 36; 7; 81; 48|]
    let left = Array.sub array 0 (array.Length /2)
    let rightLength =
        if array.Length % 2 = 0 then
            array.Length / 2
        else
            array.Length / 2 + 1
    let right = Array.sub array left.Length rightLength

    Console.WriteLine(array.Length)
    0

//  RightLength 2nd

//  let rightLength =   
//      array.Length / 2 + (if array.Length % 2 = 0 then 0 else 1)


//  RightLength 3rd

//  let rightLength = array.Length / 2 + (array.Lenght % 2)