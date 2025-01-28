let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

let testSwap () = 
    printf "Before swap: x = %d, y = %d\n", x, y
    swap x y
    printf "After swap: x = %d, y = %d\n", x, y

testSwap ()