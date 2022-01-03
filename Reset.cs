using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public int X = 0;
    public int Y = 0;
    public int Z = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameVariable.checkpoint = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            transform.position = GameVariable.checkpoint;
            transform.rotation = Quaternion.Euler(X, Y, Z);
        }
    }
}
