using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiControl : MonoBehaviour, Damageable
{

    private GameObject player;
    private Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        myRigidBody.MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, 1 * Time.deltaTime));
    }

    public void TakeDamage(int damage)
    {
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
