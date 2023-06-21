using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScreenOrientation : MonoBehaviour
{
	void Start()
	{
		Screen.autorotateToLandscapeLeft = false;
		Screen.autorotateToLandscapeRight = false;
		
		Screen.orientation = ScreenOrientation.Portrait;
	}
}
