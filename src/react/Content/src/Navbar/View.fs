module Navbar.View

open Fable.FontAwesome
open Fable.React
open Fable.React.Props

let navButton classy href icon txt =
    p
        [ ClassName "control" ]
        [ a
            [ ClassName (sprintf "button %s" classy)
              Href href ]
            [ span
                [ ClassName "icon" ]
                [ Fa.i [ icon ] [] ]
              span
                [ ]
                [ str txt ] ] ]

let navButtons =
    span
        [ ClassName "navbar-item" ]
        [ div
            [ ClassName "field is-grouped" ]
            [ navButton "twitter" "https://twitter.com/FableCompiler" Fa.Brand.Twitter "Twitter"
              navButton "github" "https://github.com/elmish/elmish" Fa.Brand.Github "Fork me"
              navButton "github" "https://gitter.im/fable-compiler/Fable" Fa.Brand.Gitter "Gitter" ] ]

let root =
    nav
        [ ClassName "navbar is-dark" ]
        [ div
            [ ClassName "container" ]
            [ div
                [ ClassName "navbar-brand" ]
                [ h1
                    [ ClassName "navbar-item title is-4" ]
                    [ str "Elmish" ] ]
              div
                [ ClassName "navbar-end" ]
                [ navButtons ] ] ]
