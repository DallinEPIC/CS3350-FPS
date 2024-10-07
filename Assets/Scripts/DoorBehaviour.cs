using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    private bool _playerInRange;
    [SerializeField] private KeyBehaviour _keyForDoor;
    public Color doorColor;

    void Start()
    {
        GetComponent<MeshRenderer>().material.color = doorColor;
        _keyForDoor.GetComponent<MeshRenderer>().material.color = doorColor;
    }

    void Update()
    {
        if (!_playerInRange) return;

        if(Input.GetKeyDown(KeyCode.E))
        {
            foreach(KeyBehaviour key in PlayerController.instance.keysCollected)
            {
                if (key == _keyForDoor)
                {
                    Destroy(gameObject);
                    return;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        _playerInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        _playerInRange = false;
    }
}
