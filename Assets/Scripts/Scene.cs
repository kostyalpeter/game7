using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Game()
    {
        if (Spin.canPlay)
        {
            SceneManager.LoadScene("Game");
        }
    }
    public void Gamble()
    {
        SceneManager.LoadScene("Gamble");
    }
}
