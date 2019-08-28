
using UnityEngine;
using UnityEngine.SceneManagement;
public class Infinity : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;


    int scoreint;
    float cal;

    void Update()
    {
        cal = player.position.z;
        scoreint = (int)cal;
        if (scoreint > 900)
        {
            updatetheposi();
        }
    }

    public void updatetheposi()
    {
        Vector3 newposi;
        int l, r;
        l = (int)player.position.x;
        r= (int)player.position.y;

        newposi = new Vector3(l, r, -100);
        player.position = newposi;

        GameObject thePlayer = GameObject.Find("Player");
        var playerScript = thePlayer.GetComponent<NewBehaviourScript>();
        playerScript.ForwardForce += 500f;

    }

    //    void restartscene()
    //    {


    //        Debug.Log("GOOOO");
    //        if (scoreint>900)
    //        {

    //            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //        }

    //    }
    //}
}