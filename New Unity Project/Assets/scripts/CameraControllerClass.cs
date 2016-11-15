using UnityEngine;
using System.Collections;

public class CameraControllerClass : MonoBehaviour {

	//public GameObject Camera1;
	//public GameObject Camera2;

	public GameObject[] Cameras;
	private int currentCam;


	// Use this for initialization
	void Start () {
		// make camera 1 active by default;
		//Camera1.SetActive(true);
		//Camera2.SetActive(false);

		DeactivateCameras();
		Cameras[0].SetActive(true);
		currentCam = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
	

	}

	public void activateCamera(int _camNumber){
	
		Cameras[_camNumber - 1].SetActive(true);
		currentCam = _camNumber - 1;
	}

	public void DeactivateCameras()
	{
		for (int i = 0; i < Cameras.Length; i++)
		{
			Cameras[i].SetActive(false);
		}

	}
}
