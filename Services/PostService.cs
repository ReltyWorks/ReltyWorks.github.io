using GitPagePortfolio.Models;
using YamlDotNet.Serialization;

namespace GitPagePortfolio.Services
{
    public class PostService
    {
        private readonly HttpClient _http;
        private List<Post>? _posts; // 데이터를 메모리에 보관할 변수

        public PostService(HttpClient http)
        {
            _http = http;
        }

        // 1. 001.yaml 부터 시작해서 파일이 없을 때까지 싹 긁어오는 함수
        public async Task LoadPostsAsync()
        {
            // 이미 로드했으면 또 하지 않음 (캐싱)
            if (_posts != null) return;

            _posts = new List<Post>();

            // Yaml 파서 준비
            var deserializer = new DeserializerBuilder()
                .IgnoreUnmatchedProperties()
                .Build();

            int index = 1;

            while (true)
            {
                // "post/001.yaml", "post/002.yaml" ... 형식으로 경로 생성
                string filePath = $"post/{index:D3}.yaml";

                try
                {
                    // 서버(Github Pages)에 파일 요청
                    var response = await _http.GetAsync(filePath);

                    // 만약 404(Not Found)가 뜨면? -> 더 이상 글이 없는 거니까 그만!
                    if (!response.IsSuccessStatusCode)
                    {
                        break;
                    }

                    // 파일 내용을 문자열로 읽음
                    string yamlContent = await response.Content.ReadAsStringAsync();

                    // 문자열 -> Post 객체로 변환
                    var post = deserializer.Deserialize<Post>(yamlContent);

                    // 혹시 YAML 안에 ID를 안 적었을까 봐, 파일 번호로 ID를 강제 주입 (안전장치)
                    if (post.Id == 0) post.Id = index;

                    _posts.Add(post);

                    // 다음 번호로 넘어가기 (1 -> 2 -> 3 ...)
                    index++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] {filePath} 로딩 실패: {ex.Message}");
                    // 에러가 나면 안전하게 멈춤
                    break;
                }
            }

            // 최신 글이 위로 오도록(번호 역순) 정렬
            _posts.Reverse();
        }

        // 2. 전체 목록 반환
        public List<Post> GetAll()
        {
            return _posts ?? new List<Post>();
        }

        // 3. 특정 ID 글 반환
        public Post? GetById(int id)
        {
            return _posts?.FirstOrDefault(p => p.Id == id);
        }
    }
}