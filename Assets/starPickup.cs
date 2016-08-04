using UnityEngine;
using System.Collections;

public class starPickup : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>() == null)
        {
            return;
        }

        //put star power stuff here

        Destroy(gameObject);
    }
}
