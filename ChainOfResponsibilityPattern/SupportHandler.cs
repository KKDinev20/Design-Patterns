namespace ChainOfResponsibilityPattern;

public abstract  class SupportHandler
{
    protected SupportHandler next;
    
    public void SetNextHandler(SupportHandler nextHandler)
    {
        next = nextHandler;
    }

    public abstract void HandleRequest(string request);
}