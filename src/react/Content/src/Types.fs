module App.Types

type Page =
| Home of Home.Types.Model
| Counter of Counter.Types.Model
| CounterList of CounterList.Types.Model
| About

let toHash page =
    match page with
    | About -> "#about"
    | Counter _ -> "#counter"
    | CounterList _ -> "#counterlist"
    | Home _ -> "#home"


type Msg =
| CounterMsg of Counter.Types.Msg
| CounterListMsg of CounterList.Types.Msg
| HomeMsg of Home.Types.Msg

type Model = Page