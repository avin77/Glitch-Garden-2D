using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    [SerializeField] float speed=1f;
    [SerializeField] float healthReducedBy = 50;
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        var health = otherCollision.GetComponent<Health>();
        var attacker = otherCollision.GetComponent<Attacker>();
        if (attacker && health) {
            health.dealDamage(healthReducedBy);
            Destroy(gameObject);
        }   
    }

    
}
