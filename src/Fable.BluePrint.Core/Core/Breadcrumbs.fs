namespace Fable.Blueprint.Core

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.Core.JsInterop
open Fable.BluePrint.Icons

[<RequireQualifiedAccess>]
module Breadcrumbs =
    type IBreadcrumbProps =
        | ClassName of string
        | Current of bool
        | Disabled of bool
        | Href of string
        | Icon of IconNames option
        | Itent of Intent
        | OnClick of (MouseEvent -> unit)
        | Target of string
        | Text of string

    type IBreadcrumbsProps =
        | BreadcrumbRenderer of (IBreadcrumbProps list -> ReactElement list -> ReactElement)
        | ClassName of string
        | CollapseFrom of Boundary
        | CurrentBreadcrumbRenderer of (IBreadcrumbProps list -> ReactElement list -> ReactElement)
        | Items of IBreadcrumbProps []
        | MinVisibleItems of int
        | OverflowListProps of obj //TODO: Overflow props comes here
        | PopoverProps of obj //TODO: IPopoverProps comes here


    let inline Breadcrumb (props : IBreadcrumbProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Breadcrumb" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems


    let inline breadcrumbs (props : IBreadcrumbsProps list) (elems : ReactElement list) : ReactElement =
        ofImport "Breadcrumbs" "@blueprintjs/core"
            (keyValueList CaseRules.LowerFirst props) elems
