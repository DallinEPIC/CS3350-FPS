using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _rotationSensitivity, _maxRotationPerFrame;
    [SerializeField] private float _minVerticalRotation, _maxVerticalRotation;
    private Vector3 _horizontalRotation, _verticalRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Vector3 horizontalDelta = new Vector3(
            0, Input.GetAxis("Mouse X") * _rotationSensitivity * Time.deltaTime);
        Vector3 verticalDelta = new Vector3(
            -Input.GetAxis("Mouse Y") * _rotationSensitivity * Time.deltaTime, 0);
        _horizontalRotation += Vector3.ClampMagnitude(horizontalDelta, _maxRotationPerFrame);
        _verticalRotation += Vector3.ClampMagnitude(verticalDelta, _maxRotationPerFrame);

        _verticalRotation.x = Mathf.Clamp(_verticalRotation.x, _minVerticalRotation, _maxVerticalRotation);

        _player.transform.eulerAngles = _horizontalRotation;
        transform.eulerAngles = new Vector3(_verticalRotation.x, transform.eulerAngles.y);
    }
}
