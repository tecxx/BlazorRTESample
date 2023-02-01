namespace RTETest.Model;

public class DataService
{
    public async Task<List<Entity>> GetData()
    {
        var dataSource = new List<Entity>();

        // load data from db
        for (int i = 1; i < 100; i++)
        {
            var e = new Entity();
            e.id = i;
            e.name = $"Entity {i}";
            e.guid = Guid.NewGuid();
            e.rtecontent = $"some random {Random.Shared.NextInt64()} content ";
            e.rtecontent2 = $"some random {Random.Shared.NextInt64()} content ";

            var task = new MetaTask
            {
                id = Guid.NewGuid(),
                name = "some task",
                description = "task description"
            };
            e.MetaTasks.Add(task);

            task = new MetaTask
            {
                id = Guid.NewGuid(),
                name = "some task 2",
                description = "task 2 description"
            };
            e.MetaTasks.Add(task);

            task = new MetaTask
            {
                id = Guid.NewGuid(),
                name = "some task 3",
                description = "task 3 description"
            };
            e.MetaTasks.Add(task);

            await Task.Delay(1);
            dataSource.Add(e);
        }

        return dataSource;
    }
}
