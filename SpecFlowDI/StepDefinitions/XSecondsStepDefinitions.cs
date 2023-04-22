using SpecFlowDI.Context;

namespace SpecFlowDI.StepDefinitions;

[Binding]
public class XSecondsStepDefinitions
{
    private readonly SearchContext _searchContext;
    private readonly WebDriverContext _webDriverContext;

    public XSecondsStepDefinitions(SearchContext searchContext, WebDriverContext webDriverContext)
    {
        _searchContext = searchContext;
        _webDriverContext = webDriverContext;
    }

    [Given(@"I start the (.*) second demo")]
    public void GivenIStartTheDemo(int p0) 
    {
        _searchContext.searchTerm = p0 + " Seconds";
        _webDriverContext.chromeDriver = "ChromeDriver " + p0 + "seconds";
    }

    [When(@"I wait for (.*) seconds")]
    public void WhenIWaitForSeconds(int p0)
    {
        Thread.Sleep(p0 * 1000);
    }

    [Then(@"finish and demostrate context independence")]
    public void ThenFinishAndDemostrateContextIndependence_SharedStep()
    {
        Console.WriteLine(_searchContext.searchTerm);
        Console.WriteLine(_webDriverContext.chromeDriver);
    }
}