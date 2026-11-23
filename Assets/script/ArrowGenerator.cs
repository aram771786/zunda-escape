using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab = null;

    // 생성된 화살 인스턴스를 저장하는 변수
    GameObject arrowInstance = null;

    // 화살이 생성될 x 좌표를 저장하는 변수
    int arrowPositionX = 0;

    // 화살 생성 시간 간격 : 1초 마다 화살 생성
    float arrowCreateInterval = 1.0f;

    // 프레임마다 경과한 시간을 누적하는 변수   
    float elapsedTime = 0.0f;

    // 게임 싲낙 시 한 번 실행
    void Start()
    {
        
    }

    // 매 프레임 실행
    void Update()
    {
        // 프레임 사이의 경과 시간을 누적
        //  Time.deltaTime : 이전 프레암과 현재 프레임 사이의 시간(초)
        elapsedTime += Time.deltaTime;

        // 누적 시간이 화살 생성 간격(1초)을 초과하면 화살 생성
        if (elapsedTime > arrowCreateInterval)
        {
            // 누적 경과 시간 초과
            elapsedTime = 0.0f;

            // 화살 프리팹으로부터 화살 인스턴스 생성
            arrowInstance = Instantiate(arrowPrefab);

            // 화살이 생성될 x 좌표를 무작위로 결정
            arrowPositionX = Random.Range(-6, 7);
            
            // 생성된 화살의 위치 설정
            // X : -6 ~ 6 사이의 무작위 좌표
            // Y : 7 (화면 위쪽)
            // Z : 0
            arrowInstance.transform.position = new Vector3(arrowPositionX, 7, 0);
        }
    }
}
