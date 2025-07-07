using UnityEngine;

public class DistanceLimiter : MonoBehaviour
{
    public float distanceLimit;
    private IDistanceProvider distanceProvider;

    void Awake() {

        distanceProvider = gameObject.GetComponent<IDistanceProvider>();
        if (distanceProvider == null) {

            Debug.LogError("No IdistanceProvider found");
        }
    }

    void Update() {

        if (distanceProvider.GetDistance() > distanceLimit) {

            Debug.Log("Distance limit exceeded!");
            // change scene
        }
    
    }
}
