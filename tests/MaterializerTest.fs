module magic.tests.MaterializerTest

open NUnit.Framework
open magic.Magic

[<Test>]
let ``Should create a scope that can view everything`` () =
    Assert.AreEqual(Materializer.materialize 1, 1)