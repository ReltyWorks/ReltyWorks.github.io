namespace GitPagePortfolio.Models
{
    public class Portfolio
    {
        // 1. 고유 번호 (0, 1, 2...) -> 폴더 이름으로도 쓸 예정 (ex: 00, 01)
        public int Id { get; set; }

        // 2. 프로젝트 제목
        public string Title { get; set; } = string.Empty;

        // 3. 설명 (5~6줄)
        public string Description { get; set; } = string.Empty;

        // 4. 슬라이드(이미지)가 총 몇 장인지? (이걸 알아야 for문을 돌리니까!)
        public int TotalSlides { get; set; }

        // 5. 썸네일 경로 가져오기 (편의상 1번 이미지를 썸네일로 씀)
        // D2 : 숫자를 00, 01 포맷으로 바꿔줌
        public string ThumbnailPath => $"files/{Id:D2}/01.jpg";

        // 6. 구글 드라이브 링크 (없을 수도 있으니 ? 붙임)
        public string? DriveUrl { get; set; }
    }
}