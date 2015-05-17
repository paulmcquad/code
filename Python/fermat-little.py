from math import exp
import random
number = input("Give me a number: ")
num = int(number)
a = random.randint(1,num-1)
b = a**(num-1)
if (b % num) == 1:
	print("We have a prime!")
else:
	print("Sorry, not a prime!")
