using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject fireballPrefab; 
    public float startDelay = 2;
    public float spawnInterval = 1f;
    public Vector3 newSize;
    public Vector3 originalSize;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFireball", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        changeSize();
        resetSize();

    }

    private void changeSize() //Metodo para cambiar el tamaño de las esferas.
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            fireballPrefab.transform.localScale = fireballPrefab.transform.localScale += newSize;
        }
    }

    private void resetSize() //Metodo para resetear el tamaño de las esferas.
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            fireballPrefab.transform.localScale = originalSize;
        }
    }

    private void SpawnFireball() //Metodo para instanciar las esferas
    {
        Instantiate(fireballPrefab, transform.position, fireballPrefab.transform.rotation);
    }
}   
