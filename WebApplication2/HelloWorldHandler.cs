namespace WebApplication2;

public static class HelloWorldHandler
{
    static public IResult SayHello()
    {

        return Results.Ok("hello");
    }
}