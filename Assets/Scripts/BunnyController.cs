using UnityEngine;
using System.Collections;

public class BunnyController : MonoBehaviour {

    private Rigidbody2D body;
    private Animator animation;
    public float force = 750f;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonUp("Jump"))
        {
            body.AddForce(transform.up * force);
        }

        animation.SetFloat("Velocity", Mathf.Abs(body.velocity.y));
	}
}
