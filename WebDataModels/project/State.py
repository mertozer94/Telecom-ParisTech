class State:
    def __init__(self,element):
        self.data = element
        self.cardinality = None
        self.nextStates = []
        self.isFirstInGroup = False
        self.islastInGroup = False

    def getNextState(self):
            return self.nextStates;

    def setNextState(self,state):
            self.nextStates.append(state);
            return

    def nextStateContains(self, data):
        for state in self.nextStates:
            if data in state.data:
                return True
        return False

    def goToNextState(self, str):
        for state in self.nextStates:
            if str in state.data:
                return state
