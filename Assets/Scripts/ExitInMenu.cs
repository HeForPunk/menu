using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitInMenu : MonoBehaviour
{
    public void ExitMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
