public class LinqQuieries {
    private List<Book> librosCollection = new List<Book>();
    public LinqQuieries() {
        using(StreamReader reader = new StreamReader("books.json")){
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonConvert.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
        }
    }

    public IEnumerable<Book> GetLibros() {
        return librosCollection;
    }
}