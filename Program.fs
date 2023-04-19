type Time = int
type Id = int

type Coordinate = int

type Coordinates = { X: Coordinate; Y: Coordinate }

type Phenomenon =
    { Id: Id
      Coordinates: Coordinates
      Time: Time }

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
                Y = p.Coordinates.Y + v.ForceAppliedY }
        Time = p.Time + 1 }

let debugLocation (p: Phenomenon) =
    printfn $"X location: {p.Coordinates.X}"
    printfn $"Y location: {p.Coordinates.Y}"
    printfn $"Time: {p.Time}"

let something =
    { Coordinates = { X = 0; Y = 0 }
      Time = 0
      Id = 0 }

let force =
    { ForceAppliedX = 10
      ForceAppliedY = 10 }

debugLocation something
let somethingChanged = translate something force
debugLocation somethingChanged
