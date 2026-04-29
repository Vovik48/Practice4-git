using UnityEngine;

public class RandomColor : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
