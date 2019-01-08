namespace Fulma

open Fulma
open Fable.Helpers.React
open Fable.Helpers.React.Props

[<RequireQualifiedAccess>]
module Column =

    module Classes =
        let [<Literal>] Container = "column"

        module All =
            module Width =
                let [<Literal>] IsOneQuarter = "is-one-quarter"
                let [<Literal>] IsOneThird = "is-one-thirds"
                let [<Literal>] IsHalf = "is-half"
                let [<Literal>] IsTwoThirds = "is-two-thirds"
                let [<Literal>] IsThreeQuarters = "is-three-quarters"
                let [<Literal>] Is1 = "is-1"
                let [<Literal>] Is2 = "is-2"
                let [<Literal>] Is3 = "is-3"
                let [<Literal>] Is4 = "is-4"
                let [<Literal>] Is5 = "is-5"
                let [<Literal>] Is6 = "is-6"
                let [<Literal>] Is7 = "is-7"
                let [<Literal>] Is8 = "is-8"
                let [<Literal>] Is9 = "is-9"
                let [<Literal>] Is10 = "is-10"
                let [<Literal>] Is11 = "is-11"
                let [<Literal>] Is12 = "is-12"
                let [<Literal>] IsNarrow = "is-narrow"
                let [<Literal>] IsFull = "is-full"
                let [<Literal>] IsOneFifth = "is-one-fifth"
                let [<Literal>] IsTwoFifths = "is-two-fifths"
                let [<Literal>] IsThreeFifths = "is-three-fifths"
                let [<Literal>] IsFourFifths = "is-four-fifths"

            module Offset =
                let [<Literal>] IsOneQuarter = "is-offset-one-quarter"
                let [<Literal>] IsOneThird = "is-offset-one-thirds"
                let [<Literal>] IsHalf = "is-offset-half"
                let [<Literal>] IsTwoThirds = "is-offset-two-thirds"
                let [<Literal>] IsThreeQuarters = "is-offset-three-quarters"
                let [<Literal>] Is1 = "is-offset-1"
                let [<Literal>] Is2 = "is-offset-2"
                let [<Literal>] Is3 = "is-offset-3"
                let [<Literal>] Is4 = "is-offset-4"
                let [<Literal>] Is5 = "is-offset-5"
                let [<Literal>] Is6 = "is-offset-6"
                let [<Literal>] Is7 = "is-offset-7"
                let [<Literal>] Is8 = "is-offset-8"
                let [<Literal>] Is9 = "is-offset-9"
                let [<Literal>] Is10 = "is-offset-10"
                let [<Literal>] Is11 = "is-offset-11"
                let [<Literal>] Is12 = "is-offset-12"
                let [<Literal>] IsNarrow = "is-offset-narrow"
                let [<Literal>] IsFull = "is-offset-full"
                let [<Literal>] IsOneFifth = "is-offset-one-fifth"
                let [<Literal>] IsTwoFifths = "is-offset-two-fifths"
                let [<Literal>] IsThreeFifths = "is-offset-three-fifths"
                let [<Literal>] IsFourFifths = "is-offset-four-fifths"

        module Desktop =
            module Width =
                let [<Literal>] IsOneQuarter = "is-one-quarter-desktop"
                let [<Literal>] IsOneThird = "is-one-thirds-desktop"
                let [<Literal>] IsHalf = "is-half-desktop"
                let [<Literal>] IsTwoThirds = "is-two-thirds-desktop"
                let [<Literal>] IsThreeQuarters = "is-three-quarters-desktop"
                let [<Literal>] Is1 = "is-1-desktop"
                let [<Literal>] Is2 = "is-2-desktop"
                let [<Literal>] Is3 = "is-3-desktop"
                let [<Literal>] Is4 = "is-4-desktop"
                let [<Literal>] Is5 = "is-5-desktop"
                let [<Literal>] Is6 = "is-6-desktop"
                let [<Literal>] Is7 = "is-7-desktop"
                let [<Literal>] Is8 = "is-8-desktop"
                let [<Literal>] Is9 = "is-9-desktop"
                let [<Literal>] Is10 = "is-10-desktop"
                let [<Literal>] Is11 = "is-11-desktop"
                let [<Literal>] Is12 = "is-12-desktop"
                let [<Literal>] IsNarrow = "is-narrow-desktop"
                let [<Literal>] IsFull = "is-full-desktop"
                let [<Literal>] IsOneFifth = "is-one-fifth-desktop"
                let [<Literal>] IsTwoFifths = "is-two-fifths-desktop"
                let [<Literal>] IsThreeFifths = "is-three-fifths-desktop"
                let [<Literal>] IsFourFifths = "is-four-fifths-desktop"

            module Offset =
                let [<Literal>] IsOneQuarter = "is-offset-one-quarter-desktop"
                let [<Literal>] IsOneThird = "is-offset-one-thirds-desktop"
                let [<Literal>] IsHalf = "is-offset-half-desktop"
                let [<Literal>] IsTwoThirds = "is-offset-two-third-desktop"
                let [<Literal>] IsThreeQuarters = "is-offset-three-quarters-desktop"
                let [<Literal>] Is1 = "is-offset-1-desktop"
                let [<Literal>] Is2 = "is-offset-2-desktop"
                let [<Literal>] Is3 = "is-offset-3-desktop"
                let [<Literal>] Is4 = "is-offset-4-desktop"
                let [<Literal>] Is5 = "is-offset-5-desktop"
                let [<Literal>] Is6 = "is-offset-6-desktop"
                let [<Literal>] Is7 = "is-offset-7-desktop"
                let [<Literal>] Is8 = "is-offset-8-desktop"
                let [<Literal>] Is9 = "is-offset-9-desktop"
                let [<Literal>] Is10 = "is-offset-10-desktop"
                let [<Literal>] Is11 = "is-offset-11-desktop"
                let [<Literal>] Is12 = "is-offset-12-desktop"
                let [<Literal>] IsNarrow = "is-offset-narrow-desktop"
                let [<Literal>] IsFull = "is-offset-full-desktop"
                let [<Literal>] IsOneFifth = "is-offset-one-fifth-desktop"
                let [<Literal>] IsTwoFifths = "is-offset-two-fifths-desktop"
                let [<Literal>] IsThreeFifths = "is-offset-three-fifths-desktop"
                let [<Literal>] IsFourFifths = "is-offset-four-fifths-desktop"

        module Mobile =
            module Width =
                let [<Literal>] IsOneQuarter = "is-one-quarter-mobile"
                let [<Literal>] IsOneThird = "is-one-thirds-mobile"
                let [<Literal>] IsHalf = "is-half-mobile"
                let [<Literal>] IsTwoThirds = "is-two-thirds-mobile"
                let [<Literal>] IsThreeQuarters = "is-three-quarters-mobile"
                let [<Literal>] Is1 = "is-1-mobile"
                let [<Literal>] Is2 = "is-2-mobile"
                let [<Literal>] Is3 = "is-3-mobile"
                let [<Literal>] Is4 = "is-4-mobile"
                let [<Literal>] Is5 = "is-5-mobile"
                let [<Literal>] Is6 = "is-6-mobile"
                let [<Literal>] Is7 = "is-7-mobile"
                let [<Literal>] Is8 = "is-8-mobile"
                let [<Literal>] Is9 = "is-9-mobile"
                let [<Literal>] Is10 = "is-10-mobile"
                let [<Literal>] Is11 = "is-11-mobile"
                let [<Literal>] Is12 = "is-12-mobile"
                let [<Literal>] IsNarrow = "is-narrow-mobile"
                let [<Literal>] IsFull = "is-full-mobile"
                let [<Literal>] IsOneFifth = "is-one-fifth-mobile"
                let [<Literal>] IsTwoFifths = "is-two-fifths-mobile"
                let [<Literal>] IsThreeFifths = "is-three-fifths-mobile"
                let [<Literal>] IsFourFifths = "is-four-fifths-mobile"

            module Offset =
                let [<Literal>] IsOneQuarter = "is-offset-one-quarter-mobile"
                let [<Literal>] IsOneThird = "is-offset-one-thirds-mobile"
                let [<Literal>] IsHalf = "is-offset-half-mobile"
                let [<Literal>] IsTwoThirds = "is-offset-two-third-mobile"
                let [<Literal>] IsThreeQuarters = "is-offset-three-quarters-mobile"
                let [<Literal>] Is1 = "is-offset-1-mobile"
                let [<Literal>] Is2 = "is-offset-2-mobile"
                let [<Literal>] Is3 = "is-offset-3-mobile"
                let [<Literal>] Is4 = "is-offset-4-mobile"
                let [<Literal>] Is5 = "is-offset-5-mobile"
                let [<Literal>] Is6 = "is-offset-6-mobile"
                let [<Literal>] Is7 = "is-offset-7-mobile"
                let [<Literal>] Is8 = "is-offset-8-mobile"
                let [<Literal>] Is9 = "is-offset-9-mobile"
                let [<Literal>] Is10 = "is-offset-10-mobile"
                let [<Literal>] Is11 = "is-offset-11-mobile"
                let [<Literal>] Is12 = "is-offset-12-mobile"
                let [<Literal>] IsNarrow = "is-offset-narrow-mobile"
                let [<Literal>] IsFull = "is-offset-full-mobile"
                let [<Literal>] IsOneFifth = "is-offset-one-fifth-mobile"
                let [<Literal>] IsTwoFifths = "is-offset-two-fifths-mobile"
                let [<Literal>] IsThreeFifths = "is-offset-three-fifths-mobile"
                let [<Literal>] IsFourFifths = "is-offset-four-fifths-mobile"

        module Tablet =
            module Width =
                let [<Literal>] IsOneQuarter = "is-one-quarter-tablet"
                let [<Literal>] IsOneThird = "is-one-thirds-tablet"
                let [<Literal>] IsHalf = "is-half-tablet"
                let [<Literal>] IsTwoThirds = "is-two-thirds-tablet"
                let [<Literal>] IsThreeQuarters = "is-three-quarters-tablet"
                let [<Literal>] Is1 = "is-1-tablet"
                let [<Literal>] Is2 = "is-2-tablet"
                let [<Literal>] Is3 = "is-3-tablet"
                let [<Literal>] Is4 = "is-4-tablet"
                let [<Literal>] Is5 = "is-5-tablet"
                let [<Literal>] Is6 = "is-6-tablet"
                let [<Literal>] Is7 = "is-7-tablet"
                let [<Literal>] Is8 = "is-8-tablet"
                let [<Literal>] Is9 = "is-9-tablet"
                let [<Literal>] Is10 = "is-10-tablet"
                let [<Literal>] Is11 = "is-11-tablet"
                let [<Literal>] Is12 = "is-12-tablet"
                let [<Literal>] IsNarrow = "is-narrow-tablet"
                let [<Literal>] IsFull = "is-full-tablet"
                let [<Literal>] IsOneFifth = "is-one-fifth-tablet"
                let [<Literal>] IsTwoFifths = "is-two-fifths-tablet"
                let [<Literal>] IsThreeFifths = "is-three-fifths-tablet"
                let [<Literal>] IsFourFifths = "is-four-fifths-tablet"

            module Offset =
                let [<Literal>] IsOneQuarter = "is-offset-one-quarter-tablet"
                let [<Literal>] IsOneThird = "is-offset-one-thirds-tablet"
                let [<Literal>] IsHalf = "is-offset-half-tablet"
                let [<Literal>] IsTwoThirds = "is-offset-two-third-tablet"
                let [<Literal>] IsThreeQuarters = "is-offset-three-quarters-tablet"
                let [<Literal>] Is1 = "is-offset-1-tablet"
                let [<Literal>] Is2 = "is-offset-2-tablet"
                let [<Literal>] Is3 = "is-offset-3-tablet"
                let [<Literal>] Is4 = "is-offset-4-tablet"
                let [<Literal>] Is5 = "is-offset-5-tablet"
                let [<Literal>] Is6 = "is-offset-6-tablet"
                let [<Literal>] Is7 = "is-offset-7-tablet"
                let [<Literal>] Is8 = "is-offset-8-tablet"
                let [<Literal>] Is9 = "is-offset-9-tablet"
                let [<Literal>] Is10 = "is-offset-10-tablet"
                let [<Literal>] Is11 = "is-offset-11-tablet"
                let [<Literal>] Is12 = "is-offset-12-tablet"
                let [<Literal>] IsNarrow = "is-offset-narrow-tablet"
                let [<Literal>] IsFull = "is-offset-full-tablet"
                let [<Literal>] IsOneFifth = "is-offset-one-fifth-tablet"
                let [<Literal>] IsTwoFifths = "is-offset-two-fifths-tablet"
                let [<Literal>] IsThreeFifths = "is-offset-three-fifths-tablet"
                let [<Literal>] IsFourFifths = "is-offset-four-fifths-tablet"

        module WideScreen =
            module Width =
                let [<Literal>] IsOneQuarter = "is-one-quarter-widescreen"
                let [<Literal>] IsOneThird = "is-one-thirds-widescreen"
                let [<Literal>] IsHalf = "is-half-widescreen"
                let [<Literal>] IsTwoThirds = "is-two-thirds-widescreen"
                let [<Literal>] IsThreeQuarters = "is-three-quarters-widescreen"
                let [<Literal>] Is1 = "is-1-widescreen"
                let [<Literal>] Is2 = "is-2-widescreen"
                let [<Literal>] Is3 = "is-3-widescreen"
                let [<Literal>] Is4 = "is-4-widescreen"
                let [<Literal>] Is5 = "is-5-widescreen"
                let [<Literal>] Is6 = "is-6-widescreen"
                let [<Literal>] Is7 = "is-7-widescreen"
                let [<Literal>] Is8 = "is-8-widescreen"
                let [<Literal>] Is9 = "is-9-widescreen"
                let [<Literal>] Is10 = "is-10-widescreen"
                let [<Literal>] Is11 = "is-11-widescreen"
                let [<Literal>] Is12 = "is-12-widescreen"
                let [<Literal>] IsNarrow = "is-narrow-widescreen"
                let [<Literal>] IsFull = "is-full-widescreen"
                let [<Literal>] IsOneFifth = "is-one-fifth-widescreen"
                let [<Literal>] IsTwoFifths = "is-two-fifths-widescreen"
                let [<Literal>] IsThreeFifths = "is-three-fifths-widescreen"
                let [<Literal>] IsFourFifths = "is-four-fifths-widescreen"

            module Offset =
                let [<Literal>] IsOneQuarter = "is-offset-one-quarter-widescreen"
                let [<Literal>] IsOneThird = "is-offset-one-thirds-widescreen"
                let [<Literal>] IsHalf = "is-offset-half-widescreen"
                let [<Literal>] IsTwoThirds = "is-offset-two-third-widescreen"
                let [<Literal>] IsThreeQuarters = "is-offset-three-quarters-widescreen"
                let [<Literal>] Is1 = "is-offset-1-widescreen"
                let [<Literal>] Is2 = "is-offset-2-widescreen"
                let [<Literal>] Is3 = "is-offset-3-widescreen"
                let [<Literal>] Is4 = "is-offset-4-widescreen"
                let [<Literal>] Is5 = "is-offset-5-widescreen"
                let [<Literal>] Is6 = "is-offset-6-widescreen"
                let [<Literal>] Is7 = "is-offset-7-widescreen"
                let [<Literal>] Is8 = "is-offset-8-widescreen"
                let [<Literal>] Is9 = "is-offset-9-widescreen"
                let [<Literal>] Is10 = "is-offset-10-widescreen"
                let [<Literal>] Is11 = "is-offset-11-widescreen"
                let [<Literal>] IsNarrow = "is-offset-narrow-widescreen"
                let [<Literal>] IsFull = "is-offset-full-widescreen"
                let [<Literal>] IsOneFifth = "is-offset-one-fifth-widescreen"
                let [<Literal>] IsTwoFifths = "is-offset-two-fifths-widescreen"
                let [<Literal>] IsThreeFifths = "is-offset-three-fifths-widescreen"
                let [<Literal>] IsFourFifths = "is-offset-four-fifths-widescreen"

        module FullHD =
            module Width =
                let [<Literal>] IsOneQuarter = "is-one-quarter-fullhd"
                let [<Literal>] IsOneThird = "is-one-thirds-fullhd"
                let [<Literal>] IsHalf = "is-half-fullhd"
                let [<Literal>] IsTwoThirds = "is-two-thirds-fullhd"
                let [<Literal>] IsThreeQuarters = "is-three-quarters-fullhd"
                let [<Literal>] Is1 = "is-1-fullhd"
                let [<Literal>] Is2 = "is-2-fullhd"
                let [<Literal>] Is3 = "is-3-fullhd"
                let [<Literal>] Is4 = "is-4-fullhd"
                let [<Literal>] Is5 = "is-5-fullhd"
                let [<Literal>] Is6 = "is-6-fullhd"
                let [<Literal>] Is7 = "is-7-fullhd"
                let [<Literal>] Is8 = "is-8-fullhd"
                let [<Literal>] Is9 = "is-9-fullhd"
                let [<Literal>] Is10 = "is-10-fullhd"
                let [<Literal>] Is11 = "is-11-fullhd"
                let [<Literal>] Is12 = "is-12-fullhd"
                let [<Literal>] IsNarrow = "is-narrow-fullhd"
                let [<Literal>] IsFull = "is-full-fullhd"
                let [<Literal>] IsOneFifth = "is-one-fifth-fullhd"
                let [<Literal>] IsTwoFifths = "is-two-fifths-fullhd"
                let [<Literal>] IsThreeFifths = "is-three-fifths-fullhd"
                let [<Literal>] IsFourFifths = "is-four-fifths-fullhd"

            module Offset =
                let [<Literal>] IsOneQuarter = "is-offset-one-quarter-fullhd"
                let [<Literal>] IsOneThird = "is-offset-one-thirds-fullhd"
                let [<Literal>] IsHalf = "is-offset-half-fullhd"
                let [<Literal>] IsTwoThirds = "is-offset-two-third-fullhd"
                let [<Literal>] IsThreeQuarters = "is-offset-three-quarters-fullhd"
                let [<Literal>] Is1 = "is-offset-1-fullhd"
                let [<Literal>] Is2 = "is-offset-2-fullhd"
                let [<Literal>] Is3 = "is-offset-3-fullhd"
                let [<Literal>] Is4 = "is-offset-4-fullhd"
                let [<Literal>] Is5 = "is-offset-5-fullhd"
                let [<Literal>] Is6 = "is-offset-6-fullhd"
                let [<Literal>] Is7 = "is-offset-7-fullhd"
                let [<Literal>] Is8 = "is-offset-8-fullhd"
                let [<Literal>] Is9 = "is-offset-9-fullhd"
                let [<Literal>] Is10 = "is-offset-10-fullhd"
                let [<Literal>] Is11 = "is-offset-11-fullhd"
                let [<Literal>] Is12 = "is-offset-12-fullhd"
                let [<Literal>] IsNarrow = "is-offset-narrow-fullhd"
                let [<Literal>] IsFull = "is-offset-full-fullhd"
                let [<Literal>] IsOneFifth = "is-offset-one-fifth-fullhd"
                let [<Literal>] IsTwoFifths = "is-offset-two-fifths-fullhd"
                let [<Literal>] IsThreeFifths = "is-offset-three-fifths-fullhd"
                let [<Literal>] IsFourFifths = "is-offset-four-fifths-fullhd"

        module Touch =
            module Width =
                let [<Literal>] IsOneQuarter = "is-one-quarter-touch"
                let [<Literal>] IsOneThird = "is-one-thirds-touch"
                let [<Literal>] IsHalf = "is-half-touch"
                let [<Literal>] IsTwoThirds = "is-two-thirds-touch"
                let [<Literal>] IsThreeQuarters = "is-three-quarters-touch"
                let [<Literal>] Is1 = "is-1-touch"
                let [<Literal>] Is2 = "is-2-touch"
                let [<Literal>] Is3 = "is-3-touch"
                let [<Literal>] Is4 = "is-4-touch"
                let [<Literal>] Is5 = "is-5-touch"
                let [<Literal>] Is6 = "is-6-touch"
                let [<Literal>] Is7 = "is-7-touch"
                let [<Literal>] Is8 = "is-8-touch"
                let [<Literal>] Is9 = "is-9-touch"
                let [<Literal>] Is10 = "is-10-touch"
                let [<Literal>] Is11 = "is-11-touch"
                let [<Literal>] Is12 = "is-12-touch"
                let [<Literal>] IsNarrow = "is-narrow-touch"
                let [<Literal>] IsFull = "is-full-touch"
                let [<Literal>] IsOneFifth = "is-one-fifth-touch"
                let [<Literal>] IsTwoFifths = "is-two-fifths-touch"
                let [<Literal>] IsThreeFifths = "is-three-fifths-touch"
                let [<Literal>] IsFourFifths = "is-four-fifths-touch"

            module Offset =
                let [<Literal>] IsOneQuarter = "is-offset-one-quarter-touch"
                let [<Literal>] IsOneThird = "is-offset-one-thirds-touch"
                let [<Literal>] IsHalf = "is-offset-half-touch"
                let [<Literal>] IsTwoThirds = "is-offset-two-third-touch"
                let [<Literal>] IsThreeQuarters = "is-offset-three-quarters-touch"
                let [<Literal>] Is1 = "is-offset-1-touch"
                let [<Literal>] Is2 = "is-offset-2-touch"
                let [<Literal>] Is3 = "is-offset-3-touch"
                let [<Literal>] Is4 = "is-offset-4-touch"
                let [<Literal>] Is5 = "is-offset-5-touch"
                let [<Literal>] Is6 = "is-offset-6-touch"
                let [<Literal>] Is7 = "is-offset-7-touch"
                let [<Literal>] Is8 = "is-offset-8-touch"
                let [<Literal>] Is9 = "is-offset-9-touch"
                let [<Literal>] Is10 = "is-offset-10-touch"
                let [<Literal>] Is11 = "is-offset-11-touch"
                let [<Literal>] Is12 = "is-offset-12-touch"
                let [<Literal>] IsNarrow = "is-offset-narrow-touch"
                let [<Literal>] IsFull = "is-offset-full-touch"
                let [<Literal>] IsOneFifth = "is-offset-one-fifth-touch"
                let [<Literal>] IsTwoFifths = "is-offset-two-fifths-touch"
                let [<Literal>] IsThreeFifths = "is-offset-three-fifths-touch"
                let [<Literal>] IsFourFifths = "is-offset-four-fifths-touch"

    type ISize =
        | IsOneQuarter
        | IsOneThird
        | IsHalf
        | IsTwoThirds
        | IsThreeQuarters
        | Is1
        | Is2
        | Is3
        | Is4
        | Is5
        | Is6
        | Is7
        | Is8
        | Is9
        | Is10
        | Is11
        | Is12
        | IsNarrow
        | IsFull
        | IsOneFifth
        | IsTwoFifths
        | IsThreeFifths
        | IsFourFifths

    type Option =
        /// Configure the width of the column. You can configure the display and size
        /// Example: Column.Width (Column.Desktop, Column.Is6)
        /// Becomes: `is-6-desktop`
        | Width of Screen * ISize
        /// Configure the offset of the column. You can configure the display and offset size
        /// Example: Column.Offset (Column.Desktop, Column.Is6)
        /// Becomes: `is-offset-6-desktop`
        | Offset of Screen * ISize
        | CustomClass of string
        | Props of IHTMLProp list
        | Modifiers of Modifier.IModifier list

    let internal ofWidth =
        function
        | Screen.All, size ->
            match size with
            | IsOneQuarter -> Classes.All.Width.IsOneQuarter
            | IsOneThird -> Classes.All.Width.IsOneThird
            | IsHalf -> Classes.All.Width.IsHalf
            | IsTwoThirds -> Classes.All.Width.IsTwoThirds
            | IsThreeQuarters -> Classes.All.Width.IsThreeQuarters
            | Is1 -> Classes.All.Width.Is1
            | Is2 -> Classes.All.Width.Is2
            | Is3 -> Classes.All.Width.Is3
            | Is4 -> Classes.All.Width.Is4
            | Is5 -> Classes.All.Width.Is5
            | Is6 -> Classes.All.Width.Is6
            | Is7 -> Classes.All.Width.Is7
            | Is8 -> Classes.All.Width.Is8
            | Is9 -> Classes.All.Width.Is9
            | Is10 -> Classes.All.Width.Is10
            | Is11 -> Classes.All.Width.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.All.Width.IsNarrow
            | IsFull -> Classes.All.Width.IsFull
            | IsOneFifth -> Classes.All.Width.IsOneFifth
            | IsTwoFifths -> Classes.All.Width.IsTwoFifths
            | IsThreeFifths -> Classes.All.Width.IsThreeFifths
            | IsFourFifths -> Classes.All.Width.IsFourFifths
        | Screen.Desktop, size ->
            match size with
            | IsOneQuarter -> Classes.Desktop.Width.IsOneQuarter
            | IsOneThird -> Classes.Desktop.Width.IsOneThird
            | IsHalf -> Classes.Desktop.Width.IsHalf
            | IsTwoThirds -> Classes.Desktop.Width.IsTwoThirds
            | IsThreeQuarters -> Classes.Desktop.Width.IsThreeQuarters
            | Is1 -> Classes.Desktop.Width.Is1
            | Is2 -> Classes.Desktop.Width.Is2
            | Is3 -> Classes.Desktop.Width.Is3
            | Is4 -> Classes.Desktop.Width.Is4
            | Is5 -> Classes.Desktop.Width.Is5
            | Is6 -> Classes.Desktop.Width.Is6
            | Is7 -> Classes.Desktop.Width.Is7
            | Is8 -> Classes.Desktop.Width.Is8
            | Is9 -> Classes.Desktop.Width.Is9
            | Is10 -> Classes.Desktop.Width.Is10
            | Is11 -> Classes.Desktop.Width.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.Desktop.Width.IsNarrow
            | IsFull -> Classes.Desktop.Width.IsFull
            | IsOneFifth -> Classes.Desktop.Width.IsOneFifth
            | IsTwoFifths -> Classes.Desktop.Width.IsTwoFifths
            | IsThreeFifths -> Classes.Desktop.Width.IsThreeFifths
            | IsFourFifths -> Classes.Desktop.Width.IsFourFifths
        | Screen.Tablet, size ->
            match size with
            | IsOneQuarter -> Classes.Tablet.Width.IsOneQuarter
            | IsOneThird -> Classes.Tablet.Width.IsOneThird
            | IsHalf -> Classes.Tablet.Width.IsHalf
            | IsTwoThirds -> Classes.Tablet.Width.IsTwoThirds
            | IsThreeQuarters -> Classes.Tablet.Width.IsThreeQuarters
            | Is1 -> Classes.Tablet.Width.Is1
            | Is2 -> Classes.Tablet.Width.Is2
            | Is3 -> Classes.Tablet.Width.Is3
            | Is4 -> Classes.Tablet.Width.Is4
            | Is5 -> Classes.Tablet.Width.Is5
            | Is6 -> Classes.Tablet.Width.Is6
            | Is7 -> Classes.Tablet.Width.Is7
            | Is8 -> Classes.Tablet.Width.Is8
            | Is9 -> Classes.Tablet.Width.Is9
            | Is10 -> Classes.Tablet.Width.Is10
            | Is11 -> Classes.Tablet.Width.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.Tablet.Width.IsNarrow
            | IsFull -> Classes.Tablet.Width.IsFull
            | IsOneFifth -> Classes.Tablet.Width.IsOneFifth
            | IsTwoFifths -> Classes.Tablet.Width.IsTwoFifths
            | IsThreeFifths -> Classes.Tablet.Width.IsThreeFifths
            | IsFourFifths -> Classes.Tablet.Width.IsFourFifths
        | Screen.Mobile, size ->
            match size with
            | IsOneQuarter -> Classes.Mobile.Width.IsOneQuarter
            | IsOneThird -> Classes.Mobile.Width.IsOneThird
            | IsHalf -> Classes.Mobile.Width.IsHalf
            | IsTwoThirds -> Classes.Mobile.Width.IsTwoThirds
            | IsThreeQuarters -> Classes.Mobile.Width.IsThreeQuarters
            | Is1 -> Classes.Mobile.Width.Is1
            | Is2 -> Classes.Mobile.Width.Is2
            | Is3 -> Classes.Mobile.Width.Is3
            | Is4 -> Classes.Mobile.Width.Is4
            | Is5 -> Classes.Mobile.Width.Is5
            | Is6 -> Classes.Mobile.Width.Is6
            | Is7 -> Classes.Mobile.Width.Is7
            | Is8 -> Classes.Mobile.Width.Is8
            | Is9 -> Classes.Mobile.Width.Is9
            | Is10 -> Classes.Mobile.Width.Is10
            | Is11 -> Classes.Mobile.Width.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.Mobile.Width.IsNarrow
            | IsFull -> Classes.Mobile.Width.IsFull
            | IsOneFifth -> Classes.Mobile.Width.IsOneFifth
            | IsTwoFifths -> Classes.Mobile.Width.IsTwoFifths
            | IsThreeFifths -> Classes.Mobile.Width.IsThreeFifths
            | IsFourFifths -> Classes.Mobile.Width.IsFourFifths
        | Screen.WideScreen, size ->
            match size with
            | IsOneQuarter -> Classes.WideScreen.Width.IsOneQuarter
            | IsOneThird -> Classes.WideScreen.Width.IsOneThird
            | IsHalf -> Classes.WideScreen.Width.IsHalf
            | IsTwoThirds -> Classes.WideScreen.Width.IsTwoThirds
            | IsThreeQuarters -> Classes.WideScreen.Width.IsThreeQuarters
            | Is1 -> Classes.WideScreen.Width.Is1
            | Is2 -> Classes.WideScreen.Width.Is2
            | Is3 -> Classes.WideScreen.Width.Is3
            | Is4 -> Classes.WideScreen.Width.Is4
            | Is5 -> Classes.WideScreen.Width.Is5
            | Is6 -> Classes.WideScreen.Width.Is6
            | Is7 -> Classes.WideScreen.Width.Is7
            | Is8 -> Classes.WideScreen.Width.Is8
            | Is9 -> Classes.WideScreen.Width.Is9
            | Is10 -> Classes.WideScreen.Width.Is10
            | Is11 -> Classes.WideScreen.Width.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.WideScreen.Width.IsNarrow
            | IsFull -> Classes.WideScreen.Width.IsFull
            | IsOneFifth -> Classes.WideScreen.Width.IsOneFifth
            | IsTwoFifths -> Classes.WideScreen.Width.IsTwoFifths
            | IsThreeFifths -> Classes.WideScreen.Width.IsThreeFifths
            | IsFourFifths -> Classes.WideScreen.Width.IsFourFifths
        | Screen.FullHD, size ->
            match size with
            | IsOneQuarter -> Classes.FullHD.Width.IsOneQuarter
            | IsOneThird -> Classes.FullHD.Width.IsOneThird
            | IsHalf -> Classes.FullHD.Width.IsHalf
            | IsTwoThirds -> Classes.FullHD.Width.IsTwoThirds
            | IsThreeQuarters -> Classes.FullHD.Width.IsThreeQuarters
            | Is1 -> Classes.FullHD.Width.Is1
            | Is2 -> Classes.FullHD.Width.Is2
            | Is3 -> Classes.FullHD.Width.Is3
            | Is4 -> Classes.FullHD.Width.Is4
            | Is5 -> Classes.FullHD.Width.Is5
            | Is6 -> Classes.FullHD.Width.Is6
            | Is7 -> Classes.FullHD.Width.Is7
            | Is8 -> Classes.FullHD.Width.Is8
            | Is9 -> Classes.FullHD.Width.Is9
            | Is10 -> Classes.FullHD.Width.Is10
            | Is11 -> Classes.FullHD.Width.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.FullHD.Width.IsNarrow
            | IsFull -> Classes.FullHD.Width.IsFull
            | IsOneFifth -> Classes.FullHD.Width.IsOneFifth
            | IsTwoFifths -> Classes.FullHD.Width.IsTwoFifths
            | IsThreeFifths -> Classes.FullHD.Width.IsThreeFifths
            | IsFourFifths -> Classes.FullHD.Width.IsFourFifths
        | Screen.Touch, size ->
            match size with
            | IsOneQuarter -> Classes.Touch.Width.IsOneQuarter
            | IsOneThird -> Classes.Touch.Width.IsOneThird
            | IsHalf -> Classes.Touch.Width.IsHalf
            | IsTwoThirds -> Classes.Touch.Width.IsTwoThirds
            | IsThreeQuarters -> Classes.Touch.Width.IsThreeQuarters
            | Is1 -> Classes.Touch.Width.Is1
            | Is2 -> Classes.Touch.Width.Is2
            | Is3 -> Classes.Touch.Width.Is3
            | Is4 -> Classes.Touch.Width.Is4
            | Is5 -> Classes.Touch.Width.Is5
            | Is6 -> Classes.Touch.Width.Is6
            | Is7 -> Classes.Touch.Width.Is7
            | Is8 -> Classes.Touch.Width.Is8
            | Is9 -> Classes.Touch.Width.Is9
            | Is10 -> Classes.Touch.Width.Is10
            | Is11 -> Classes.Touch.Width.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.Touch.Width.IsNarrow
            | IsFull -> Classes.Touch.Width.IsFull
            | IsOneFifth -> Classes.Touch.Width.IsOneFifth
            | IsTwoFifths -> Classes.Touch.Width.IsTwoFifths
            | IsThreeFifths -> Classes.Touch.Width.IsThreeFifths
            | IsFourFifths -> Classes.Touch.Width.IsFourFifths

    let internal ofOffset =
        function
        | Screen.All, offset ->
            match offset with
            | IsOneQuarter -> Classes.All.Offset.IsOneQuarter
            | IsOneThird -> Classes.All.Offset.IsOneThird
            | IsHalf -> Classes.All.Offset.IsHalf
            | IsTwoThirds -> Classes.All.Offset.IsTwoThirds
            | IsThreeQuarters -> Classes.All.Offset.IsThreeQuarters
            | Is1 -> Classes.All.Offset.Is1
            | Is2 -> Classes.All.Offset.Is2
            | Is3 -> Classes.All.Offset.Is3
            | Is4 -> Classes.All.Offset.Is4
            | Is5 -> Classes.All.Offset.Is5
            | Is6 -> Classes.All.Offset.Is6
            | Is7 -> Classes.All.Offset.Is7
            | Is8 -> Classes.All.Offset.Is8
            | Is9 -> Classes.All.Offset.Is9
            | Is10 -> Classes.All.Offset.Is10
            | Is11 -> Classes.All.Offset.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.All.Offset.IsNarrow
            | IsFull -> Classes.All.Offset.IsFull
            | IsOneFifth -> Classes.All.Offset.IsOneFifth
            | IsTwoFifths -> Classes.All.Offset.IsTwoFifths
            | IsThreeFifths -> Classes.All.Offset.IsThreeFifths
            | IsFourFifths -> Classes.All.Offset.IsFourFifths
        | Screen.Desktop, offset ->
            match offset with
            | IsOneQuarter -> Classes.Desktop.Offset.IsOneQuarter
            | IsOneThird -> Classes.Desktop.Offset.IsOneThird
            | IsHalf -> Classes.Desktop.Offset.IsHalf
            | IsTwoThirds -> Classes.Desktop.Offset.IsTwoThirds
            | IsThreeQuarters -> Classes.Desktop.Offset.IsThreeQuarters
            | Is1 -> Classes.Desktop.Offset.Is1
            | Is2 -> Classes.Desktop.Offset.Is2
            | Is3 -> Classes.Desktop.Offset.Is3
            | Is4 -> Classes.Desktop.Offset.Is4
            | Is5 -> Classes.Desktop.Offset.Is5
            | Is6 -> Classes.Desktop.Offset.Is6
            | Is7 -> Classes.Desktop.Offset.Is7
            | Is8 -> Classes.Desktop.Offset.Is8
            | Is9 -> Classes.Desktop.Offset.Is9
            | Is10 -> Classes.Desktop.Offset.Is10
            | Is11 -> Classes.Desktop.Offset.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.Desktop.Offset.IsNarrow
            | IsFull -> Classes.Desktop.Offset.IsFull
            | IsOneFifth -> Classes.Desktop.Offset.IsOneFifth
            | IsTwoFifths -> Classes.Desktop.Offset.IsTwoFifths
            | IsThreeFifths -> Classes.Desktop.Offset.IsThreeFifths
            | IsFourFifths -> Classes.Desktop.Offset.IsFourFifths
        | Screen.Tablet, offset ->
            match offset with
            | IsOneQuarter -> Classes.Tablet.Offset.IsOneQuarter
            | IsOneThird -> Classes.Tablet.Offset.IsOneThird
            | IsHalf -> Classes.Tablet.Offset.IsHalf
            | IsTwoThirds -> Classes.Tablet.Offset.IsTwoThirds
            | IsThreeQuarters -> Classes.Tablet.Offset.IsThreeQuarters
            | Is1 -> Classes.Tablet.Offset.Is1
            | Is2 -> Classes.Tablet.Offset.Is2
            | Is3 -> Classes.Tablet.Offset.Is3
            | Is4 -> Classes.Tablet.Offset.Is4
            | Is5 -> Classes.Tablet.Offset.Is5
            | Is6 -> Classes.Tablet.Offset.Is6
            | Is7 -> Classes.Tablet.Offset.Is7
            | Is8 -> Classes.Tablet.Offset.Is8
            | Is9 -> Classes.Tablet.Offset.Is9
            | Is10 -> Classes.Tablet.Offset.Is10
            | Is11 -> Classes.Tablet.Offset.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.Tablet.Offset.IsNarrow
            | IsFull -> Classes.Tablet.Offset.IsFull
            | IsOneFifth -> Classes.Tablet.Offset.IsOneFifth
            | IsTwoFifths -> Classes.Tablet.Offset.IsTwoFifths
            | IsThreeFifths -> Classes.Tablet.Offset.IsThreeFifths
            | IsFourFifths -> Classes.Tablet.Offset.IsFourFifths
        | Screen.Mobile, offset ->
            match offset with
            | IsOneQuarter -> Classes.Mobile.Offset.IsOneQuarter
            | IsOneThird -> Classes.Mobile.Offset.IsOneThird
            | IsHalf -> Classes.Mobile.Offset.IsHalf
            | IsTwoThirds -> Classes.Mobile.Offset.IsTwoThirds
            | IsThreeQuarters -> Classes.Mobile.Offset.IsThreeQuarters
            | Is1 -> Classes.Mobile.Offset.Is1
            | Is2 -> Classes.Mobile.Offset.Is2
            | Is3 -> Classes.Mobile.Offset.Is3
            | Is4 -> Classes.Mobile.Offset.Is4
            | Is5 -> Classes.Mobile.Offset.Is5
            | Is6 -> Classes.Mobile.Offset.Is6
            | Is7 -> Classes.Mobile.Offset.Is7
            | Is8 -> Classes.Mobile.Offset.Is8
            | Is9 -> Classes.Mobile.Offset.Is9
            | Is10 -> Classes.Mobile.Offset.Is10
            | Is11 -> Classes.Mobile.Offset.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.Mobile.Offset.IsNarrow
            | IsFull -> Classes.Mobile.Offset.IsFull
            | IsOneFifth -> Classes.Mobile.Offset.IsOneFifth
            | IsTwoFifths -> Classes.Mobile.Offset.IsTwoFifths
            | IsThreeFifths -> Classes.Mobile.Offset.IsThreeFifths
            | IsFourFifths -> Classes.Mobile.Offset.IsFourFifths
        | Screen.WideScreen, offset ->
            match offset with
            | IsOneQuarter -> Classes.WideScreen.Offset.IsOneQuarter
            | IsOneThird -> Classes.WideScreen.Offset.IsOneThird
            | IsHalf -> Classes.WideScreen.Offset.IsHalf
            | IsTwoThirds -> Classes.WideScreen.Offset.IsTwoThirds
            | IsThreeQuarters -> Classes.WideScreen.Offset.IsThreeQuarters
            | Is1 -> Classes.WideScreen.Offset.Is1
            | Is2 -> Classes.WideScreen.Offset.Is2
            | Is3 -> Classes.WideScreen.Offset.Is3
            | Is4 -> Classes.WideScreen.Offset.Is4
            | Is5 -> Classes.WideScreen.Offset.Is5
            | Is6 -> Classes.WideScreen.Offset.Is6
            | Is7 -> Classes.WideScreen.Offset.Is7
            | Is8 -> Classes.WideScreen.Offset.Is8
            | Is9 -> Classes.WideScreen.Offset.Is9
            | Is10 -> Classes.WideScreen.Offset.Is10
            | Is11 -> Classes.WideScreen.Offset.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.WideScreen.Offset.IsNarrow
            | IsFull -> Classes.WideScreen.Offset.IsFull
            | IsOneFifth -> Classes.WideScreen.Offset.IsOneFifth
            | IsTwoFifths -> Classes.WideScreen.Offset.IsTwoFifths
            | IsThreeFifths -> Classes.WideScreen.Offset.IsThreeFifths
            | IsFourFifths -> Classes.WideScreen.Offset.IsFourFifths
        | Screen.FullHD, offset ->
            match offset with
            | IsOneQuarter -> Classes.FullHD.Offset.IsOneQuarter
            | IsOneThird -> Classes.FullHD.Offset.IsOneThird
            | IsHalf -> Classes.FullHD.Offset.IsHalf
            | IsTwoThirds -> Classes.FullHD.Offset.IsTwoThirds
            | IsThreeQuarters -> Classes.FullHD.Offset.IsThreeQuarters
            | Is1 -> Classes.FullHD.Offset.Is1
            | Is2 -> Classes.FullHD.Offset.Is2
            | Is3 -> Classes.FullHD.Offset.Is3
            | Is4 -> Classes.FullHD.Offset.Is4
            | Is5 -> Classes.FullHD.Offset.Is5
            | Is6 -> Classes.FullHD.Offset.Is6
            | Is7 -> Classes.FullHD.Offset.Is7
            | Is8 -> Classes.FullHD.Offset.Is8
            | Is9 -> Classes.FullHD.Offset.Is9
            | Is10 -> Classes.FullHD.Offset.Is10
            | Is11 -> Classes.FullHD.Offset.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.FullHD.Offset.IsNarrow
            | IsFull -> Classes.FullHD.Offset.IsFull
            | IsOneFifth -> Classes.FullHD.Offset.IsOneFifth
            | IsTwoFifths -> Classes.FullHD.Offset.IsTwoFifths
            | IsThreeFifths -> Classes.FullHD.Offset.IsThreeFifths
            | IsFourFifths -> Classes.FullHD.Offset.IsFourFifths
        | Screen.Touch, offset ->
            match offset with
            | IsOneQuarter -> Classes.Touch.Offset.IsOneQuarter
            | IsOneThird -> Classes.Touch.Offset.IsOneThird
            | IsHalf -> Classes.Touch.Offset.IsHalf
            | IsTwoThirds -> Classes.Touch.Offset.IsTwoThirds
            | IsThreeQuarters -> Classes.Touch.Offset.IsThreeQuarters
            | Is1 -> Classes.Touch.Offset.Is1
            | Is2 -> Classes.Touch.Offset.Is2
            | Is3 -> Classes.Touch.Offset.Is3
            | Is4 -> Classes.Touch.Offset.Is4
            | Is5 -> Classes.Touch.Offset.Is5
            | Is6 -> Classes.Touch.Offset.Is6
            | Is7 -> Classes.Touch.Offset.Is7
            | Is8 -> Classes.Touch.Offset.Is8
            | Is9 -> Classes.Touch.Offset.Is9
            | Is10 -> Classes.Touch.Offset.Is10
            | Is11 -> Classes.Touch.Offset.Is11
            | Is12 -> Classes.All.Width.Is12
            | IsNarrow -> Classes.Touch.Offset.IsNarrow
            | IsFull -> Classes.Touch.Offset.IsFull
            | IsOneFifth -> Classes.Touch.Offset.IsOneFifth
            | IsTwoFifths -> Classes.Touch.Offset.IsTwoFifths
            | IsThreeFifths -> Classes.Touch.Offset.IsThreeFifths
            | IsFourFifths -> Classes.Touch.Offset.IsFourFifths

    type internal Options =
        { Width : string option
          Offset : string option
          DesktopWidth : string option
          DesktopOffset : string option
          TabletpWidth : string option
          TabletpOffset : string option
          MobileWidth : string option
          MobileOffset : string option
          WideScreenWidth : string option
          WideScreenOffset : string option
          FullHDWidth : string option
          FullHDOffset : string option
          TouchWidth : string option
          TouchOffset : string option
          CustomClass : string option
          Props : IHTMLProp list
          Modifiers : string option list }
        static member Empty =
            { Width = None
              Offset = None
              DesktopWidth = None
              DesktopOffset = None
              TabletpWidth = None
              TabletpOffset = None
              MobileWidth = None
              MobileOffset = None
              WideScreenWidth = None
              WideScreenOffset = None
              FullHDWidth = None
              FullHDOffset = None
              TouchWidth = None
              TouchOffset = None
              CustomClass = None
              Props = []
              Modifiers = [] }

    /// Generate <div class="column"></div>
    let column (options : Option list) children =
        let parseOptions (result: Options) =
            function
            | Width (screen, width) when screen = Screen.All ->
                { result with Width = ofWidth (screen, width) |> Some }
            | Offset (screen, offset) when screen = Screen.All ->
                { result with Offset = ofOffset (screen, offset) |> Some }
            | Width (screen, width) when screen = Screen.Desktop ->
                { result with DesktopWidth = ofWidth (screen, width) |> Some }
            | Offset (screen, offset) when screen = Screen.Desktop ->
                { result with DesktopOffset = ofOffset (screen, offset) |> Some }
            | Width (screen, width) when screen = Screen.Tablet ->
                { result with TabletpWidth = ofWidth (screen, width) |> Some }
            | Offset (screen, offset) when screen = Screen.Tablet ->
                { result with TabletpOffset = ofOffset (screen, offset) |> Some }
            | Width (screen, width) when screen = Screen.Mobile ->
                { result with MobileWidth = ofWidth (screen, width) |> Some }
            | Offset (screen, offset) when screen = Screen.Mobile ->
                { result with MobileOffset = ofOffset (screen, offset) |> Some }
            | Width (screen, width) when screen = Screen.WideScreen ->
                { result with WideScreenWidth = ofWidth (screen, width) |> Some }
            | Offset (screen, offset) when screen = Screen.WideScreen ->
                { result with WideScreenOffset = ofOffset (screen, offset) |> Some }
            | Width (screen, width) when screen = Screen.FullHD ->
                { result with FullHDWidth = ofWidth (screen, width) |> Some }
            | Offset (screen, offset) when screen = Screen.FullHD ->
                { result with FullHDOffset = ofOffset (screen, offset) |> Some }
            | Width (screen, width) when screen = Screen.Touch ->
                { result with TouchWidth = ofWidth (screen, width) |> Some }
            | Offset (screen, offset) when screen = Screen.Touch ->
                { result with TouchOffset = ofOffset (screen, offset) |> Some }
            | CustomClass customClass -> { result with CustomClass = customClass |> Some }
            | Props props -> { result with Props = props }
            | Modifiers modifiers -> { result with Modifiers = modifiers |> Modifier.parseModifiers }
            | x ->
                Fable.Import.JS.console.warn("Error when parsing column option " + string x)
                result

        let opts = options |> List.fold parseOptions Options.Empty
        let classes = Helpers.classes
                        Classes.Container
                        ( opts.Width
                          ::opts.Offset
                          ::opts.DesktopWidth
                          ::opts.DesktopOffset
                          ::opts.MobileWidth
                          ::opts.MobileOffset
                          ::opts.TabletpWidth
                          ::opts.TabletpOffset
                          ::opts.WideScreenWidth
                          ::opts.WideScreenOffset
                          ::opts.FullHDWidth
                          ::opts.FullHDOffset
                          ::opts.TouchWidth
                          ::opts.TouchOffset
                          ::opts.CustomClass
                          ::opts.Modifiers )
                        [ ]
        div (classes::opts.Props) children
