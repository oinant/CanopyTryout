open canopy
open runner
open PageObjects.Google

start firefox

"first result for canopy f# in google is the project homepage"  &&& fun _ -> 
    PageObjects.Google.goToFirstResultFor "canopy f#"
    on "http://lefthandedgoat.github.io/canopy/"

run()
printfn "press [enter] to exit"
System.Console.ReadLine |> ignore

quit()

