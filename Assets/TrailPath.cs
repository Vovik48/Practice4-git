using UnityEngine;
using System.Collections.Generic;

public class DrawLine : MonoBehaviour
{
    private LineRenderer line;
    private List<Vector3> points = new List<Vector3>();

    void Start()
    {
        line = GetComponent<LineRenderer>(); 

        line.positionCount = 0;
        line.widthMultiplier = 0.1f;
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (points.Count == 0 || Vector3.Distance(points[^1], pos) > 0.1f)
        {
            points.Add(pos);
            line.positionCount = points.Count;
            line.SetPositions(points.ToArray());
        }
    }
}
