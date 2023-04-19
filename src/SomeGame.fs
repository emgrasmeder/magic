module magic.Magic.SomeGame

open Magic

let debugLocation (p: Phenomenon) =
    printfn $"X location: {p.Coordinates.X}"
    printfn $"Y location: {p.Coordinates.Y}"

let something =
    { Coordinates = { X = 0; Y = 0 }
      Id = 0 }

let force =
    { ForceAppliedX = 10
      ForceAppliedY = 10 }

debugLocation something
let somethingChanged = translate something force
debugLocation somethingChanged
