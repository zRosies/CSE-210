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
        // Display the scriptures
        _Render._ReferenceModified.Displaylist();
    }
}


// userchoice = Console.ReadLine();
//             userchoice.ToLower();

//         Console.Write("Press enter to continue or type quit to finish");

