using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Security.Cryptography;

public class JoystickScript : MonoBehaviour , IDragHandler, IPointerUpHandler, IPointerDownHandler {

	private Image bgImage, joystickImage;
	private Vector3 inputVector;

	private void Start(){

		bgImage = GetComponent<Image> ();
		joystickImage = transform.GetChild (0).GetComponent<Image> ();

	}

	public virtual void OnDrag(PointerEventData pointerEventData){

		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle (bgImage.rectTransform, 
			pointerEventData.position, pointerEventData.pressEventCamera, out pos)) 
		{
			pos.x = (pos.x / bgImage.rectTransform.sizeDelta.x);
			pos.y = (pos.y / bgImage.rectTransform.sizeDelta.y);

			inputVector = new Vector3 (pos.x*2 + 1, 0, pos.y *2 - 1);

			inputVector = (inputVector.magnitude > 1.0f)?inputVector.normalized:inputVector;

			joystickImage.rectTransform.anchoredPosition = 
				new Vector3 (inputVector.x * (bgImage.rectTransform.sizeDelta.x / 3),
					inputVector.z * (bgImage.rectTransform.sizeDelta.y / 3));

		}
	}

	public virtual void OnPointerDown(PointerEventData pointerEventData){
		OnDrag (pointerEventData);
	}

	public virtual void OnPointerUp(PointerEventData pointerEventData){

		inputVector = Vector3.zero;
		joystickImage.rectTransform.anchoredPosition = Vector3.zero;
	}

	public float Horizontal(){

		if (inputVector.x != 0) 
			return inputVector.x;
		else
			return Input.GetAxis ("Horizontal");
	}


	public float Vertical(){

		if (inputVector.z != 0) 
			return inputVector.z;
		else
			return Input.GetAxis ("Vertical");
	}

	public float RotateObject(){
		if (inputVector.z != 0) 
			return inputVector.z;
		else
			return inputVector.z;
		
	}
}