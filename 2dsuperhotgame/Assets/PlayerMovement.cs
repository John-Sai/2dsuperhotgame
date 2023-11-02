using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		float dirX = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(dirX * 10f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector3(rb.velocity.x, 10);
		}
    }
}
