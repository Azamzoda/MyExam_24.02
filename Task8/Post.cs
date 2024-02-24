

public class Post
{
    string Title;
    string Description;
    int likeCount;
    List<string> Comments = new List<string>();
    bool isPublished;

    public void Publish()
    {
        System.Console.WriteLine($"The post is published.");
        isPublished = true;
    }
    public void Like() 
    {
        likeCount++;
    }
    public List<string> Comment(string message)
    {
       
    }


}