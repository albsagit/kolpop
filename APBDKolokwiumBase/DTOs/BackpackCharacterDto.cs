namespace APBDKolokwiumBase.DTOs;

public class BackpackCharacterDto
{
    public string FirstName { get; set; } =  null!;
    public string LastName { get; set; } =  null!;
    public int CurrentWeight { get; set; } 
    public int MaxWeight { get; set; }
    public List<BackpackItemDto> Items { get; set; } = null!;
    public List<TitleDto> Titles { get; set; } = null!;
}

public class BackpackItemDto
{
    public string ItemName { get; set; } = null!;
    public int Weight { get; set; }
    public int Amount { get; set; }
}

public class TitleDto
{
    public string Title { get; set; } = null!;
    public DateTime AquiredAt  { get; set; }
}

