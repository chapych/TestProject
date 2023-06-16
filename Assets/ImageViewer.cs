using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageViewer : MonoBehaviour
{
	private Image image;
	[SerializeField] private ImageToLoadContainerSO container;
	void Start()
	{
		image = GetComponent<Image>();
		
		image.sprite = container.ImageToLoad.sprite;
	}
}
