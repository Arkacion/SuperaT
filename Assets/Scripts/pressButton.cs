using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButton : MonoBehaviour {

	public void ButtonStadist ()
	{
		Application.LoadLevel (5);
    }

    public void ButtonEnoclofobia ()
	{
		Application.LoadLevel (1);
    }

    public void ButtonAcrofobia ()
	{
		Application.LoadLevel (4);
    }

    public void ButtonClaustrofobia ()
	{
		Application.LoadLevel (2);
    }

    public void ButtonNictofobia ()
	{

		Application.LoadLevel (3);
    }

    public void ButtonExit()
    {
        Application.Quit();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
