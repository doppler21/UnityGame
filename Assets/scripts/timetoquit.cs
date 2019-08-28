using UnityEngine.SceneManagement;
using UnityEngine;


public class timetoquit : MonoBehaviour
{
    // Start is called before the first frame update
    public 

    private void FixedUpdate()
    {
        if (Input.GetKey("q"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

}
