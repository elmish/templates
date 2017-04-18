module Global

type Page =
  | Home
  | Counter
  | About

let toHash =
  function
  | About -> "#about"
  | Counter -> "#counter"
  | Home -> "#home"
