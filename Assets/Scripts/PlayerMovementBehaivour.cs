using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaivour : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    void Start()
    {

    }

    private void FixedUpdate()
    {
        Vector3 movementDirection = Vector3.zero;

        
        if (Input.GetKey(KeyCode.W)) { movementDirection += Vector3.forward; }
        if (Input.GetKey(KeyCode.S)) { movementDirection += Vector3.back; }
        if (Input.GetKey(KeyCode.A)) { movementDirection += Vector3.left; }
        if (Input.GetKey(KeyCode.D)) { movementDirection += Vector3.right; }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position +=
                (movementDirection.z * transform.forward +
                movementDirection.x * transform.right) *
                _movementSpeed * 2 * Time.deltaTime;
        }
        else
        {
            transform.position +=
                (movementDirection.z * transform.forward +
                movementDirection.x * transform.right) *
                _movementSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EndPoint")
        {
            Debug.Log("ENDED");
        }
        
    }
}
