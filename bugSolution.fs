(* Solution using tuples *)

let swapTuple (x, y) = 
    (y, x)

let x1 = 10
let y1 = 20
let (x1, y1) = swapTuple (x1, y1)
printf "%d %d" x1 y1 // Prints 20 10

(* Solution using ref cells *)

let x2 = ref 10
let y2 = ref 20

let swapRef x y =
    let temp = !x
    x := !y
    y := temp

swapRef x2 y2
printf "%d %d" !x2 !y2 // Prints 20 10