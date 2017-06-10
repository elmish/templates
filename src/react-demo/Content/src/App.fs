module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open Types
open App.State

importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props

let menuItem label page currentPage=
    li
      [ ]
      [ a
          [ classList [ "is-active", page = currentPage ]
            Href (toHash page) ]
          [ str label ] ]

let menu currentPage =
    aside
      [ ClassName "menu" ]
      [ p
          [ ClassName "menu-label" ]
          [ str "General" ]
        ul
          [ ClassName "menu-list" ]
          [ menuItem "Home" Page.Home currentPage
            menuItem "Counter sample" Page.Counter currentPage
            menuItem "Counter list sample" Page.CounterList currentPage
            menuItem "About" Page.About currentPage ] ]

let root (model: Model) dispatch =

    let pageHtml =
        function
        | Page.About -> Info.View.root
        | Counter -> Counter.View.root model.Counter (CounterMsg >> dispatch)
        | CounterList -> CounterList.View.root model.CounterList (CounterListMsg >> dispatch)
        | Home -> Home.View.root model.Home (HomeMsg >> dispatch)

    div
        []
        [ div
            [ ClassName "navbar-bg" ]
            [ div
                [ ClassName "container" ]
                [ Navbar.View.root ] ]
          div
            [ ClassName "section" ]
            [ div
                [ ClassName "container" ]
                [ div
                    [ ClassName "columns" ]
                    [ div
                        [ ClassName "column is-3" ]
                        [ menu model.CurrentPage ]
                      div
                        [ ClassName "column" ]
                        [ pageHtml model.CurrentPage ] ] ] ] ]

open Elmish.React
open Elmish.Debug

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
|> Program.withReact "elmish-app"
//-:cnd
#if DEBUG
|> Program.withDebugger
#endif
//+:cnd
|> Program.run
