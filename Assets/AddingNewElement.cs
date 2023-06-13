using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingNewElement : MonoBehaviour
{
	[SerializeField] private GameObject scrollViewContent;
	[SerializeField] private GameObject prefab;
	void Update()
	{
		if(Input.anyKeyDown)
		{
			var newElement = Instantiate(prefab);
			newElement.transform.parent = scrollViewContent.transform;
		}
	}
}
