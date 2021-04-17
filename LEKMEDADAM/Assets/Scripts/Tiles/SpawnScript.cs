using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject grid;
    // Start is called before the first frame update
    void Start()
    {
        GameObject spawnGrid = Instantiate(grid);
        spawnGrid.transform.position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spawned"))
        {
            Destroy(gameObject);
        }
    }
}
