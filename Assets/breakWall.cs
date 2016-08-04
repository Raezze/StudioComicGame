using UnityEngine;
using System.Collections;

public class breakWall : MonoBehaviour
{

    void onTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown("space"))
        {
            if(other.GetComponent<Player>())
            {
                Destroy(gameObject);
            }
        }
    }
}