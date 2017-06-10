module App.Types

type Page =
    | Home
    | Counter
    | CounterList
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

type Model =
    { CurrentPage : Page
      Counter : Counter.Types.Model
      CounterList : CounterList.Types.Model
      Home: Home.Types.Model }
