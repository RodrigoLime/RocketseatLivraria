namespace RocketseatLivraria.Communication.Requests;

public class RequestRegisterBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public Genre Genero { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
}
