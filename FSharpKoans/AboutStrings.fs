namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// About Strings
//
// Most languages have a set of utilities for manipulating 
// strings. F# is no different.
//---------------------------------------------------------------
[<Koan(Sort = 7)>]
module ``about strings`` =

    [<Koan>]
    let StringValue() =
        let message = "hello"

        AssertEquality message "hello"

    [<Koan>]
    let StringConcatValue() =
        let message = "hello " + "world"

        AssertEquality message "hello world"

    [<Koan>]
    let FormattingStringValues() =
        let message = sprintf "F# turns it to %d!" 11

        AssertEquality message "F# turns it to 11!"

        //NOTE: you can use printf to print to standard output

        (* TRY IT: What happens if you change 11 to be something besides 
                   a number? *)

    [<Koan>]
    let FormattingOtherTypes() =
        let message = sprintf "hello %s" "world"

        AssertEquality message "hello world"

    [<Koan>]
    let FormattingAnything() =
        let message = sprintf "Formatting other types is as easy as: %A" (1, 2, 3)

        AssertEquality message "Formatting other types is as easy as: (1, 2, 3)"

    (* NOTE: For all the %formatters that you can use with string formatting 
             see: http://msdn.microsoft.com/en-us/library/ee370560.aspx *)

    [<Koan>]
    let CombineMultiline() =
        let message = "super\
                        cali\
                        fragilistic\
                        expiali\
                        docious"

        AssertEquality message "supercalifragilisticexpialidocious"

    [<Koan>]
    let ExtractValues() =
        let message = "hello world"

        let first = message.[0]
        let other = message.[4] 

        AssertEquality first 'h'
        AssertEquality other 'o'
