using UnityEngine;
using System.Collections;

public class PlayerController2D : MonoBehaviour {

	public int moveSpeed;
	public int jumpHeight;

	public Transform groundPoint;
	public float radius;
	public LayerMask groundMask;

	bool isGrounded;
	Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		moveSpeed = 5;
		jumpHeight = 200;
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 moveDir = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed, rb2d.velocity.y);
		rb2d.velocity = moveDir = moveDir;

		isGrounded = Physics2D.OverlapCircle (groundPoint.position, radius, groundMask);

		if (Input.GetAxisRaw ("Horizontal") == 1) {
			transform.localScale = new Vector3 (1, 1, 1);
		} else if (Input.GetAxisRaw ("Horizontal") == -1) {
			transform.localScale = new Vector3 (-1, 1,1);
		}

		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {
			rb2d.AddForce(new Vector2(0, jumpHeight));
		}
	}

	void onDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere (groundPoint.position, radius);
	}
}
