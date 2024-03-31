namespace easilyswadecsharp.Models
{
  public class Character
  {
    public int Id { get; set }
    public string CreatorId { get; set }
    public string Name { get; set }
    public string Race { get; set }
    public int Age { get; set }
    public string Height { get; set }
    public int Weight { get; set }
    public int Bennies { get; set }
    public int Pace { get; set }
    public int Parry { get; set }
    public int Toughness { get; set }
    public int Agility { get; set }
    public int Smarts { get; set }
    public int Spirit { get; set }
    public int Strength { get; set }
    public int Fatigue { get; set }
    public int Wounds { get; set }
    public string Picture { get; set }
    public string Secret { get; set }
    public string Rank { get; set }
    public int PowerPoints { get; set }
    public object[] Hindrances { get; set}
    public object[] Edges { get; set}
    public string[] Gear { get; set}
    public object[] Weapons { get; set}
    public object[] Powers { get; set}
    public object[] Skills { get; set}
    public string SheetStyle { get; set}
    public bool Deactivated { get; set}
    public Profile Creator { get; set}
  }
}