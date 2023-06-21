using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockScreenOrientation : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Screen.autorotateToLandscapeLeft = true;
		Screen.autorotateToLandscapeRight = true;
		Screen.autorotateToPortrait = true;
		
		Screen.orientation = ScreenOrientation.AutoRotation;
	}
}
