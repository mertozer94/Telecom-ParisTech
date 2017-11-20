from Node import Node

class Tree:
    def __init__(self,element):
        self.root = Node(element)
        self.elements = []

    def add(self, other):
        new_node = Node(other)
        self.elements.append(new_node)

    def getRoot(self):
        return self.root

    def getChildrensOf(self, instance):

        result = []
        flag = 0
        for element in self.elements:
            if (instance == element.data):
                flag = 1
                result.append(element.childs)

        if (flag == 1):
            return result
        else:
            return "not in tree"
