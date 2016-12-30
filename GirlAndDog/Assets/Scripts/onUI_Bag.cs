using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class onUI_Bag : MonoBehaviour {
    public GameObject me;
    public float myFadeOutSpeed;
    public float myMoveSpeed;
    public GameObject[] myHideShowPoint;
    public bool isTimeShowBag;
    public float myHideBagTime;
    float myHideBagTimer;
    public int myPickUpID;
    public float myPickUpChangeTime;
    float myPickUpChangeTimer;
    public bool isPickUpChangeTime;
    // Use this for initialization
    void Start () {
        me = gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        myUIBag_FN();
        if (!isPickUpChangeTime) {
            if (myPickUpChangeTimer > myPickUpChangeTime) {
                myPickUpChangeTimer = 0;
                isPickUpChangeTime = true;
            }
            else { myPickUpChangeTimer += Time.deltaTime; }
        }

    }
    public void myUIBag_FN() {
        if (Input.GetAxis("Horizontal_Dpad")>0.1 || Input.GetAxis("Horizontal_Dpad") < -0.1) {
            isTimeShowBag = true;
            myHideBagTimer = 0;
            if (Input.GetAxis("Horizontal_Dpad") > 0.1) {
                if (isPickUpChangeTime) {
                    if (myPickUpID > 6) { myPickUpID = 0; isPickUpChangeTime = false; }
                    else { myPickUpID++; isPickUpChangeTime = false; }
                }
            }
            else if (Input.GetAxis("Horizontal_Dpad") < -0.1) {
                if (isPickUpChangeTime)
                {
                    if (myPickUpID < 1) { myPickUpID = 7; isPickUpChangeTime = false; }
                    else { myPickUpID--; isPickUpChangeTime = false; }
                }
            }
        }

        if (isTimeShowBag)
        {
            transform.position = Vector3.Lerp(transform.position, myHideShowPoint[0].transform.position, Time.deltaTime * myMoveSpeed);
            Color a = me.GetComponent<Image>().color;
            if (a.a>1) {
                a.a =1;
                me.GetComponent<Image>().color = a;
            }
            else {
                a.a += Time.deltaTime * myFadeOutSpeed;
                me.GetComponent<Image>().color = a;
            }
            
        }
        else {
            transform.position = Vector3.Lerp(transform.position, myHideShowPoint[1].transform.position, Time.deltaTime * myMoveSpeed);
            Color a = me.GetComponent<Image>().color;
            if (a.a < 0)
            {
                a.a = 0;
                me.GetComponent<Image>().color = a;
            }
            else {
                a.a -= Time.deltaTime * myFadeOutSpeed;
                me.GetComponent<Image>().color = a;
            }
        }
        if (myHideBagTimer > myHideBagTime)
        {
            myHideBagTimer = 0;
            isTimeShowBag = false;
        }
        else {
            myHideBagTimer += Time.deltaTime;
        }
    }
}
