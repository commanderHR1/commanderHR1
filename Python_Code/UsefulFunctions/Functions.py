import secrets
import random
import datetime
import os
import sys
import string
import time

#Shuffles a string
def shuffleString(s):
    l = list(s)
    random.shuffle(l)
    return "".join(l)

#Gets date and time
def getDateTime():
    return datetime.datetime.now()

#Gets the average of a list 
def getAverage():
    size = int(input("Ammount of numbers being averaged:\n"))
    l = [None] * size
    total = 0
    average = None
    for i in range(size):
        l[i] = float(input("Input item " + str(i + 1) + ":\n"))
        total += l[i]
    average = total/size
    return average

print(shuffleString("test"))
print(getDateTime())
print(getAverage())
input("Press ENTER to exit...")
exit()

  