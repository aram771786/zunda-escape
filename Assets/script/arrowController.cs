

using UnityEngine;

public class arrowController : MonoBehaviour
{
    // 화살 이동 속도
    float arrowspeed = 6.0f;

    // 플레이어 오브젝트
    GameObject player = null;

    // 게임 감독 오브젝트
    GameObject gameDirector = null;

    // 화살과 플레이어의 위치
    Vector2 arrowCirclePoint = Vector2.zero;
    Vector2 playerCirclePoint = Vector2.zero;

    // 두 오브젝트 사이의 방향과 거리
    Vector2 arrowPlayerDirection = Vector2.zero;
    float arrowPlayerDistance = 0.0f;

    // 충돌 판정 반지름
    float arrowRadius = 0.5f;
    float playerRadius = 1.0f;

    // 게임 시작 시 한 번 실행
    void Start()
    {
        // 플레이어 찾기
        player = GameObject.Find("Player");

        // GameDirector 찾기
        gameDirector = GameObject.Find("GameDirector");

        // 오브젝트 확인
        if (player == null)
        {
            Debug.LogError("Player를 찾을 수 없습니다!");
        }

        if (gameDirector == null)
        {
            Debug.LogError("GameDirector를 찾을 수 없습니다!");
        }
    }

    // 매 프레임 실행
    void Update()
    {
        // 화살이 아래로 이동
        transform.Translate(0, -arrowspeed * Time.deltaTime, 0);

        // 플레이어가 없으면 실행 중단
        if (player == null) return;

        // 화살이 화면 밖으로 나가면 삭제
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
            return;
        }

        // 화살과 플레이어의 위치 확인
        arrowCirclePoint = transform.position;
        playerCirclePoint = player.transform.position;

        // 두 오브젝트 사이의 거리 계산
        arrowPlayerDirection = playerCirclePoint - arrowCirclePoint;
        arrowPlayerDistance = arrowPlayerDirection.magnitude;

        // 충돌 판정
        if (arrowPlayerDistance <= arrowRadius + playerRadius)
        {
            Debug.Log("플레이어와 화살 충돌!");

            // GameDirector를 통해 HP 감소
            if (gameDirector != null)
            {
                GameDirector director =
                    gameDirector.GetComponent<GameDirector>();

                if (director != null)
                {
                    director.DecreaseHp();
                }
                else
                {
                    Debug.LogError("GameDirector 스크립트가 없습니다!");
                }
            }

            // 충돌한 화살 삭제
            Destroy(gameObject);
        }
    }
}
