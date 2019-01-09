using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	public GameObject mCamera;

	// Use this for initialization
	public void SwitchToTop()
	{
		mCamera.transform.position = new Vector3 (5,20,5);
		mCamera.transform.rotation = Quaternion.Euler (90, -90, 0);
	}
	public void SwitchToSide()
	{
		mCamera.transform.position = new Vector3 (40,5,5);
		mCamera.transform.rotation = Quaternion.Euler (0, -90, 0);
	}
	public void SwitchToFront()
	{
		mCamera.transform.position = new Vector3 (5,5,40);
		mCamera.transform.rotation = Quaternion.Euler (0, 180, 0);
	}
}
