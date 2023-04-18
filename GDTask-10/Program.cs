Console.WriteLine(cheto_delaet("Привет, сын хорошей женщины!"));

static string cheto_delaet(string input)
{
    string output = "";
    string[] words = input.Split(' ');
    foreach (var el in words)
    {
        string new_world = "";
        if (el.Contains(',') | el.Contains('.') | el.Contains('!') | el.Contains('?'))
        {
            new_world = el.Substring(1, el.Length - 2);
            new_world += el.Substring(0, 1);
            new_world += "ай";
            new_world += el.Substring(el.Length - 1);
        }
        else
        {
            new_world = el.Substring(1);
            new_world += el.Substring(0, 1);
            new_world += "ай";
        }

        output += new_world + " ";
    }

    return output;
}