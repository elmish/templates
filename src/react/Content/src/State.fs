module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import.Browser
open Global
open Types

let pageParser: Parser<Page->Page,Page> =
    oneOf [
      map About (s "about")
      map Counter (s "counter")
      map CounterList (s "counterlist")
      map Home (s "home")
    ]

let urlUpdate (result: Option<Page>) model =
    match result with
    | None ->
        console.error("Error parsing url")
        model,Navigation.modifyUrl (toHash model.CurrentPage)
    | Some page ->
        { model with CurrentPage = page }, []

let init result =
    let counter = Counter.State.init()
    let counterList = CounterList.State.init()
    let home = Home.State.init()
    urlUpdate result
      { CurrentPage = Home
        Counter = counter
        CounterList = counterList
        Home = home }

let update msg model =
    match msg with
    | CounterMsg msg ->
        let counter = Counter.State.update msg model.Counter 
        { model with Counter = counter }, Cmd.none
    | CounterListMsg msg ->
        let counterList = CounterList.State.update msg model.CounterList
        { model with CounterList = counterList }, Cmd.none
    | HomeMsg msg ->
        let home = Home.State.update msg model.Home
        { model with Home = home }, Cmd.none
