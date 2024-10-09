using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponBehaviour : WeaponBehaviour
{
    [SerializeField] private float _cooldownTimer;
    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _cooldownTimer)
        {
            RaycastHit hit;

            Physics.Raycast(transform.position, PlayerController.instance.transform.position - transform.position, out hit);
            if (hit.transform.tag != "Player") return;

            Physics.Raycast(transform.position, transform.forward, out hit);
            FireWeapon(hit);
            _timer -= _cooldownTimer;
        }
    }
}
