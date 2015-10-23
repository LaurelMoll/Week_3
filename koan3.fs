open System

[<EntryPoint>]
let main argv =
    let arr = [| 1 .. 9|]
    let l = arr.Length
    let isEven x = (x % 2 = 0)
    
    let out = 
        [ for i = 0 to (l-1) do
            if isEven arr.[i] then yield arr.[i] ]
    
    let newout = 0 :: out
    
    for i = 0 to (newout.Length-1) do
        Console.WriteLine(newout.Item(i))

    Console.ReadKey() |> ignore
    0 // return into to exit