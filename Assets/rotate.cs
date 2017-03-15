using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
    
	private Vector3 screenPoint;
	private Vector3 offset;

	private Rigidbody rigidbody;

	bool isInPlace = false;
		
	void OnMouseUp(){
		isInPlace = true;
	}

	void OnMouseDown(){
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
		
	void OnMouseDrag(){
		Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
		transform.position = cursorPosition;
	}

	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update () {  
        if (isInPlace) {
            rigidbody.useGravity = true;
        }

         if(gameObject.transform.position.y < 0)
	     {
	         Destroy(gameObject);
	     }
    }
}