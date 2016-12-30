using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class onUI_Item : MonoBehaviour {
    public GameObject myFather;
    public int myItemID;
	// Use this for initialization
	void Start () {
        myFather = transform.parent.gameObject;

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Image>().color = myFather.GetComponent<Image>().color;
        if (myItemID == myFather.GetComponent<onUI_Bag>().myPickUpID) {
            Vector3 scal = gameObject.GetComponent<RectTransform>().localScale;
            scal.x = scal.y = 1.1f;
            gameObject.GetComponent<RectTransform>().localScale = scal;
        }
        else {
            Vector3 scal = gameObject.GetComponent<RectTransform>().localScale;
            scal.x = scal.y = 0.9f;
            gameObject.GetComponent<RectTransform>().localScale = scal;
        }
	}
}
