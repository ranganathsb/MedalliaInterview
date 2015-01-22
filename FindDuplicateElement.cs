Just add them all up, and subtract the total you would expect if only 1001 numbers were used from that.

Eg:

Input: 1,2,3,2,4 => 12
Expected: 1,2,3,4 => 10

Input - Expected => 2


This can be done in O(n) time and O(1) space.

(The algorithm only works because the numbers are consecutive integers in a known range):

In a single pass through the vector, compute the sum of all the numbers, and the sum of the squares of all the numbers.

Subtract the sum of all the numbers from N(N-1)/2. Call this A.

Subtract the sum of the squares from N(N-1)(2N-1)/6. Divide this by A. Call the result B.

The number which was removed is (B + A)/2 and the number it was replaced with is (B - A)/2.

Example:

The vector is [0, 1, 1, 2, 3, 5]:

N = 6

Sum of the vector is 0 + 1 + 1 + 2 + 3 + 5 = 12. N(N-1)/2 is 15. A = 3.

Sum of the squares is 0 + 1 + 1 + 4 + 9 + 25 = 40. N(N-1)(2N-1)/6 is 55. B = (55 - 40)/A = 5.

The number which was removed is (5 + 3) / 2 = 4.

The number it was replaced by is (5 - 3) / 2 = 1.

Why it works:

The sum of the original vector [0, ..., N-1] is N(N-1)/2. Suppose the value a was removed and replaced by b. Now the sum of the modified vector will be N(N-1)/2 + b - a. If we subtract the sum of the modified vector from N(N-1)/2 we get a - b. So A = a - b.

Similarly, the sum of the squares of the original vector is N(N-1)(2N-1)/6. The sum of the squares of the modified vector is N(N-1)(2N-1)/6 + b2 - a2. Subtracting the sum of the squares of the modified vector from the original sum gives a2 - b2, which is the same as (a+b)(a-b). So if we divide it by a - b (i.e., A), we get B = a + b.

Now B + A = a + b + a - b = 2a and B - A = a + b - (a - b) = 2b.
