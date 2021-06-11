using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    public void firecactus(float damage) {
        Instantiate(projectile, gun.transform.position, transform.rotation);
        
    }
}
