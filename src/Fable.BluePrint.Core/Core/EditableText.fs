namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

type IEditableTextProps =
    | ClassName of string
    | ConfirmOnEnterKey of bool
    | DefaultValue of string
    | Disabled of bool
    | Intent of Intent
    | IsEditing of bool
    | MaxLength of int
    | MaxLines of int
    | MinLines of int
    | MinWidth of int
    | Multiline of bool
    | OnCancel of (string -> unit)
    | OnChange of (string -> unit)
    | OnConfirm of (string -> unit)
    | OnEdit of (string -> unit)
    | Placeholder of string
    | SelectAllOnFocus of bool
    | Value of string

[<RequireQualifiedAccess>]
module EditableText =
    let inline editableText (props : IEditableTextProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "EditableText" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
