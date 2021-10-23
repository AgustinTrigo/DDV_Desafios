using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballController : MonoBehaviour
{
    public float fireballSpeed = 10f;
    public float timeFireball = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireballMovement(Vector3.forward);
        fireballTimelive();


    }   

    private void FireballMovement(Vector3 direction)
    {
        transform.Translate(fireballSpeed * Time.deltaTime * direction);
    }

    private void fireballTimelive()
    {
        timeFireball -= Time.deltaTime;
        if (timeFireball < 0)
        {
            Destroy(gameObject);
        }
    }
}
