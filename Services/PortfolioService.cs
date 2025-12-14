using GitPagePortfolio.Models;

namespace GitPagePortfolio.Services
{
    public class PortfolioService
    {
        // 친구가 원한대로 리스트에 객체들을 미리 만들어두는 곳!
        // 여기에 데이터를 하드코딩해서 관리하자.
        private readonly List<Portfolio> _portfolios = new()
        {
            // [00번 포트폴리오]
            new Portfolio
            {
                Id = 0,
                Title = "Project 1 : 전설의 시작",
                Description = """
                이 프로젝트는 유니티를 처음 배우고 만든 3D RPG입니다.
                플레이어는 용사가 되어 마왕을 물리쳐야 합니다.
                
                - 주요 기능: 인벤토리, 몬스터 AI, 보스전
                - 사용 기술: Unity, C#, Singleton Pattern
                - 개발 기간: 2주
                (대충 5~6줄의 설명이 들어가는 공간)
                """,
                TotalSlides = 20 // 00번 폴더 안에 이미지가 5장 있다는 뜻
            },

            // [01번 포트폴리오]
            new Portfolio
            {
                Id = 1,
                Title = "Project 2 : 시뮬레이션의 혁명",
                Description = """
                보드게임 원작자의 재고 문제를 해결하기 위해 기획된
                증강현실(AR) 기반 모바일 앱입니다.
                
                기존의 정적인 보드게임에 AR 기술을 도입하여
                생동감 넘치는 연출을 구현했습니다.
                """,
                TotalSlides = 10 // 01번 폴더 안에 이미지가 10장 있다는 뜻
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