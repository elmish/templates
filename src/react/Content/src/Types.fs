module App.Types

open Global

type Msg =
  | CounterMsg of Counter.Types.Msg
  | CounterListMsg of CounterList.Types.Msg
  | HomeMsg of Home.Types.Msg

type Model = {
    CurrentPage: Page
    Counter: Counter.Types.Model
    CounterList: CounterList.Types.Model
    Home: Home.Types.Model
  }
