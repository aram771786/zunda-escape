
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // HP 게이지 이미지
    public Image hpGauge;

    // 게임오버 패널
    public GameObject gameOverPanel;

    // 게임오버 상태 확인
    bool isGameOver = false;

    void Start()
    {
        // 게임 시작 시 게임오버 창 숨기기
        gameOverPanel.SetActive(false);

        // 게임 시간 정상화
        Time.timeScale = 1.0f;
    }

    // HP 감소 함수
    public void DecreaseHp()
    {
        // 이미 게임오버라면 실행하지 않음
        if (isGameOver) return;

        // HP를 10% 감소
        hpGauge.fillAmount -= 0.1f;

        // HP가 0 아래로 내려가지 않도록 설정
        hpGauge.fillAmount = Mathf.Clamp01(hpGauge.fillAmount);

        Debug.Log("현재 HP : " + hpGauge.fillAmount);

        // HP가 0이 되면 게임오버
        if (hpGauge.fillAmount <= 0)
        {
            GameOver();
        }
    }

    // 게임오버 함수
    void GameOver()
    {
        isGameOver = true;

        // 게임오버 창 표시
        gameOverPanel.SetActive(true);

        // 게임 정지
        Time.timeScale = 0f;

        Debug.Log("GAME OVER!");
    }
}
