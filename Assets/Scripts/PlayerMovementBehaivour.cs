using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaivour : MonoBehaviour
{
    [SerializeField] private float _movementSpeed, _rotationSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 rotation = Vector3.zero;
        rotation.y = Input.GetAxis("Mouse X");
        transform.Rotate(rotation * _rotationSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector3 movementDirection = Vector3.zero;

        
        if (Input.GetKey(KeyCode.W)) { movementDirection += Vector3.forward; }
        if (Input.GetKey(KeyCode.S)) { movementDirection += Vector3.back; }
        if (Input.GetKey(KeyCode.A)) { movementDirection += Vector3.left; }
        if (Input.GetKey(KeyCode.D)) { movementDirection += Vector3.right; }

        transform.position +=
            (movementDirection.z * transform.forward +
            movementDirection.x * transform.right) *
            _movementSpeed * Time.deltaTime;

    }
}
