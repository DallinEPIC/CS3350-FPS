using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _playerCapsule;
    [SerializeField] private float _rotationSensitivity;
    [SerializeField] private float _minVerticalRotation, _maxVerticalRotation;
    private Vector3 _horizontalRotation, _verticalRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        _horizontalRotation.y += Input.GetAxis("Mouse X") * _rotationSensitivity * Time.deltaTime;
        _verticalRotation.x += -Input.GetAxis("Mouse Y") * _rotationSensitivity * Time.deltaTime;

        _verticalRotation.x = Mathf.Clamp(_verticalRotation.x, _minVerticalRotation, _maxVerticalRotation);

        _playerCapsule.transform.eulerAngles = _horizontalRotation;
        transform.eulerAngles = new Vector3(_verticalRotation.x, transform.eulerAngles.y);
    }
}
