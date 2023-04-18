type Time = int

type Xcoord = int
type Ycoord = int
type Coordinates = Xcoord * Ycoord
type Phenomenon = Coordinates * Time
type Distance = int
type Length = Distance
type Width = Distance
type GameObjects = List<Phenomenon>
type ForceApplied = int
type ForceAppliedX = ForceApplied
type ForceAppliedY = ForceApplied
type Vector = ForceAppliedX * ForceAppliedY

type PlayingField = Length * Width * Time
type Game = Time * GameObjects


let be (p : Phenomenon) = p
let translate (p : Phenomenon, v : Vector) = 

printfn "Hello from F#"
