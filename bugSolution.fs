let swap (x, y) = 
    (y, x)

let testSwap () = 
    let x = 10
    let y = 20
    printf "Before swap: x = %d, y = %d\n", x, y
    let (x, y) = swap (x, y)
    printf "After swap: x = %d, y = %d\n", x, y

testSwap ()