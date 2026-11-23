using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리 네임스페이스 추가

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string game)
    {
        SceneManager.LoadScene(game);
    }
}
