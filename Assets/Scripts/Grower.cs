using System.Collections;
using UnityEngine;

public class Grower : MonoBehaviour
{
    public Transform treeTransform;
    public Transform appleTransform;
    public float appleDelay = 1;
    void Start()
    {
        treeTransform.transform.localScale = Vector2.zero;
        appleTransform.transform.localScale = Vector2.zero;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTreeGrowing()
    {
		StartCoroutine(GrowTree());
	}

	IEnumerator GrowTree()
    {
        float t = 0;

		treeTransform.transform.localScale = Vector2.zero;
		appleTransform.transform.localScale = Vector2.zero;

		while (t < 1){

            t += Time.deltaTime;
            treeTransform.transform.localScale = Vector3.one * t;
            yield return null;
        }

        yield return new WaitForSeconds(appleDelay);

        t = 0;

		while (t < 1)
		{

			t += Time.deltaTime;
			appleTransform.transform.localScale = Vector3.one * t;
			yield return null;
		}
	}
}
