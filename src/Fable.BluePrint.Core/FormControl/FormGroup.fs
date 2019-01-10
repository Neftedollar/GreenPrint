namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

    type IFormGroupProps =
        | ClassName of string
        | ContentClassName of string
        | Disabled of bool
        | HelperText of ReactElement
        | Inline of bool
        | Intent of Intent
        | Label of ReactElement
        | LabelFor of string
        | LabelInfo of ReactElement
        | Style of CSSProp
        interface IHTMLProp
[<RequireQualifiedAccess>]
module FormGroup =


    let inline formGroup (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "FormGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
