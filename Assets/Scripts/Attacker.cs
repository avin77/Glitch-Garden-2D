using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0f,5f)] float currentSpeed=1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float newSpeed) {
        currentSpeed = newSpeed ;
    }
}
