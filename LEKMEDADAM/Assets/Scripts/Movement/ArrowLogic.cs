using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLogic : MonoBehaviour
{
    enum Direction { Up, Down, Left, Right};
    [SerializeField]
    Direction direction;
    private Vector3 movement;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        switch (direction)
        {
            case (Direction.Up): movement = new Vector3(0, 1, 0); break;
            case (Direction.Down): movement = new Vector3(0, -1, 0); break;
            case (Direction.Left): movement = new Vector3(-1, 0, 0); break;
            case (Direction.Right): movement = new Vector3(1, 0, 0); break;
        }
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        player.transform.position += movement;
    }
}
