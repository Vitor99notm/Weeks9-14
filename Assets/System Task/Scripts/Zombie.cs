using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform startPos;
    public Transform playerPos;
    public float speed = 0.1f;
    public float t;

    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 3)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(startPos.position, playerPos.position, curve.Evaluate(t));

    }
}
