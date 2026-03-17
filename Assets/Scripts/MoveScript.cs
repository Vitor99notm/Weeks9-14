using System.Collections;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Transform spriteTransform;
    public float speed = 1f;
    public float speedDelay = 1;

    Coroutine spriteMove;
    Coroutine spriteScale;

    void Start()
    {
		spriteTransform.transform.localScale = Vector3.zero; 
    }
    void Update()
    {
        StartCoroutine(ScaleSprite());
        StartCoroutine(MoveSprite());
    }

    IEnumerator MoveSprite()
    {
        while (speed < 3)
        {
            spriteTransform.transform.position = Vector3.one * speed;
            speed++;
            yield return new WaitForSeconds(speedDelay);
			if (speed >= 3)
            {
                speed = speed * -1f;
            }
        }

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
