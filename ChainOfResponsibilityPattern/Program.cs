namespace ChainOfResponsibilityPattern;

class Program
{
    static void Main(string[] args)
    {
        SupportHandler basicHandler = new BasicSupportHandler();
        SupportHandler advancedHandler = new AdvancedSupportHandler();
        SupportHandler expertHandler = new ExpertSupportHandler();

        basicHandler.SetNextHandler(advancedHandler);
        advancedHandler.SetNextHandler(expertHandler);

        basicHandler.HandleRequest("Basic");
        basicHandler.HandleRequest("Advanced");
        basicHandler.HandleRequest("Expert");
        basicHandler.HandleRequest("Unknown");
    }
}