open System

let goldenratio = (1.0 + Math.Sqrt(5.0)) / 2.0 // golden ratio value
let mult x = goldenratio * x // multiplies x by the golden ratio

[<EntryPoint>]
let main argv =
    // asks the user to enter the number of values in the list
    Console.Write("How many values would you like to input? ")
    let items = Console.ReadLine()
    
    // creates a list of tuples of the given size and asks for a number with each entry.
    let phi_tup = 
        [for i = 1 to (int items) do
            Console.Write("Enter a number: ")
            let num = Console.ReadLine()
            let num = float num
            yield (num, mult num) ]
    
    printfn "%A" phi_tup //prints results

    Console.ReadKey() |> ignore // user has to hit a key before the program exits
    0 // return int to exit