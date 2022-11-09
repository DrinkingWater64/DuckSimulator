namespace DuckSimulator
{
    interface IDuckIterator
    {
        Quackable First();
        Quackable Next();
        bool GetIsCompleted();
    }
}