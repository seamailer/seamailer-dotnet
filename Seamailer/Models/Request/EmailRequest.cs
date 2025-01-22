namespace Seamailer.Models.Request;

public class EmailRequest
{
    public From from { get; set; }
    public List<To> to { get; set; }
    public string subject { get; set; }
    public string htmlPart { get; set; }
}

public class From
{
    public string email { get; set; }
}
public class To
{
    public string email { get; set; }
    public string name { get; set; }
}
