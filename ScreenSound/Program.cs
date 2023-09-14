/*
Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 274;
musica1.Disponivel = false;
Console.WriteLine(musica1.DescricaoResumida);


musica1.ExibirFichaTecnica();*/

/*   
 *   
 *   Exercicio montar discografia
 *   
Banda banda = new ("Clube da Esquina");
//banda.Nome = "Clube da Esquina";

Album albumDoMiltonNascimento = new ("Clube da esquina");
//albumDoMiltonNascimento.Nome = "Clube da esquina";

Musica musica1 = new (banda, "Um girassol da cor de seu cabelo");
{
    musica1.Duracao = 253;
    musica1.Disponivel = true;
}

Musica musica2 = new (banda, "Trem de doido");
{
    musica2.Duracao = 239;
    musica2.Disponivel = true;
};

albumDoMiltonNascimento.AdicionarMusica(musica1);
albumDoMiltonNascimento.AdicionarMusica(musica2);
banda.AdicionarAlbum(albumDoMiltonNascimento);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoMiltonNascimento.ExibirMusicasDoAlbum();
banda.ExibirDiscografia();
*/
/*
 * Exercicio de conclusão, podcasts e episodios
 */

Episodio ep1 = new(4, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidado("Ana Pereira");
ep1.AdicionarConvidado("Mário Francis");

Episodio ep2 = new(2, "Aprendendo a aprender", 78);
ep2.AdicionarConvidado("Marcos Felício");

Episodio ep3 = new(3, "Consciênciologia", 87);
ep3.AdicionarConvidado("Flavio Almeida");
ep3.AdicionarConvidado("Gui Lima");
ep3.AdicionarConvidado("Fernanda Fernandes");

Episodio ep0 = new(1, "Filosofia de software", 93);
ep0.AdicionarConvidado("Fernando Roberto");
ep0.AdicionarConvidado("Gabriel Barbosa");

Podcast podcast = new("TI para Poucos", "Daniel Portugal");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.AdicionarEpisodio(ep0);

podcast.ExibirDetalhes();

