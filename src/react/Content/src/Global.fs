module Global

type Page =
  | Home
  | Counter
  | About

let toHash page =
  match page with
  | About -> "#about"
  | Counter -> "#counter"
  | Home -> "#home"

module Helpers =

  open Fable.Helpers.React.Props

  let internal classList classes =
    classes
    |> List.fold (fun complete -> function | (name,true) -> complete + " " + name | _ -> complete) ""
    |> ClassName
