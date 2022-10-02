using Orleans;

public interface IHelloGrain : IGrainWithStringKey
{
    Task<string> SayHello(string greeting);
}

public class HelloGrain : Grain, IHelloGrain
{
    public Task<string> SayHello(string greeting) => Task.FromResult($"Hello, {greeting}!");
}