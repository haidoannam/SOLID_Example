
namespace SOLID.Example.DIP.DataStorage
{
    /// <summary>
    ///  Initially, these notes are saved to a database. 
    ///  Still, given the rapid technology changes, you want to ensure your system remains flexible, potentially allowing for storage in a cloud platform or even flat files.
    /// </summary>
    /// 
    public class Database
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

    public class NoteManager
    {
        private Database _db = new Database();

        public void SaveNote(string note)
        {
            _db.Save(note);
        }

        public string GetNote(int id)
        {
            return _db.Retrieve(id);
        }
    }
}
