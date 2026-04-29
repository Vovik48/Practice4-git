using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log(string.Format("StartGame"));
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Debug.Log("Выход из игры");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
