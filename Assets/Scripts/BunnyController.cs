using UnityEngine;
using System.Collections;

public class BunnyController : MonoBehaviour {

    private Rigidbody2D _body;

    public float force = 750f;

	// Use this for initialization
	void Start () {
        _body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonUp("Jump"))
        {
            _body.AddForce(transform.up * force);
        }
	}
}
