module CounterList.View

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types

let centerButton txt action dispatch =
    div
      [ ClassName "column is-half is-offset-one-quarter" ]
      [ a
          [ ClassName "button"
            OnClick (fun _ -> action |> dispatch) ]
          [ str txt ] ]

let root model dispatch =
    let counterDispatch i msg = dispatch (Modify (i, msg))

    div
        [ ]
        [ div
            [ ClassName "columns" ]
            [ div
                [ ClassName "column is-half is-offset-one-quarter" ]
                [ div
                    [ ClassName "columns" ]
                    [ div
                        [ ClassName "column" ]
                        [ centerButton "Add" Insert dispatch ]
                      div
                        [ ClassName "column" ]
                        [ centerButton "Remove" Remove dispatch ] ] ] ]

          div
            [ ClassName "columns" ]
            [ div
                [ ClassName "column is-half is-offset-one-quarter" ]
                [ div
                    [ ClassName "column is-narrow"
                      Style
                        [ CSSProp.Width "170px" ] ]
                    (model |> List.mapi (fun i c -> Counter.View.root c (counterDispatch i))) ] ] ]
