namespace Fulma

open Fulma
open Fable.Helpers.React
open Fable.Helpers.React.Props

[<RequireQualifiedAccess>]
module Hero =

    module Classes =
        let [<Literal>] Container = "hero"
        let [<Literal>] Head = "hero-head"
        let [<Literal>] Body = "hero-body"
        let [<Literal>] Foot = "hero-foot"
        module Video =
            let [<Literal>] Container = "hero-video"
            let [<Literal>] IsTransparent = "is-transparent"
        module Buttons =
            let [<Literal>] Container = "hero-buttons"
        module Style =
            let [<Literal>] IsBold = "is-bold"
        module Size =
            let [<Literal>] IsMedium = "is-medium"
            let [<Literal>] IsLarge = "is-large"
            let [<Literal>] IsHalfHeight = "is-halfheight"
            let [<Literal>] IsFullHeight = "is-fullheight"
            let [<Literal>] IsFullheightWithNavbar = "is-fullheight-with-navbar"

    type Option =
        /// Add `is-bold` class
        | IsBold
        /// Add `is-medium` class
        | IsMedium
        /// Add `is-large` class
        | IsLarge
        /// Add `is-halfheight` class
        | IsHalfHeight
        /// Add `is-fullheight` class
        /// Add `is-fullheight-with-navbar` class
        | IsFullheightWithNavbar
        | IsFullHeight
        | Color of IColor
        | CustomClass of string
        | Props of IHTMLProp list
        | Modifiers of Modifier.IModifier list

    type internal Options =
        { Props : IHTMLProp list
          IsBold : bool
          Size : string option
          Color : string option
          CustomClass : string option
          Modifiers : string option list }

        static member Empty =
            { Props = []
              IsBold = false
              Size = None
              Color = None
              CustomClass = None
              Modifiers = [] }

    /// Generate <div class="footer"></div>
    let hero (options : Option list) children =
        let parseOptions (result: Options ) opt =
            match opt with
            | Props props -> { result with Props = props }
            | IsMedium -> { result with Size = Classes.Size.IsMedium |> Some }
            | IsLarge -> { result with Size = Classes.Size.IsLarge |> Some }
            | IsHalfHeight -> { result with Size = Classes.Size.IsHalfHeight |> Some }
            | IsFullHeight -> { result with Size = Classes.Size.IsFullHeight |> Some }
            | IsFullheightWithNavbar -> { result with Size = Classes.Size.IsFullheightWithNavbar |> Some }
            | Color color -> { result with Color = ofColor color |> Some }
            | IsBold -> { result with IsBold = true }
            | CustomClass customClass -> { result with CustomClass = Some customClass }
            | Modifiers modifiers -> { result with Modifiers = modifiers |> Modifier.parseModifiers }

        let opts = options |> List.fold parseOptions Options.Empty
        let classes = Helpers.classes Classes.Container
                        ( opts.Color::opts.Size::opts.CustomClass::opts.Modifiers )
                        [Classes.Style.IsBold, opts.IsBold]
        section (classes::opts.Props) children

    /// Generate <div class="hero-head"></div>
    let head (options: GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Head ( opts.CustomClass::opts.Modifiers ) []
        div (classes::opts.Props) children

    /// Generate <div class="hero-body"></div>
    let body (options: GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Body ( opts.CustomClass::opts.Modifiers ) []
        div (classes::opts.Props) children

    /// Generate <div class="hero-foot"></div>
    let foot (options: GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Foot ( opts.CustomClass::opts.Modifiers ) []
        div (classes::opts.Props) children

    /// Generate <div class="hero-video"></div>
    let video (options: GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Video.Container ( opts.CustomClass::opts.Modifiers ) []
        div (classes::opts.Props) children

    /// Generate <div class="hero-buttons"></div>
    let buttons (options: GenericOption list) children =
        let opts = genericParse options
        let classes = Helpers.classes Classes.Buttons.Container ( opts.CustomClass::opts.Modifiers ) []
        div (classes::opts.Props) children
