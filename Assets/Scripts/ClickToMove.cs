using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickToMove : MonoBehaviour
{
    public LineRenderer LR;
    public List<Vector2> points;

    public Vector2 mousePosNewInputSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = new List<Vector2>();
        points.Add(transform.position);

        LR.positionCount = points.Count;

        for (int i = 0; i < points.Count; i++)
        {
            LR.SetPosition(i, points[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //adds new point in line
            Vector2 newPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            points.Add(newPos);
            UpdateLineRender();
        }

        if(Mouse.current.rightButton.wasPressedThisFrame)
        {

            points.RemoveAt(0);
            UpdateLineRender();
        }

     }

     void UpdateLineRender()
     {
		LR.positionCount = points.Count;
		for (int i = 0; i < points.Count; i++)
		{
			LR.SetPosition(i, points[i]);
		}
	}

    //public void OnPoint(InputAction.CallbackContext context)
    //{
		//mousePosNewInputSystem = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());

	//}
}
