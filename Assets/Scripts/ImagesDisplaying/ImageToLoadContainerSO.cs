using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Image To Load Container", menuName = "ScriptableObjects/Image To Load Container")]
public class ImageToLoadContainerSO : ScriptableObject
{
	public Image ImageToLoad { get; private set; }
	
	public void Set(Image image)
	{
		ImageToLoad = image;
	}
}
