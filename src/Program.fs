module Magic

open System
open MathNet.Symbolics

type Time = int
type Id = int

type Coordinate = int

type Coordinates = { X: Coordinate; Y: Coordinate }

type Phenomenon =
    { Id: Id
      Coordinates: Coordinates}

type Distance = int
type Length = Distance
type Width = Distance
type GameObjects = List<Phenomenon>
type ForceApplied = int
type ForceAppliedX = ForceApplied
type ForceAppliedY = ForceApplied

type Vector =
    { ForceAppliedX: ForceAppliedX
      ForceAppliedY: ForceAppliedY }

type PlayingField =
    { Length: Length
      Width: Width
      Time: Time }

type Game =
    { Time: Time; GameObjects: GameObjects }


let be (p: Phenomenon) = p

let translate (p: Phenomenon) (v: Vector) =
    { p with
        Coordinates =
            { p.Coordinates with
                X = p.Coordinates.X + v.ForceAppliedX
                Y = p.Coordinates.Y + v.ForceAppliedY }}
    
let update (timedelta: TimeSpan)=
    printf $"updating again (since {timedelta.ToString()} time units ago)..."

let draw =
    printf "drawing...\n"
    DateTime.Now
    
let processInput (input: string) =
    let currentTime = DateTime.Now
    printfn $"Input found! Processing at {currentTime}\n"
    printfn $"the input was {input}"
    match input with
        | "w" -> printfn "This print function simulates an input side effect moving north"
        | "a" -> printfn "This print function simulates an input side effect moving west"
        | "s" -> printfn "This print function simulates an input side effect moving south"
        | "d" -> printfn "This print function simulates an input side effect moving east"
        | "q" -> failwith "Exiting program gracefully..."
        | _ -> printfn "didn't match nothin"

    
    
let rec readlines () = seq {
    let line = Console.ReadLine()
    if line <> null then
        yield processInput line
        yield! readlines ()
}

// see also https://www.youtube.com/watch?v=lW6ZtvQVzyg
let rec gameLoop (timeOfLastUpdate: DateTime) = 
    let timedelta = DateTime.Now - timeOfLastUpdate
    readlines() |> ignore
    update timedelta
    let newLastDrawTime = draw
    gameLoop newLastDrawTime
