// Don't look until you've attempted to fix the existing files!
using UnityEngine;

public class UTypes_C : MonoBehaviour
{
    private Vector3 initialPosition;
    public Vector3 GoalPosition;
    public float TimeToMove = 2f;
    
    public Transform GoalOverride = null;

    //This is just a simple float that stores the time since the GameObject was at its goal.
    public float TimeSinceGoal = 0;
    

    private Vector3 thisInitialPosition;

    private void Start()
    {
        thisInitialPosition = transform.position;
    }

    private void Update()
    {
        //Shorthand for GoalOverride != null
        if (GoalOverride) GoalPosition = GoalOverride.position;
        
        if (transform.position.Equals(GoalPosition)) 
        {
            thisInitialPosition = transform.position;
            TimeSinceGoal = 0;
            return;
        }
        transform.position = Vector3.Lerp(thisInitialPosition, GoalPosition, TimeSinceGoal / TimeToMove);
        TimeSinceGoal += Time.deltaTime;
    }
}