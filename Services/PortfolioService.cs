using GitPagePortfolio.Models;

namespace GitPagePortfolio.Services
{
    public class PortfolioService
    {
        private readonly List<Portfolio> _portfolios = new()
        {
            // [key 포트폴리오]
            new Portfolio
            {
                Id = 0,
                Title = "KeyPortfolio",
                Description = """
                'DataBridgeSystem' 포트폴리오 중 발췌
                jpgCount3pofolLink4
                'BobCatServer' 포트폴리오 중 발췌
                jpgCount4pofolLink3
                'ApocalypseMatrix' 포트폴리오 중 발췌
                jpgCount5pofolLink2
                """, // jpgCount = 보여줄 사진 장 수, pofolLink = Id
                TotalSlides = 11, // jpgCount의 합과 맞아야함!
                DriveUrl = null
            },

            // [01번 포트폴리오]
            new Portfolio
            {
                Id = 1,
                Title = "ButtonOperator",
                Description = """
                [ C#기본 Socket API를 활용한 TCP/IP서버 ]
                취업을 위해 포트폴리오는 네트워크를 꼭 붙이라는 조언을 듣고,
                AI에게 가장 어려운 네트워크 방식을 물어 첫번째 프로젝트로 TCP/IP 소켓 통신을 선택했습니다.
                남의 코드를 복사하는 대신 공식 문서를 보며 직접 쓰레드와 바이트 배열을 다뤘고,
                AI는 오직 검수용으로만 활용했습니다.
                다소 투박하더라도 직접 패킷 시스템을 설계하고 구현한 이 경험은 네트워크의 본질을 이해하고,
                AI의 코드를 의심하며 검증하는 습관을 기르는 가장 확실한 계기가 되었습니다.
                """,
                TotalSlides = 16,
                DriveUrl = "https://drive.google.com/drive/folders/1kwQZhXstcyocTgIkHeKruvGgt2LFHprN"
            },

            // [02번 포트폴리오]
            new Portfolio
            {
                Id = 2,
                Title = "ApocalypseMatrix",
                Description = """
                [ 리플렉션 및 최적화 설계를 활용한 AR 번역 ]
                "회사 생활은 곧 팀 프로젝트"라는 멘토의 조언을 받아들여,
                개인의 기술적 욕심을 버리고 철저히 팀원들이 편하게 작업할 수 있는 환경을 만드는 데 집중했습니다.
                PM이자 시스템 아키텍트로서 Reflection을 활용한 자동 바인딩 시스템(DI)을 구축해 팀원의 반복 작업을 줄이고,
                CSV 기반의 다국어 데이터 로직을 설계해 기획 의도를 정확히 구현했습니다.
                이 과정을 통해 '나를 죽이고 팀의 서포터가 되는 것'이 프로젝트의 완성도를 높이는 가장 확실한 방법임을 깨달았습니다.
                """,
                TotalSlides = 20,
                DriveUrl = "https://drive.google.com/drive/folders/1zVKgcek1vOwtWXQaqhgd963yeE46hk3t"
            },
            
            // [03번 포트폴리오]
            new Portfolio
            {
                Id = 3,
                Title = "BobCatServer",
                Description = """
                [ gRPC & HTTP/2를 활용한 비동기 게임 서버 ]
                이전 프로젝트(ButtonOperator)에서 겪었던 스레드 관리의 비효율을 개선하고자,
                최신 기술인 gRPC와 Async/Await 비동기 모델을 도입해 성능과 생산성을 동시에 잡았습니다.
                특히 유니티 엔진과 .NET 라이브러리 간의 호환성 문제를 해결하며,
                단순한 코딩을 넘어 '외부 라이브러리를 엔진에 통합하고 최적화하는' 실무적인 문제 해결 능력을 길렀습니다.
                과거의 실패를 기술적 성장의 발판으로 삼은, 가장 애착이 가는 프로젝트입니다.
                """,
                TotalSlides = 10,
                DriveUrl = "https://drive.google.com/drive/folders/1By4N7q3uv4pbRCQ6llY8WdYhLSv6jK3N"
            },
            
            // [04번 포트폴리오] 
            new Portfolio
            {
                Id = 4,
                Title = "DataBridgeSystem",
                Description = """
                [ Pruning Trie 기반의 고성능 검색 미들웨어 ]
                "1주일 내 MVP 출시"와 "PHP 레거시 연동"이라는 까다로운 제약 속에서,
                Trie 자료구조를 직접 최적화하여 21만 건의 데이터를 0ms에 검색하도록 구현했습니다.
                또한 gRPC와 REST API를 동시에 지원하는 하이브리드 아키텍처를 통해 클라이언트의 요구를 완벽히 충족시켰습니다.
                성능 최적화와 트러블 슈팅 과정을 통해, 기술은 결국 '비즈니스 문제를 해결하는 도구'임을 증명하고자 했습니다.
                """,
                TotalSlides = 11,
                DriveUrl = "https://drive.google.com/drive/folders/1lLdpWwbUO58OmJwLKNaaFK676V_jBo5a"
            },
        };

        // 전체 목록을 달라고 할 때 쓰는 함수
        public List<Portfolio> GetAll()
        {
            return _portfolios;
        }

        // 특정 번호(id)의 포트폴리오 하나만 달라고 할 때 쓰는 함수
        public Portfolio GetById(int id)
        {
            // 리스트에서 해당 id를 가진 녀석을 찾아서 줌 (없으면 null)
            return _portfolios.FirstOrDefault(p => p.Id == id);
        }
    }
}