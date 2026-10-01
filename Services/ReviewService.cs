namespace WhiskerList.Services;

public class ReviewService
{
    public List<ReviewItem> Reviews { get; private set; } = new()
    {
        new ReviewItem { Author = "CatLover99", Rating = 5, Comment = "Super helpful app!", Date = DateTime.Now.AddDays(-2) },
        new ReviewItem { Author = "DevUser", Rating = 4, Comment = "Clean UI and smooth navigation.", Date = DateTime.Now.AddDays(-1) }
    };

    public void AddReview(int rating, string comment, string author = "You")
    {
        Reviews.Insert(0, new ReviewItem
        {
            Author = author,
            Rating = rating,
            Comment = comment,
            Date = DateTime.Now
        });
    }
}

public class ReviewItem
{
    public string Author { get; set; } = string.Empty;
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}