type Time = int

type Xcoord = int
type Ycoord = int

type Coordinates = {
    Xcoord: Xcoord
    Ycoord: Ycoord
}
type Phenomenon = {
    Coordinates: Coordinates
    Time: Time
}
type Distance = int
type Length = Distance
type Width = Distance
type GameObjects = List<Phenomenon>
type ForceApplied = int
type ForceAppliedX = ForceApplied
type ForceAppliedY = ForceApplied

type Vector = {
    ForceAppliedX: ForceAppliedX
    ForceAppliedY: ForceAppliedY
}

type PlayingField = {
    Length: Length
    Width: Width
    Time: Time
}
type Game = {
    Time: Time
    GameObjects: GameObjects
}


let be (p : Phenomenon) = p

let translate (p : Phenomenon) (v : Vector) =
    let newX = p.Coordinates.Xcoord + v.ForceAppliedX
    let newy = p.Coordinates.Ycoord + v.ForceAppliedY
    let coords = { Xcoord = newX; Ycoord = newy }
    let newTime = p.Time + 1
    let newPhenomenon = { Coordinates = coords; Time = newTime }
    newPhenomenon

let debugLocation (p : Phenomenon) =
    printfn $"X location: {p.Coordinates.Xcoord}" 
    printfn $"Y location: {p.Coordinates.Ycoord}"
    printfn $"Time: {p.Time}"
    
let something = {Coordinates = {Xcoord = 0; Ycoord = 0}; Time = 0}
let force = { ForceAppliedX = 10; ForceAppliedY = 10 }
debugLocation something
let somethingChanged = translate something force 
debugLocation somethingChanged
