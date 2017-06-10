module CounterList.View

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types


let root model dispatch =
    let counterDispatch i msg = dispatch (Modify (i, msg))

    div
        [ ClassName "columns" ]
        [ div [ ClassName "column" ] [ 
            Counter.View.simpleButton "Add" Insert dispatch
            Counter.View.simpleButton "Remove" Remove dispatch            
          ]
          
          div
            [ ClassName "column is-narrow"
              Style
                [ CSSProp.Width "170px" ] ]
            (model |> List.mapi (fun i c -> Counter.View.root c (counterDispatch i)))

          div [ ClassName "column" ] [ ] ]
