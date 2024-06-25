namespace SOLID.Example.DIP.DataStorage.WithDIP
{
    /// <summary>
    /// When we follow the Dependency Inversion Principle in this design, it becomes easy to add or modify data storage mechanisms. 
    /// The NoteManager remains consistent and doesn’t require any changes, regardless of where the notes are stored.
    /// </summary>
    

    //Define the Interface
    public interface IDataStore
    {
        void Save(string data);
        string Retrieve(int id);
    }
    //Concrete implementations
    public class Database : IDataStore
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving note to database: {data}");
        }
        public string Retrieve(int id)
        {
            return $"Note {id} from database";
        }
    }
    public class CloudStorage : IDataStore
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving note to cloud: {data}");
        }
        public string Retrieve(int id)
        {
            return $"Note {id} from cloud";
        }
    }
    //The NoteManager now relies on an abstraction
    public class NoteManager
    {
        private readonly IDataStore _dataStore;
        public NoteManager(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }
        public void SaveNote(string note)
        {
            _dataStore.Save(note);
        }
        public string GetNote(int id)
        {
            return _dataStore.Retrieve(id);
        }
    }
}
