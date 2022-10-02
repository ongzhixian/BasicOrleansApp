namespace BasicOrleansApp.BasicInterfaces;

public interface IHello : Orleans.IGrainWithIntegerKey
{
    Task<string> SayHello(string greeting);
}
