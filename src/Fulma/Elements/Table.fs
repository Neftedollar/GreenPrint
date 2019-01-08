namespace Fulma

open Fulma
open Fable.Helpers.React
open Fable.Helpers.React.Props

[<RequireQualifiedAccess>]
module Table =

    module Classes =
        let [<Literal>] Container = "table"
        module Row =
            module State =
                let [<Literal>] IsSelected = "is-selected"
        module Style =
          let [<Literal>] IsBordered = "is-bordered"
          let [<Literal>] IsStriped = "is-striped"
          let [<Literal>] IsFullwidth = "is-fullwidth"
          let [<Literal>] IsHoverable = "is-hoverable"
        module Spacing =
            let [<Literal>] IsNarrow = "is-narrow"

    type TableOption =
        /// Set `is-hovered` class
        | IsBordered
        /// Set `is-striped` class
        | IsStriped
        /// Add `is-fullwidth` class
        | IsFullWidth
        /// Set `is-narrow` class
        | IsNarrow
        /// Set `is-hoverable` class
        | IsHoverable
        | CustomClass of string
        | Props of IHTMLProp list
        | Modifiers of Modifier.IModifier list

    type private TableOptions =
        { IsBordered : bool
          IsStriped : bool
          IsFullwidth : bool
          IsNarrow : bool
          IsHoverable : bool
          CustomClass : string option
          Props : IHTMLProp list
          Modifiers : string option list }
        static member Empty =
            { IsBordered = false
              IsStriped = false
              IsNarrow = false
              IsFullwidth = false
              IsHoverable = false
              CustomClass = None
              Props = []
              Modifiers = [] }

    /// Generate <table class="table"></table>
    let table options children =
        let parseOptions (result : TableOptions) =
            function
            | IsBordered -> { result with IsBordered = true }
            | IsStriped -> { result with IsStriped = true }
            | IsFullWidth -> { result with IsFullwidth = true }
            | IsNarrow -> { result with IsNarrow = true }
            | IsHoverable -> { result with IsHoverable = true }
            | CustomClass customClass -> { result with CustomClass = customClass |> Some }
            | Props props -> { result with Props = props }
            | Modifiers modifiers -> { result with Modifiers = modifiers |> Modifier.parseModifiers }

        let opts = options |> List.fold parseOptions TableOptions.Empty
        let classes =
            Helpers.classes
                Classes.Container ( opts.CustomClass::opts.Modifiers )
                [ Classes.Style.IsBordered, opts.IsBordered
                  Classes.Style.IsStriped, opts.IsStriped
                  Classes.Style.IsFullwidth, opts.IsFullwidth
                  Classes.Spacing.IsNarrow, opts.IsNarrow
                  Classes.Style.IsHoverable, opts.IsHoverable ]

        table (classes::opts.Props) children
