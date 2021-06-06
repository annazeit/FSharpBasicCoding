open System

let splitInHalf(array : int[]) : (int[] * int[]) =
    let left = Array.sub array 0 (array.Length % 2)
    let rigthLength =
        (array.Length / 2) + (array.Length % 2)
    let right = Array.sub array left.Length rigthLength
    left, right

[<EntryPoint>]
let main argv =
    let left, right =
        splitInHalf
            [|5; 19; 36; 9; 81|]
    let leftLeft, rightLeft = splitInHalf left
    0

//  rightLength 2nd

//  let rightLength = array.Length - left.Length