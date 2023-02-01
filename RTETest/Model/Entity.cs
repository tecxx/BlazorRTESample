namespace RTETest.Model;

public class Entity
{
    public Guid guid { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string rtecontent { get; set; } = "";
    public string rtecontent2 { get; set; } = "";

    public List<MetaTask> MetaTasks { get; set; } = new List<MetaTask>();
}
