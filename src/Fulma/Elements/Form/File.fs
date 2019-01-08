namespace Fulma

open Fulma
open Fable.Helpers.React
open Fable.Helpers.React.Props

[<RequireQualifiedAccess>]
module File =

    module Classes =
        let [<Literal>] Container = "file"
        let [<Literal>] Cta = "file-cta"
        let [<Literal>] Name = "file-name"
        let [<Literal>] Icon = "file-icon"
        let [<Literal>] Label = "file-label"
        let [<Literal>] Input = "file-input"
        module State =
            let [<Literal>] IsFocused = "is-focused"
            let [<Literal>] IsActive = "is-active"
            let [<Literal>] IsHovered = "is-hovered"
        module Size =
            let [<Literal>] IsSmall = "is-small"
            let [<Literal>] IsMedium = "is-medium"
            let [<Literal>] IsLarge = "is-large"
            let [<Literal>] IsFullwidth = "is-fullwidth"
        module Alignment =
            let [<Literal>] IsCentered = "is-centered"
            let [<Literal>] IsRight = "is-right"
        let [<Literal>] IsBoxed = "is-boxed"
        let [<Literal>] HasName = "has-name"
        let [<Literal>] IsEmpty = "is-empty"

    type Option =
        | CustomClass of string
        | Props of IHTMLProp list
        /// Add `is-focused` class if true
        | IsFocused of bool
        /// Add `is-active` class if true
        | IsActive of bool
        /// Add `is-hovered` class if true
        | IsHovered of bool
        | Size of ISize
        /// Add `is-fullwidth` class
        | IsFullWidth
        /// Add `is-centered` class
        | IsCentered
        /// Add `is-right` class
        | IsRight
        /// Add `is-boxed` class
        | IsBoxed
        /// Add `has-name` class
        | HasName
        /// Add `is-empty` class if true
        | IsEmpty of bool
        | Color of IColor
        | Modifiers of Modifier.IModifier list

    type internal  Options =
        { CustomClass : string option
          Props : IHTMLProp list
          IsFocused : bool
          IsActive : bool
          IsHovered : bool
          Size : string option
          Alignment : string option
          IsBoxed : bool
          Color : string option
          HasName : bool
          IsEmpty : bool
          Modifiers : string option list }

        static member Empty =
            { CustomClass = None
              Props = []
              IsFocused = false
              IsActive = false
              IsHovered = false
              Size = None
              Alignment = None
              IsBoxed = false
              Color = None
              HasName = false
              IsEmpty = false
              Modifiers = [] }

    /// Generate <div class="file"></div>
    let file (options : Option list) children =
        let parseOptions (result : Options) option =
            match option with
            | CustomClass customClass -> { result with CustomClass = customClass |> Some }
            | Props props -> { result with Props = props }
            | IsFocused state -> { result with IsFocused = state }
            | IsActive state -> { result with IsActive = state }
            | IsHovered state -> { result with IsHovered = state }
            | Size size -> { result with Size = ofSize size |> Some }
            | IsFullWidth -> { result with Size = Classes.Size.IsFullwidth |> Some }
            | IsCentered -> { result with Alignment = Classes.Alignment.IsCentered |> Some }
            | IsRight -> { result with Alignment = Classes.Alignment.IsRight |> Some }
            | Color color -> { result with Color = ofColor color |> Some }
            | IsBoxed -> { result with IsBoxed = true }
            | HasName -> { result with HasName = true }
            | IsEmpty state -> { result with IsEmpty = state }
            | Modifiers modifiers -> { result with Modifiers = modifiers |> Modifier.parseModifiers }

        let opts = options |> List.fold parseOptions Options.Empty
        let classes =
            Helpers.classes
                Classes.Container
                ( opts.CustomClass
                  ::opts.Size
                  ::opts.Alignment
                  ::opts.Color
                  ::opts.Modifiers )
                [ Classes.IsBoxed, opts.IsBoxed
                  Classes.HasName, opts.HasName
                  Classes.State.IsFocused, opts.IsFocused
                  Classes.State.IsActive, opts.IsActive
                  Classes.State.IsHovered, opts.IsHovered
                  Classes.IsEmpty, opts.IsEmpty ]
        div (classes::opts.Props) children

    /// Generate <span class="file-cta"></span>
    let cta (options : GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Cta ( opts.CustomClass::opts.Modifiers ) []
        span (classes::opts.Props) children

    /// Generate <span class="file-name"></span>
    let name (options : GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Name ( opts.CustomClass::opts.Modifiers ) []
        span (classes::opts.Props) children

    /// Generate <span class="file-icon"></span>
    let icon (options : GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Icon ( opts.CustomClass::opts.Modifiers ) []
        span (classes::opts.Props) children

    /// Generate <label class="file-label"></label>
    let label (options : GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Label ( opts.CustomClass::opts.Modifiers ) []
        Fable.Helpers.React.label (classes::opts.Props) children

    /// Generate <input type="file" class="file-input" />
    let input (options : GenericOption list) =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Input ( opts.CustomClass::opts.Modifiers ) []
        input (classes::(Type "file" :> IHTMLProp)::opts.Props)
