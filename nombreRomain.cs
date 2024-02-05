Console.WriteLine("Entrez un chiffre romain : ");
string chiffreRomain = Console.ReadLine().ToUpper();
int chiffreArabe = 0;

Dictionary<char, int> symbolesRomains = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };



for (int i = 0; i < chiffreRomain.Length; i++)
{

    if (i + 1 < chiffreRomain.Length && symbolesRomains[chiffreRomain[i]] < symbolesRomains[chiffreRomain[i + 1]])
    {
        chiffreArabe -= symbolesRomains[chiffreRomain[i]];
    }
    else
    {
        chiffreArabe += symbolesRomains[chiffreRomain[i]];
    }
}

Console.WriteLine("Le chiffre arabe correspondant est " + chiffreArabe);

foreach (KeyValuePair<char, int> n in symbolesRomains)
{
    Console.WriteLine(n);
}

Console.ReadLine();
