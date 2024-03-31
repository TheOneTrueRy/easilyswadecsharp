namespace easilyswadecsharp.Models
{
  public class Art
  {
    public int Id { get; set}
    public string CreatorId { get; set}
    public string Title { get; set}
    public string Description { get; set}
    public string Url { get; set}
    public int CharacterId { get; set}
    public int PartyId { get; set}
    public Profile Creator { get; set}
    public Character Character { get; set}
    public Party Party { get; set}
  }
}