

using UnityEngine;

public class End : MonoBehaviour
{
    public event System.Action completed;
    protected void GoalCompleted()
    {
        if (completed != null)
            completed();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
