namespace easilyswadecsharp.Models
{
  public class Party
  {
    public int Id { get; set}
    public string CreatorId { get; set}
    public string Name { get; set}
    public string Description { get; set}
    public Profile Creator { get; set}
  }
}