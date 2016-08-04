using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 50f;
    public float jumpPower = 150f;

    public bool grounded;

    private Rigidbody2D rb2d;

    private GameObject wall;

	// Use this for initialization
	void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("x") && wall != null)
        {
            Destroy(wall.gameObject);
            wall = null;
        }
	}

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce(Vector2.right * speed * h);
    }

    void onTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "breakableWall")
        {
            wall = other.gameObject;

        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "breakableWall")
        {
            wall = null;

        }
    }
}
