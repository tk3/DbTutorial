open System

let printPrompt() = printf "db> "

[<EntryPoint>]
let main argv =

    let mutable continueLooping = true
    while continueLooping do
        printPrompt()
        let inputBuffer = Console.ReadLine() |> string
        printfn "Input: %s" inputBuffer
        if inputBuffer = ".exit" then
            printfn "equal"
            continueLooping <- false
        else
            printfn "Unrecognized command '%s'." inputBuffer

    0 // return an integer exit code
