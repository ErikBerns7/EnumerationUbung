
State current = State.Locked;


while(true)
{
    Console.WriteLine($"What would you like to do? The box is currently {current}");
    string answer = Console.ReadLine();

    if(current == State.Locked && answer == "Unlock")
    {
        current = State.Closed;
    }

    else if (current == State.Closed && answer == "Lock")
    {
        current = State.Locked;
    }

    else if (current == State.Closed && answer == "Open")
    {
        current = State.Open;
    }

    else if (current == State.Open && answer == "Close")
    {
        current = State.Closed;
    }

    else
    {
        Console.WriteLine("This is not a valid command");
    }
}






enum State
{
    Closed,
    Open,
    Locked
}