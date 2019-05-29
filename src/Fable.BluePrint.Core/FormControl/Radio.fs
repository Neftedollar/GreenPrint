namespace Fable.BluePrint.Core

open Fable.Core
open Fable.React
open Fable.React.Props

open Fable.Core.JsInterop

    type IRadioProps =
        | AlignIndicator of Alignment
        | Checked of bool
        | Children of ReactElement
        | ClassName of string
        | DefaultChecked of bool
        | DefaultIndeterminate of bool
        | Disabled of bool
        | Inline of bool
        | InputRef of (ReactElement -> obj)
        | Label of string
        | LabelElement of ReactElement
        | Large of bool
        | OnChange of string //FormEventHandler //TODO: find the missing form event handler
        | TagName of obj
        interface IHTMLProp

    type IRadioGroupProps =
        | ClassName of string
        | Disabled of bool
        | Inline of bool
        | Label of string
        | Name of string
        | OnChange of (string -> unit) //(FormEvent -> unit) //TODO: find the missing formEvent
        | Options of IOptionProps []
        | SelectedValue of string
        interface IHTMLProp

[<RequireQualifiedAccess>]
module RadioGroup =

    let inline radioGroup (props : IHTMLProp list)
               (elems : ReactElement list) : ReactElement =
        ofImport "RadioGroup" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
    let inline radio (props : IHTMLProp list) (elems : ReactElement list) : ReactElement =
        ofImport "Radio" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
