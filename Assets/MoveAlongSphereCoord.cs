using Unity.VisualScripting;
using UnityEngine;

public class MoveAlongSphereCoord : MonoBehaviour
{
    public Vector3 center = new Vector3(0, 0, 0);
    public float moveAngle0 = 0;
    public float moveAngleF = 0;

    float r, angle0, angleF;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        Vector3 vec3 = renderer.transform.position;
        Vector3 coordsRelativelyPoint = vec3 - center;

        r = Mathf.Sqrt(Mathf.Pow(coordsRelativelyPoint.x, 2) + Mathf.Pow(coordsRelativelyPoint.y, 2) + Mathf.Pow(coordsRelativelyPoint.z, 2));
        angle0 = Mathf.Atan2(Mathf.Sqrt(Mathf.Pow(coordsRelativelyPoint.x, 2) + Mathf.Pow(coordsRelativelyPoint.y, 2)), coordsRelativelyPoint.z);
        angleF = Mathf.Atan2(coordsRelativelyPoint.y, coordsRelativelyPoint.x);

        // Debug.Log(string.Format("1. {0}, {1}, {2}, {3}", r, angle0, angleF, vec3));
    }

    void Update()
    {
        Renderer renderer = GetComponent<Renderer>();
        Vector3 vec3 = renderer.transform.position;

        angle0 += moveAngle0 * Time.deltaTime;
        angleF += moveAngleF * Time.deltaTime;

        // Debug.Log(string.Format("2. {0}, {1}, {2}, {3}", r, angle0, angleF, vec3));

        vec3.x = r * Mathf.Sin(angle0) * Mathf.Cos(angleF);
        vec3.y = r * Mathf.Sin(angle0) * Mathf.Sin(angleF);
        vec3.z = r * Mathf.Cos(angle0);

        // Debug.Log(string.Format("3. {0}, {1}, {2}, {3}", r, angle0, angleF, vec3));

        renderer.transform.position = vec3;
    }
}
