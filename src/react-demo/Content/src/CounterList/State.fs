module CounterList.State

open Elmish
open Types

let init () : Model =
    [ Counter.State.init () ]

let update (msg:Msg) (model:Model) =
    match msg with
    | Insert ->
        Counter.State.init() :: model

    | Remove ->
        match model with
        | [] -> []
        | x :: rest -> rest

    | Modify (id, counterMsg) ->
        model
        |> List.mapi (fun i counterModel ->
            if i = id then
                Counter.State.update counterMsg counterModel
            else
                counterModel)
