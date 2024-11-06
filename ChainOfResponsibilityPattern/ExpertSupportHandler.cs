namespace ChainOfResponsibilityPattern;

public class ExpertSupportHandler : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if(request == "Expert")
            Console.WriteLine("Expert Support: Handling expert request.");
        else
            next?.HandleRequest(request);
    }
}