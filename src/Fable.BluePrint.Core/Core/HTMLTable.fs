namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type IHTMLTableProps =
    | Bordered of bool
    | Condensed of bool
    | ElementRef of (obj -> unit)
    | Interactive of bool
    | Striped of bool

[<RequireQualifiedAccess>]
module HTMLTable =
    let inline htmlTable (props : IHTMLTableProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "HTMLTable" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
