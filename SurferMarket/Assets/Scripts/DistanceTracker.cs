using UnityEngine;

public class DistanceTracker : MonoBehaviour, IDistanceProvider
{
    private float distance;

    public float GetDistance() {

        return distance;
    }


    public void IncrementDistance(float value) {

        distance += value;
    }

}
