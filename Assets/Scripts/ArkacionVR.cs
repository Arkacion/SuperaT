using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArkacionVR : MonoBehaviour {

    public float gazeTime = 2f;

    private bool gazeAt;
    private float timer;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (gazeAt)
        {
            timer += Time.deltaTime;
            if(timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current),ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
	}

    public void PointerEnter()
    {
        //Debug.Log("PointerEnter");
        gazeAt = true;
    }

    public void PointerExit()
    {
        //Debug.Log("PointerExit");
        gazeAt = false;
        timer = 0;
    }

    public void PointerClick()
    {
        Debug.Log("PointerClick");
        gazeAt = false;
        timer = 0;
    }

    public void Teleport()
    {
        GameObject player = GameObject.FindWithTag("Player");

        //transform.Translate(player.transform.position * Time.deltaTime);
        player.transform.position = transform.position;

        gazeAt = false;
        timer = 0;
    }
}
