using UnityEngine;

public class DisstanceIncrementer : MonoBehaviour
{
    public float incrementPerSecond;
    private DistanceTracker tracker;
    private DistanceLimiter limiter;

    void Start() {

        tracker = GetComponent<DistanceTracker>();    
        limiter = GetComponent<DistanceLimiter>();    
    
        if (tracker == null) Debug.LogError("No tracker found!");
    }

    void Update() {

        tracker.IncrementDistance(incrementPerSecond);
        Debug.Log(tracker.GetDistance() + " out of " + limiter.distanceLimit);
    }

}
