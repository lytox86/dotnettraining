namespace WebApplication2;

public class HelloWorldHandler
{
    static public IResult SayHello()
    {

        return Results.Ok("hello");
    }
}