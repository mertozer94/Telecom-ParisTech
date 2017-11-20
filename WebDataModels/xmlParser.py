from Tree import Tree
from Node import Node

#if __name__ == "__main__":

#todo give input file as input
def checkValidation(first,second):
    first = []
    second = []
    #directory = "input_file"
    directory = "generatedFiles/generatedFile0.xml"
    not_well_formed = "Not well-formed"

    try:
        f = open(directory)
    except FileNotFoundError:
        print("Input File cannot be found")
        return  not_well_formed

    for line in f:
        elements = line.split(" ")
        first.append(elements[0].rstrip())
        second.append(elements[1].rstrip())
    # lines = []
    # with open(xml_file) as f_in:
        #lines = (line.rstrip() for line in f_in)
        #lines = list(line for line in lines if line)

    stack = []
    #well_formed = "Well-formed"
    try:
        tree = Tree(second[0])
        root_element = Node(second[0])
        stack.append(root_element)
    except IndexError:
        return not_well_formed

    for element1,element2 in zip(first,second):
        # if new element
        if(element1 == "0"):
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
