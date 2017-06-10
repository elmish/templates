module Home.State

open Elmish
open Types

let init () : Model =
    ""

let update msg model : Model =
    match msg with
    | ChangeStr str ->
      str