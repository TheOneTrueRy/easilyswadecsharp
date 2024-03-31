namespace easilyswadecsharp.Models
{
  public class Story
  {
    public int Id { get; set}
    public string CreatorId { get; set}
    public string Title { get; set}
    public string Description { get; set}
    public string[] Urls { get; set} // I don't know if this actually works or will be right
    public string CharacterId { get; set}
    public string PartyId { get; set}
    public Profile Creator { get; set}
    public Character Character { get; set}
    public Party Party { get; set}
  }
}