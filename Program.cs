using WWE;

public class Program
{
    public static void Main(string[] args)
    {
        var wrestlers = new List<Wrestler>
        {
            new Wrestler("John Cena", "The Champ", 44),
            new Wrestler("The Rock", "The People's Champ", 49),
            new Wrestler("Stone Cold Steve Austin", "The Texas Rattlesnake", 57)
        };

        var wrestlerRepository = new WrestlerRepository(wrestlers);
        var wrestlerService = new WrestlerService(wrestlerRepository);
        var wrestlerController = new WrestlerController(wrestlerService);

        wrestlerController.DisplayWrestlers();
    }
}