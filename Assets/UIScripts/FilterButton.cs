using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterButton : MonoBehaviour
{
    [SerializeField]
    private PartSelector _partSelector;


    public void BuildPartSelector(List<TruckPart> truckParts)
    {

        _partSelector.Build(truckParts);
    }
	
}
