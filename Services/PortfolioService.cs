using GitPagePortfolio.Models;

namespace GitPagePortfolio.Services
{
    public class PortfolioService
    {
        // 친구가 원한대로 리스트에 객체들을 미리 만들어두는 곳!
        // 여기에 데이터를 하드코딩해서 관리하자.
        private readonly List<Portfolio> _portfolios = new()
        {
            // [00번 포트폴리오 = key 포트폴리오]
            new Portfolio
            {
                Id = 0,
                Title = "ApocalypseMatrix",
                Description = """
                [ 리플렉션 및 최적화 설계를 활용한 AR 번역 ]
                "회사 생활은 곧 팀 프로젝트"라는 멘토의 조언을 받아들여,
                개인의 기술적 욕심을 버리고 철저히 팀원들이 편하게 작업할 수 있는 환경을 만드는 데 집중했습니다.
                PM이자 시스템 아키텍트로서 Reflection을 활용한 자동 바인딩 시스템(DI)을 구축해 팀원의 반복 작업을 줄이고,
                CSV 기반의 다국어 데이터 로직을 설계해 기획 의도를 정확히 구현했습니다.
                이 과정을 통해 '나를 죽이고 팀의 서포터가 되는 것'이 프로젝트의 완성도를 높이는 가장 확실한 방법임을 깨달았습니다.
                """,
                TotalSlides = 20
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
                TotalSlides = 16
            },
            
            // [02번 포트폴리오] ... 계속 추가하면 됨
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