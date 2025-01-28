# F# Mutable Variable Swap Bug

This repository demonstrates a common error in F# involving mutable variables and unexpected behavior when attempting to swap their values.  The `swap` function does not correctly swap the values of `x` and `y` because F# passes mutable variables by reference. This means the swap function modifies the original variables directly instead of creating copies.

## Bug

The `bug.fs` file contains the code exhibiting this issue.  The `swap` function intends to exchange the values of two mutable integer variables. However, due to the pass-by-reference nature of mutable variables, this attempt fails.

## Solution

The `bugSolution.fs` file provides a corrected version of the code. This solution utilizes tuples to create immutable copies of the variables before performing the swap.  This prevents unexpected side effects caused by modifying the original mutable variables.
