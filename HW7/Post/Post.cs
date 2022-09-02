

namespace HW7.PostNamespace;
internal class Post
{
    public readonly Guid Id;
    public string Content { get; set; }
    public readonly DateTime CreationDateTime;
    private int likeCount;
    public int LikeCount
    {
        get { return likeCount; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            likeCount = value;
        }
    }

    private int viewCount;

    public int ViewCount
    {
        get { return viewCount; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            viewCount = value;
        }
    }
    public Post(string content)
    {
        Id = Guid.NewGuid();
        CreationDateTime = DateTime.Now;
        Content = content;
        LikeCount = 0;
        ViewCount = 0;
    }

    public override string ToString()
    {
        return ($"Id {Id}," +
            $"Content - {Content}," +
            $"Creation Date Time - {CreationDateTime}," +
            $"Like Count {LikeCount}," +
            $"View Count {ViewCount}");
    }
}

