module Tests

open FsCheck.Xunit

open SwappingVariablesC

[<Property>]
let ``Switch two variables using a temp variable`` (a1: int, b1: int) =
    let result = Swapper.Vanilla(a1, b1)
    result = (b1, a1)

[<Property>]
let ``Switch two variables using addition and subtraction`` (a1: int, b1: int) =
    Swapper.AdditionAndSubtraction(a1, b1) = Swapper.Vanilla(a1, b1)

[<Property>]
let ``Switch two variables using multiplication and division`` (a1: int, b1: int) =
    Swapper.MultiplicationAndDivision(a1, b1) = Swapper.Vanilla(a1, b1)

[<Property>]
let ``Switch two variables using XOR`` (a1: int, b1: int) =
    Swapper.Xor(a1, b1) = Swapper.Vanilla(a1, b1)

[<Property>]
let ``Switch two variables using tuple deconstruction`` (a1: int, b1: int) =
    Swapper.TupleDeconstruction(a1, b1) = Swapper.Vanilla(a1, b1)