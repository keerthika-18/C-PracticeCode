// See https://aka.ms/new-console-template for more information
using C_FeaturesandCollections;
public class Program
{
    public static void Main(string[] args)
    {
        Type2 type = new Type2();
        type.Type1();
        Nullable2 n = new Nullable2();
        n.Run();
        StringFeature str = new StringFeature();
        str.StringFeatures();
        SystemObject s = new SystemObject();
        s.System();
        Exception_except ex = new Exception_except();
        ex.ExceptionHandling();


    }
}