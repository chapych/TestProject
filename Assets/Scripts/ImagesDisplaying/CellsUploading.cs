using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class CellsUploading : MonoBehaviour
{
	private RectTransform content; 
	private GridLayoutGroup grid;
	private float rectHeight;
	private float cellHeight;
	private float topOffset;
	private float cellOffset;
	private int coeff; //assuming that at least part of 1st image is shown
	private int visibleElements;
	private int maxElements = 66;
	private int rows;
	private ImageFactory factory;
	[SerializeField] private RectTransform scrollView;
	
	private void Start()
	{
		grid = GetComponent<GridLayoutGroup>();
		content = GetComponent<RectTransform>();
		factory = GetComponent<ImageFactory>();

		rectHeight = scrollView.rect.height;
		cellHeight = grid.cellSize.y;
		topOffset = grid.padding.top;
		cellOffset = grid.spacing.y;
		rows = grid.constraintCount;

		coeff = CalculateNumberOfVisibleElements();
		visibleElements = transform.childCount;
	}

	private int CalculateNumberOfVisibleElements()
	{
		return (int)((rectHeight - topOffset) / (cellHeight + cellOffset));
	}

	private async void Update()
	{
		if(visibleElements >=maxElements) return;
		if(content.localPosition.y  + rectHeight >= topOffset + coeff * (cellHeight + cellOffset))
		{
			coeff++;
			for(int i=0; i<rows; i++)
				await CreateElementAsync(++visibleElements);

			content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, content.rect.size.y + cellHeight + cellOffset);
		}
	}

	private async Task CreateElementAsync(int id)
	{
		var newImage = await factory.CreateAsync(id);
		
		newImage.transform.SetParent(transform);
	}
}
