from State import State
class Automata:
    def __init__(self):
        self.states = []

    def addStates(self, state):
        self.states.append(state)

    def getLastState(self):
        return self.states[-1]

    def duplicateLastState(self):
        lastState = self.getLastState()
        newState = State(lastState.data)
        newState.cardinality = '+'
        newState.islastInGroup = True
        lastState.islastInGroup = False
        lastState.setNextState(newState)
        self.states.append(newState)

    def getAfter(self, stateName):
        location = max(loc for loc, val in enumerate(self.states) if val.data == stateName)
        return self.states[location+1:]

    def match(self,str):
        state = self.states[0]
        for char in str:
            if (state.nextStateContains(char) == True):
                state = state.goToNextState(char)
            else:
                #self.printAutomata()
                #print("state",state.data)
                return False

    def printAutomata(self):
        str = ''
        for state in self.states:
            str = str + state.data
        print("Automata states = ",str)
