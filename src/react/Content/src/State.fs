module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import.Browser
open Types

let pageParser: Parser<Page->Page,Page> =
    oneOf [
      map About (s "about")
      map (Counter (Counter.State.init())) (s "counter")
      map (CounterList (CounterList.State.init())) (s "counterlist")
      map (Home (Home.State.init())) (s "home")
    ]

let urlUpdate (result: Option<Page>) model =
    match result with
    | None ->
        console.error("Error parsing url")
        model,Navigation.modifyUrl (toHash model)
    | Some page -> page, Cmd.none

let init result =
    urlUpdate result (Home (Home.State.init()))

let update msg (model:Model) =
    match msg with
    | CounterMsg msg ->
        match model with
        | Counter counter ->
            let counter = Counter.State.update msg counter 
            Counter counter, Cmd.none
        | _ -> model, Cmd.none
    | CounterListMsg msg ->
        match model with
        | CounterList counterList ->
            let counterList = CounterList.State.update msg counterList
            CounterList counterList, Cmd.none
        | _ -> model, Cmd.none
    | HomeMsg msg ->
        match model with
        | Home data ->
            let data = Home.State.update msg data 
            Home data, Cmd.none
        | _ -> model, Cmd.none
