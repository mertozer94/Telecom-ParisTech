from Automata import Automata
from State import State
from Tree import Tree
from Node import Node

import sys

#regular expression is only used to compare with my model
#import re

#these modules are used for reporting
#import timeit, functools
#import os
#import matplotlib.pyplot as plt

if __name__ == "__main__":

    # this function is used to check validity of xml
    def checkXml(first,second,directory):
        first = []
        second = []
        not_well_formed = "Not well-formed"

        #try to read xml file
        try:
            f = open(directory)
        except FileNotFoundError:
            print("Input File cannot be found")
            return  not_well_formed

        #split by space
        for line in f:
            elements = line.split(" ")
            first.append(elements[0].rstrip())
            second.append(elements[1].rstrip())

        #create our stack
        # we are using DOM, so we putting every element in to the memory
        stack = []
        try:
            # create our tree datatype
            tree = Tree(second[0])
            # add root element to our tree in case we want to search smt
            root_element = Node(second[0])
            stack.append(root_element)
        except IndexError:
            return not_well_formed

        # algorithm for creating the tree and evaluating the xml file
        for element1,element2 in zip(first,second):
            # if new element
            if(element1 == "0"):
                # create our node type ( our tree consist of nodes)
                new_node = Node(element2)
                try:
                    new_node.parent = (stack [-1])
                except IndexError:
                    return not_well_formed

                stack.append(new_node)
                tree.elements.append(new_node)

            else:
                try:
                    if (element2 == stack[-1].data):
                        # get last zero element add to his child
                        stack.pop()
                        parent = stack[-1]
                        child = Node(element2)
                        parent.childs.append(child)

                except IndexError:
                    return  not_well_formed

        # if root has only one element
        if len(stack) == 1:
            return tree
        else:
            return not_well_formed

    # this algorithm is used to get rid of the paranthesis in dtd
    def infixToPostfix(str):

        postFixList = []
        opStack = []
        grouping = ['(',')']
        cardinality = ['+','*','?']
        newStr = ""
        for char in str:
            if not char in grouping and not char in cardinality:
                newStr = newStr + '(' + char + ')'
            else:
                newStr = newStr + char
        for token in newStr:

           if token == '(':
               opStack.append(token)
           elif token == ')':
                opStack.pop()
                #todo add try catch to catch misblocks
                if not '(' in opStack:
                    postFixList.append('1')
           else:
                postFixList.append(token)

        return postFixList

    # this algorithm creates an automaton so that we can match our elements in given dtd
    def automata(pattern):

        cardinality = ['?','+','*']
        addedElements = []
        postFix = infixToPostfix(pattern)
        automaton = Automata()
        firstState = State("0")
        automaton.addStates(firstState)
        grouping = 0
        for char in postFix:
            if not char == "1":
                if (grouping == 1):#if last char was grouping
                    addedElements[0].isFirstInGroup = True
                    addedElements[-1].islastInGroup = True

                    if (char in cardinality):
                        if char == '+':
                            if len(addedElements) > 1:
                               automaton.getLastState().setNextState(addedElements[0])
                            else:
                                automaton.getLastState().cardinality = char
                                automaton.getLastState().setNextState(automaton.getLastState())
                                addedElements = []
                        else:
                            addedElements[0].cardinality = char

                            if char == '*':
                                automaton.getLastState().setNextState(addedElements[0])

                        addedElements = []
                    else:
                        #get last one
                        addedElements = []
                        newState = State(char)
                        automaton.getLastState().setNextState(newState)
                        automaton.addStates(newState)
                        addedElements.append(newState)
                else:
                    # elements not in grouping
                    if char in cardinality:
                        if char == '+':
                            addedElements.append(automaton.getLastState())
                            automaton.getLastState().setNextState(automaton.getLastState())
                        else:
                            if char == '?':
                                automaton.getLastState().cardinality = char
                                automaton.getLastState().isFirstInGroup = True
                                automaton.getLastState().islastInGroup = True
                            if char == '*':
                                automaton.getLastState().setNextState(automaton.getLastState())
                                automaton.getLastState().cardinality = char
                                automaton.getLastState().isFirstInGroup = True
                                automaton.getLastState().islastInGroup = True
                    else:
                        #get last one
                        newState = State(char)
                        automaton.getLastState().setNextState(newState)
                        automaton.addStates(newState)
                        addedElements.append(newState)
                grouping = 0
            else:
                grouping = 1
        beginning = []

        #get next state of beginning state
        for state in automaton.states[1:]:
            if state.cardinality == '*' or state.cardinality == '?':
                    automaton.states[0].setNextState(state)
                    statesFromNext = state.nextStates
                    for nextState in statesFromNext:
                        if automaton.states[0].nextStateContains(nextState.data) == False:
                            automaton.states[0].setNextState(nextState)
            else:
                if(state.isFirstInGroup == True):
                    if state.nextStateContains(state.data) == False:
                        automaton.states[0].setNextState(state)
                    break

        for state in automaton.states[1:]:
            statesAfter = automaton.getAfter(state.data)
            for otherState in statesAfter: # bind to first element that has no cardinality
                if otherState.cardinality:
                    if (otherState.cardinality == '*') or (otherState.cardinality == '?'):
                            statesFromNext = otherState.nextStates
                            for nextState in statesFromNext:
                                if state.nextStateContains(nextState.data) == False:
                                    state.setNextState(nextState)
                    else:
                        break
                else:
                    break

        return automaton;

    #checking if dtd is valid. Most of the code gets executed here.
    def checkDtd(first, second, xmlDirectory):
        well_formed = "well-formed"
        not_well_formed = "Not well-formed"
        not_valid = "not valid"
        valid = "valid"

        tree = checkXml(first,second,xmlDirectory)
        if not tree == not_well_formed:
            for dtd0,dtd1 in zip(first,second):
                # get children of dtd0
                childs = tree.getChildrensOf(dtd0)
                if not childs == "not in tree":
                    for child in childs:
                        string = ""
                        if not child is None:
                            for node in child:
                                string += node.data

                        if not (string == ""): # Elements that have children
                            #m = re.search(pattern='^'+dtd1+'$',string=string)
                            automaton = automata(dtd1)
                            result = automaton.match(string)

                            if (result == False):
                                return (well_formed+"\n"+not_valid)
                            #try:
                            #    m.group()
                            #except AttributeError:
                            #    print(well_formed+"\n"+not_valid)
                            #    return

                        # pass if element appers more than 1 times and it has one empty subset.
                        # this is not allowed as expressed in the document, but I am passing it anyways
                        # because it has been evaluated
                        elif string == "" and len(childs)>1:
                            continue
                        else:
                                # we have two e. problem
                                if '_' in dtd1:
                                    if (len(dtd1) > 1):
                                        return well_formed+"\n"+not_valid
                                    else:
                                        # elements of dtd0 should not exist.
                                        if not len(child) == 0:
                                            return (well_formed+"\n"+not_valid)

                                #if child of element not found and not empyty expression
                                else:
                                    return(well_formed+"\n"+not_valid)

            return well_formed+"\n"+valid

        else:
            return not_well_formed+"\n"+not_valid

    def getSize(filename): # get size of the file in mb. Used for reporting
        st = os.stat(filename)
        return st.st_size /1024 / 1024


    first = []
    second = []
    time = [] #used for reporting
    memory = [] #used for reporting
    size = [] #used for reporting
    dtdDirectory = sys.argv[2]
    #for i in range(20):
    #    xmlDirectory = "generatedFiles/generatedFile"+str(i)+".xml"
    xmlDirectory = sys.argv[1]
    try:
        f = open(dtdDirectory)
    except FileNotFoundError:
        print("Dtd File cannot be found")
    for line in f:
        try:
            elements = line.split(" ")
            first.append(elements[0].rstrip())
            second.append(elements[1].rstrip())
        except IndexError:
            print("not valid")
            result = "0"

    result = checkDtd(first,second,xmlDirectory)
    print(result)

    #code below is used to test
    """
    A = first
    B = second
    C = xmlDirectory
    print(i)
    time.append(timeit.Timer(functools.partial(checkDtd, A, B, C)).timeit(1))
    tot_m, used_m, free_m = map(int, os.popen('free -t -m').readlines()[-1].split()[1:])
    memory.append(used_m)
    size.append(getSize(xmlDirectory))
    """
    """
    time.sort()
    memory.sort()
    size.sort()

    plt.title('Memory consumption vs Execution time')
    plt.plot(time, memory,  marker='o', markersize=3, color="red")
    plt.xlabel('Execution time in seconds')
    plt.ylabel('Memory usage in Mb')
    plt.show()

    plt.title('File size vs Execution time')
    plt.plot(time, size, marker='o', markersize=3, color="blue")
    plt.xlabel('Execution time in seconds')
    plt.ylabel('Xml File size in Mb')
    plt.show()

    plt.title('Memory consumption vs File size')
    plt.plot(memory, size, marker='o', markersize=3, color="green")
    plt.xlabel('Memory usage in Mb')
    plt.ylabel('Xml File size in Mb')
    plt.show()
    """
