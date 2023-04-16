using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotator : MonoBehaviour
{
    [SerializeField] float _rotationFactor = 200;
    public float RotationSpeed = 5000;
    public float health = 100;
    public System.Action onDamageTaken;
    private void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * RotationSpeed * _rotationFactor);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Damage();
    }
    private void Damage()
    {
        health -= 25;
        health = Mathf.Clamp(health, 0, 100);
        onDamageTaken?.Invoke();
    }
}
