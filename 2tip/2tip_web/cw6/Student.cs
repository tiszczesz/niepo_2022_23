using System.Text;
class Student : Person{
    public List<string> Topics { get; set; }
    public void ShowSecret(){
        Console.WriteLine("Moj sekret: "+ /*secret*/ +getSecret());
    }
    public Student(){
        Console.WriteLine("Konstruktor domyślny Student");
        Topics = new List<string>();
    }
    public Student(string firstName,string lastName,DateTime birth,List<string> topics=null)
        :base(firstName,lastName,birth)
    {
        Console.WriteLine($"Konstruktor Student z parametrami {firstName} {lastName} {birth}");
        Topics = topics == null ? new List<string>() : topics;

    }
    public void AddTopic(string topic){
        Topics.Add(topic);
    }
    public override string ToString()
    {
        return base.ToString()+Environment.NewLine+ShowTopics();
    }
    public string ShowTopics(){
        StringBuilder sb = new StringBuilder();
        if(Topics.Count==0){
            return "Brak przedmiotów dla studenta";
        }
        sb.Append("Lista przedmiotów: ");
        foreach(var t in Topics){
            sb.Append(t).Append(",");
        }
        return sb.ToString();
    }
}