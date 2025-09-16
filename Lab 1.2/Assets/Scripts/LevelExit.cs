using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)  // nếu là 3D
    {
        if (other.CompareTag("Player"))  // Player đi qua trigger
        {
            SceneManager.LoadScene("_Scene_1");
        }
    }

    // Nếu làm 2D thì dùng OnTriggerEnter2D
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("_Scene_1");
        }
    }
}