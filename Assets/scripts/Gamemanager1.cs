using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager1 : MonoBehaviour
{
    // Start is called before the first frame update
    bool gamehasended = false;

    // Update is called once per frame
    public float restartdelay=1f;
   public void Endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAME OVER!!!");
            Invoke("Restart", restartdelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
