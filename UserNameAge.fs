open System

type person = 
    { name : string;
      age : int;
      id : int }

let GetUser username userage =
    { name = username;
      age = userage;
      id = username.Length * userage }

[<EntryPoint>]
let main argv =
    Console.WriteLine("Enter the main user's name: ")
    let name = Console.ReadLine()
    Console.WriteLine("Enter the main user's age: ")
    let age = Console.ReadLine()
    let mainuser = GetUser name (int age)
    
    let people = 
        [ let run = ref true
          while !run do
              Console.WriteLine("Do you want to add more people (y/n)? ")
              if Console.ReadLine().ToLower() = "y" then
                  Console.WriteLine("Enter the user's name: ")
                  let name = Console.ReadLine()
                  Console.WriteLine("Enter the user's age: ")
                  let age = Console.ReadLine()
                  yield GetUser name (int age)
              else run := false ]
              
    let sameid =
        seq {
            for x in people do
                if x.id = mainuser.id then yield x }
    
    for x in sameid do
        Console.WriteLine(x.name)
        
    Console.ReadKey() |> ignore
  
    0 // return an integer exit code
