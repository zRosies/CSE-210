public class Hide{
    public static Scriptures Scripture = new Scriptures();

 
    private string reference = Scripture.GetAndSetReference;
    private string text = Scripture.GetAndSetScripture;

    //Chosing a random part of the Scripture to be hidden 
    public void HidePartsOfScripture(string text){
        string[] words= text.Split(' ');
        var random = new Random();
        int randomIndex= random.Next(words.Length);
        for(int i=0; i < words.Length; i++){
            if(i==randomIndex){
                words[i]= new string('_', words[i].Length);
            }
        }
        string modifiedText = string.Join(" ", words);

    }
    public string 

}