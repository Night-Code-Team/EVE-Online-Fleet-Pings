using Newtonsoft.Json;

namespace EVE_Online_Fleet_Pings;

public class JsonProperties
{
    [JsonProperty("content")]
    public string Content { get; set; } = "@everyone";
    [JsonProperty("embeds")]
    public List<Embed> Embeds { get; set; } = new();
}
public class Embed
{
    [JsonProperty("title")]
    public string Title { get; set; } = "New Fleet";
    [JsonProperty("description")]
    public string Description { get; set; } = "New Description";
    [JsonProperty("color")]
    public int Color { get; set; } = 1;
    [JsonProperty("author")]
    public Author Author { get; set; } = new();
    [JsonProperty("footer")]
    public Footer Footer { get; set; } = new();
    [JsonProperty("timestamp")]
    public string Timestamp { get; set; } = "1970-01-01T00:00:00.0000Z";
    [JsonProperty("thumbnail")]
    public Thumbnail Thumbnail { get; set; } = new();
}
public class Author
{
    [JsonProperty("name")]
    public string Name { get; set; } = "New Name";
    [JsonProperty("icon_url")]
    public string IconURL { get; set; } = "https://images.evetech.net/characters/0/portrait?size=128";
}
public class Footer
{
    [JsonProperty("text")]
    public string Text { get; set; } = "New Text";
    [JsonProperty("icon_url")]
    public string IconURL { get; set; } = "https://images.evetech.net/characters/0/portrait?size=128";
}
public class Thumbnail
{
    [JsonProperty("url")]
    public string URL { get; set; } = "https://images.evetech.net/characters/0/portrait?size=128";
}
public class FleetInfo
{
    public string Description { get; set; } = "New Description";
    public string FC { get; set; } = "New FC";
    public string FleetName { get; set; } = "New Fleet";
    public string FormupLocation { get; set; } = "New Location";
    public DateTime FormupTime { get; set; }
    public string Doctrine { get; set; } = "New Doctrine";
}