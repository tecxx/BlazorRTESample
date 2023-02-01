namespace RTETest.Model;

public class TreeNode
{
    string _name = "node";
    public string name 
    { 
        get
        {
            if (this.Entity is Entity e)
                return e.name;
            return _name;
        }
        set
        {
            _name = value;
        } 
    }
    public Entity? Entity;

    public static TreeNode FromDB(object o)
    {
        var node = new TreeNode();

        if (o is Entity e)
        {
            node.name = e.name;
            node.Entity = e;
            return node;
        }
        throw new NotImplementedException();
    }
}

