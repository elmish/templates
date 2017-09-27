module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import
open Types

let pageParser: Parser<Page->Page,Page> =
    oneOf [
      map About (s "about")
      map Counter (s "counter")
      map CounterList (s "counterlist")
      map Home (s "home")
      map Home top
    ]


let urlUpdate (result: Option<Page>) model =
    match result with
    | None ->
        Browser.console.error("Error parsing url: " + Browser.window.location.href)
        model, Navigation.modifyUrl (toHash model.CurrentPage)

    | Some page ->
        { model with CurrentPage = page }, Cmd.none

let init result =
    urlUpdate result
        { CurrentPage = Home
          Counter = Counter.State.init()
          CounterList = CounterList.State.init()
          Home = Home.State.init() }


let update msg (model:Model) =
    match msg with
    | CounterMsg msg ->
        let counter = Counter.State.update msg model.Counter
        { model with Counter = counter }, Cmd.none
    | CounterListMsg msg ->
        let counterList = CounterList.State.update msg model.CounterList
        { model with CounterList = counterList }, Cmd.none
    | HomeMsg msg ->
        let home = Home.State.update msg model.Home
        { model with Home =  home }, Cmd.none
