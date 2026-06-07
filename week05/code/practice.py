



def sumPractice(n, counter):
    counter += 1
    if counter == n:
        return counter
    elif counter > n:
        return counter
    else:
        sumPractice(n, counter)
        
sumPractice(3, 0)
    
        