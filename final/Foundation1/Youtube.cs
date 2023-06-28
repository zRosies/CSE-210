class Youtube{
    private List<string> comments= new List<string>();
    private string _author ="";
    private string _title= "";

    private string _minutes ="";

    public Youtube (string author, string minutes, string title ){
        _author= author;
        _title= title;
        _minutes= minutes;
    }
    public Youtube(){

    }

    public string DisplayVideo(){
        return $"{_title} by {_author}: {_minutes} seconds.";
        
    }

    public string NumOfComments(){
        return $"{_title} by {_author}: {_minutes} seconds - number of comments: {comments.Count}.";
    }

    public void DisplayComments(){
        
        foreach(string line in comments){

            Console.WriteLine($"{line}");
        }
    }

    public void addComment(string comment){
        comments.Add(comment);
    } 




}