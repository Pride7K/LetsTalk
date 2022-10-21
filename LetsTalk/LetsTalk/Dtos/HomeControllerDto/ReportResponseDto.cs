using LetsTalk.Models;

namespace LetsTalk.Dtos.HomeControllerDto
{
    public struct ReportResponseDto
    {
        public long totalMessages { get; set; }
        public int totalUsers { get; set; }
        public long averageContentLength { get; set; }
        public long maximumContentLength { get; set; }
        public long shotestMessage { get; set; }
        public long longestMessage { get; set; }
        public User MostActiveUserByNumberOfMessages { get; set; }
    }
}