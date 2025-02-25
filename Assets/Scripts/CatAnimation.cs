using UnityEngine;

public class CatAnimation : MonoBehaviour
{

    public float speed = 1f; // Viteza plutirii
    public float height = 0.5f; // Înălțimea maximă a oscilației

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }

}
