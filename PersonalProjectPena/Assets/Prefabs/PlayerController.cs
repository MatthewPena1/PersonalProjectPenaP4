using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody playerRb;
    public Vector3 movement;
    public float zBound = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 direction)
    {
        playerRb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
}
