
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    // Start is called before the first frame update
    public NewBehaviourScript movement;
    
    // Update is called once per frame

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "ObstacleTag" || collisionInfo.collider.tag == "ObnewTag")
        {
            movement.enabled = false;
            FindObjectOfType<Gamemanager1>().Endgame();

        }
    }
}

