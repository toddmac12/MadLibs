using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend!"; }

    [Route("/")]
    public ActionResult Story() 
    { 
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.Person1 = "Lina";
      myStoryVariable.Person2 = "Jasmine";
      myStoryVariable.animal = "Tiger";
      myStoryVariable.exclamation = "whoa";
      myStoryVariable.verb = "ran";
      myStoryVariable.noun = "hug";
      return View(myStoryVariable); 
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string Person1, string Person2, string animal, string exclamation, string verb)
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.Person1 = Person1;
      myStoryVariable.Person2 = Person2;
      myStoryVariable.animal = animal;
      myStoryVariable.exclamation = exclamation;
      myStoryVariable.verb = verb;

      return View(myStoryVariable);
    }

  }
}