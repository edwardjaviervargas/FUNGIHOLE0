using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour
{
    LineRenderer line;

    [SerializeField] Transform[] positions;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponentInChildren<LineRenderer>();

        line.SetPosition(0, positions[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(1, transform.position);
    }
}
