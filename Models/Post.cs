namespace GitPagePortfolio.Models
{
    public class Post
    {
        public int Id { get; set; } // 글 번호
        public string Title { get; set; } = string.Empty; // 제목
        public string Content { get; set; } = string.Empty; // 내용
        public DateTime Date { get; set; } // 작성일
    }
}