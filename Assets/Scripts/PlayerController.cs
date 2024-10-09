using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : CharacterBehaviour
{
    public static PlayerController instance;
    public List<KeyBehaviour> keysCollected;
    [SerializeField] private GameObject _failureWindow;
    [SerializeField] private TextMeshProUGUI _healthUIText;
    void Awake()
    {
        instance = this;
        _failureWindow.SetActive(false);
    }

    private void Update()
    {
        _healthUIText.text = "Health: " + _currentHealth + "/" + _maxHealth;
    }

    public override void Die()
    {
        _failureWindow.SetActive(true);
        GetComponent<PlayerMovementBehaivour>().enabled = false;
        GetComponent<PlayerWeaponBehaivour>().enabled = false;
        GetComponentInChildren<CameraController>().enabled = false;
    }
}