using System;

class Program
{
    static void Main(string[] args)
    {
        string user="";
        string[] menu={"\n1. Comment Video", "2. Display Video and Comments"};
        Youtube video1= new Youtube("Charles Bukowisky","60","My Life");
        Youtube video2= new Youtube("Thomas Jefferson", "30", "Independence Day");
        Youtube video3= new Youtube("Joseph Smith", "40","Restoration");
        Comment comments= new Comment();
        Console.WriteLine("\nWelcome to Youtube: ");
        do{
            foreach(string line in menu){
                    Console.WriteLine(line);
                }

            Console.WriteLine("Select an option:");
            user=Console.ReadLine();
            if(user == "1"){
                Console.WriteLine($"\n1. {video1.DisplayVideo()}");
                Console.WriteLine($"2. {video2.DisplayVideo()}");
                Console.WriteLine($"3. {video3.DisplayVideo()}");
               
                Console.WriteLine("\nWhich video do you want to comment?");
                string choice= Console.ReadLine();
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Write your comment");
                string comment= Console.ReadLine();

                if (choice=="1"){
                    comments.getSetComment=comment;
                    comments.getSetName=name;
                    video1.addComment(comments.CommentAndName());
                 
                }
                else if(choice=="2"){
                    comments.getSetComment=comment;
                    comments.getSetName=name;
                    video2.addComment(comments.CommentAndName());
                   
                }
                else if(choice=="3"){
                    comments.getSetComment=comment;
                    comments.getSetName=name;
                    video3.addComment(comments.CommentAndName());

                }
                else{
                    Console.WriteLine("\nThis video does not exist");
                }

            }
            else if(user == "2"){
                Console.WriteLine($"\n1. {video1.DisplayVideo()}");
                Console.WriteLine($"2. {video2.DisplayVideo()}");
                Console.WriteLine($"3. {video3.DisplayVideo()}");
                Console.WriteLine("Which video do want to know?");
                string choice = Console.ReadLine();
                if (choice=="1"){
                    Console.WriteLine(video1.NumOfComments());
                    Console.WriteLine("\nThese are the comments about this video: ");
                    video1.DisplayComments();        
                }
                else if(choice=="2"){
                    Console.WriteLine(video2.NumOfComments());
                    Console.WriteLine("\nThese are the comments about this video: ");
                    video2.DisplayComments();  
                }
                else if(choice=="3"){
                    Console.WriteLine(video3.NumOfComments());
                    Console.WriteLine("\nThese are the comments about this video: ");
                    video3.DisplayComments();                
                }   

            }
            else{
                Console.WriteLine("Choose a number within the menu");
            }

        }while(user!="4");
    }
}