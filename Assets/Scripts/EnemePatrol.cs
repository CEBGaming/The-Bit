using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemePatrol : MonoBehaviour
{
    public Transform LeftEdge;
    public Transform RightEdge;

    public Transform Enemy;

    public float speed;
    public bool MovingLeft;

    private Vector3 Scale;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        Scale = Enemy.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (MovingLeft)
        {
            if (Enemy.position.x >= LeftEdge.position.x)
                MoveInDirection(-1);
            else
                DirectionChange();
        }
        else
        {
            if (Enemy.position.x <= RightEdge.position.x)
                MoveInDirection(1);
            else
                DirectionChange();
        }
    }

    void DirectionChange()
    {
        MovingLeft = !MovingLeft;
    }

    void MoveInDirection(int Direction)
    {
        Enemy.localScale = new Vector3(Mathf.Abs(Scale.x) * Direction, Scale.y, Scale.z);

        Enemy.position = new Vector3(Enemy.position.x + Time.deltaTime * Direction * speed,Enemy.position.y, Enemy.position.z);
    }
}
