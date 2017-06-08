module Global

type Page =
| Home
| Counter
| CounterList
| About

let toHash page =
    match page with
    | About -> "#about"
    | Counter -> "#counter"
    | CounterList -> "#counterlist"
    | Home -> "#home"
