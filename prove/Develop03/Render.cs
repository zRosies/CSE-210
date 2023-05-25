public class Render
{
    private Hide _Render;

    public Render(Hide hide)
    {
        _Render = hide;
    }
    
    public void DisplayScriptures(string userchoice){
        _Render.HidePartsOfScripture(userchoice);


    }

    public void RenderDefault(){
        _Render.setRefDefault();
    }
    
    public void RenderListOfOptions()
    {
        _Render._ReferenceModified.Displaylist();
    }
}
