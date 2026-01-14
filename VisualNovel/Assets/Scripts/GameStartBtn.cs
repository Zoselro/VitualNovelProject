using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStartBtn : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
