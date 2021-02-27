namespace SingleFileRepro

module Program =
    // Define a function to construct a message to print
    let from whom =
        sprintf "from %s" whom

    [<EntryPoint>]
    let main argv =
        let message = {| text = from "F#" |} // Call the function
        printfn "Hello world %s" message.text
        0 // return an integer exit code
