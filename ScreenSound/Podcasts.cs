class Podcasts
{
    private List<Episodio> episodios = new();
    public Podcasts(String nome, String host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public string Host { get; }

    public int TotalEpiosodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio) => episodios.Add(episodio);

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast >|{Nome}|< apresentado por [{Host}]\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}.");
    }


}