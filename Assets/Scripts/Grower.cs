using UnityEngine;

public class Grower : MonoBehaviour
{
    public Transform treeTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrowTree()
    {
        float t = 0;

        while(t < 1){

            t += Time.deltaTime;
            treeTransform.transform.localScale = Vector3.one * t;
        }
    }
}
