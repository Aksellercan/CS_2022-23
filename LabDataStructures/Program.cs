using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        StateStack stateStack = new StateStack();
        stateStack.Push(new State(1));
        stateStack.Push(new State(2));
        stateStack.Push(new State(3));
        Console.WriteLine(stateStack.Peek().code);
        stateStack.Pop();
        stateStack.Push(new State(4));
        stateStack.Push(new State(5));
        stateStack.Pop();
        stateStack.Push(new State(6));
        stateStack.PrintAllStack();

        Console.WriteLine();

         Stack<State> defaultStack = new Stack<State>();
         defaultStack.Push(new State(1));
         defaultStack.Push(new State(2));
         defaultStack.Push(new State(3));
         defaultStack.Pop();
         defaultStack.Push(new State(4));
         defaultStack.Push(new State(5));
         defaultStack.Pop();
         defaultStack.Push(new State(6));
         foreach(var state in defaultStack)
         {
         	Console.Write($"{state.code},");
         }
        Console.ReadLine();
    }
}

class State
{
    public int code { get; }
    public State(int code)
    {
        this.code = code;
    }
}

class StateStack
{
    // add code here
    List<State> theStack;

    public StateStack()
    {
        // add code here
        this.theStack = new List<State>();
    }

    public void Push(State newState)
    {
        // add code here
        this.theStack.Add(newState);

    }

    public State? Pop()
    {
        // add code here

        State lastState = Peek();
        if (lastState != null)
        {
            theStack.RemoveAt(theStack.Count - 1);
        }
        return lastState;
    }

    public State? Peek()
    {
        // add code here
        State lastState = theStack.Last();
        State lastState2 = theStack[theStack.Count - 1];

        return lastState2;
    }

    public void PrintAllStack()
    {
        // add code here
        foreach (State aState in theStack)
        {
            Console.WriteLine(aState.code);
        }
    }
}