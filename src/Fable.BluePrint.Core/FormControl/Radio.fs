namespace Fable.BluePrint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop

    type IRadioProps =
        | AlignIndicator of Alignment
        | Checked of bool
        | Children of ReactNode
        | ClassName of string
        | DefaultChecked of bool
        | DefaultIndeterminate of bool
        | Disabled of bool
        | Inline of bool
        | InputRef of (ReactElement -> obj)
        | Label of string
        | LabelElement of ReactNode
        | Large of bool
        | OnChange of FormEventHandler
        | TagName of obj

    type IRadioGroupProps =
        | ClassName of string
        | Disabled of bool
        | Inline of bool
        | Label of string
        | Name of string
        | OnChange of (FormEvent -> unit)
        | Options of IOptionProps []
        | SelectedValue of string
[<RequireQualifiedAccess>]
module RadioGroup =

    let inline radioGroup (props : IRadioGroupProps list)
               (elems : ReactElement list) : ReactElement =
        ofImport "RadioGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline radio (props : IRadioProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Radio" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
