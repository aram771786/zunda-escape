
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameOverController : MonoBehaviour, IPointerClickHandler
{
    // 게임오버 화면을 클릭하면 실행
    public void OnPointerClick(PointerEventData eventData)
    {
        // Main 씬으로 이동
        SceneManager.LoadScene("Main");
    }
}
