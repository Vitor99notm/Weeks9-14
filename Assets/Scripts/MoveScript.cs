using System.Collections;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Transform spriteTransform;
    public float speed = 1f;

    Coroutine spriteMove;
    Coroutine spriteScale;
    Coroutine spriteRotate;

    void Start()
    {
		spriteTransform.transform.localScale = Vector3.zero; 
    }
    void Update()
    {
        StartCoroutine(ScaleSprite());
    }

    IEnumerator ScaleSprite()
    {
        float t = 0;

        while (t < 2)
        {
            t += Time.deltaTime;
			spriteTransform.transform.localScale = Vector3.one * t;
            yield return null;

            if(t >= 2)
            {
                t = t * -1f;
            }
        }
    }
}
