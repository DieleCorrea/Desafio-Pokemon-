using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/1/");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deu  merda: {ex.Message}");
    }

}
