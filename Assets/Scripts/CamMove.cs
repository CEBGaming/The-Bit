using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject Marino;
    public float Offset;
    public float SmoothOffset;
    private Vector3 MarinoPos;

    // Start is called before the first frame update
    void Start()
    {
        Offset = 10.5f;
        SmoothOffset = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        MarinoPos = new Vector3(Marino.transform.position.x, transform.position.y, transform.position.z);

        if (Marino.transform.localScale.x > 0f)
        {
            MarinoPos = new Vector3(MarinoPos.x + Offset, MarinoPos.y, MarinoPos.z);
        }
        else
        {
            MarinoPos = new Vector3(MarinoPos.x - Offset, MarinoPos.y, MarinoPos.z);
        }

        transform.position = Vector3.Lerp(transform.position, MarinoPos, SmoothOffset * Time.deltaTime);
    }


}
