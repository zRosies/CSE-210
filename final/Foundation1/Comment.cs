class Comment{
    private string _comment="";
    private string _personName="";

    public string getSetComment{
        get{return _comment;}
        set{_comment=value;}
    }
    public string getSetName{
        get{return _personName;}
        set{_personName=value;}

    }

    public string CommentAndName(){
        return $"Name: {_personName} - Comment: {_comment}";
    }



}