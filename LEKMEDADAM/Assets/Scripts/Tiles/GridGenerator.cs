using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int rows = 5;
    public int cols = 5;
    public float timer = 0;
    public float tileSize = 1;
    public bool spawned = false;
    public GameObject[] tiles;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void GenerateGrid()
    {
        
        for (int row = 0; row < rows ; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int x = UnityEngine.Random.Range(0, tiles.Length );
                GameObject tile = (GameObject)Instantiate(tiles[x], transform);

                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.position = new Vector3(posX, posY, 1);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1 && !spawned)
        {
            spawned = true;
            GenerateGrid();
        }
    }
}
