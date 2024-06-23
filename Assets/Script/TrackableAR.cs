using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackableAR : DefaultObserverEventHandler
{
    private bool marker;
    protected override void OnTrackingFound() // menemukan target
    {
        marker = true;
        base.OnTrackingFound(); // jika menemukan target maka akan memanggil fungsi OnTrackingFound() pada DefaultTrackableEventHandler
        
    }

    protected override void OnTrackingLost() // kehilangan target
    {
        marker = false;
        base.OnTrackingLost(); // jika kehilangan target maka akan memanggil fungsi OnTrackingLost() pada DefaultTrackableEventHandler
    }

    public bool GetMarker()
    {
        return marker;
    }

}
