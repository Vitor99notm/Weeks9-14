using System.Collections;
using UnityEngine;

public class Grower : MonoBehaviour
{
    public Transform treeTransform;
    void Start()
    {
        treeTransform.transform.localScale = Vector2.zero;

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

        while(t < 1){

            t += Time.deltaTime;
            treeTransform.transform.localScale = Vector3.one * t;
            yield return null;
        }
    }
}
