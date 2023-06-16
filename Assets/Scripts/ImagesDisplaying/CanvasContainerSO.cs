using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Canvas Container", menuName = "ScriptableObjects/Canvas Container")]
public class CanvasContainerSO : ScriptableObject
{
	public Canvas Canvas { get; private set; }
	
	public void Set(Canvas canvas)
	{
		Canvas = canvas;
	}
}
