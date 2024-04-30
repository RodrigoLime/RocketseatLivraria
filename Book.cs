namespace RocketseatLivraria;

public enum Genre
{
    Fiction,
    Mystery,
    Romance,
    History,
    Biography,
    Poetry,
}
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public Genre Genero { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }

}
