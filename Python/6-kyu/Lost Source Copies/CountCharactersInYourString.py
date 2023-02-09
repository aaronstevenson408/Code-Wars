# The main idea is to count all the occurring characters in a string.
# If you have a string like aba, then the result should be {'a': 2, 'b': 1}. 

def count(string):
    resultDict = {}
    stringList  = list(string)
    for each in stringList:
        if each in resultDict:
            continue
        numberSeq = stringList.count(each)
        resultDict[each] = numberSeq
        
    # The function code should be here
    return resultDict
