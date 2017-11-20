class Node:
    def __init__(self,element):
        self.data = element
        self.childs = []
        self.parent = None

    def getChilds(self):
        return self.childs;

    def getParent(self):
        return self.parent;
