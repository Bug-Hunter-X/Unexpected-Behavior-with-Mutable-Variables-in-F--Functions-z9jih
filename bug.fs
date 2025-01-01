let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //this will print 20 20

//The above code will not swap the values of x and y outside the swap function because F# uses immutable variables by default. 
//To achieve the desired outcome of swapping values outside the function, one must make use of tuples or reference cells.

let swapTuple x y = 
    (y, x)

let x1 = 10
let y1 = 20
let (x1, y1) = swapTuple x1 y1
printf "%d %d" x1 y1 // this will print 20 10