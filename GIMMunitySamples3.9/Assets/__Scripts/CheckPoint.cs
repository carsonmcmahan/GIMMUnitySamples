using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Queue<Vector3> wayPoints = new Queue<Vector3>();
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        wayPoints.Enqueue(new Vector3(-2f,0f,-2f));
        wayPoints.Enqueue(new Vector3(-2f, 0f, 2f));
        wayPoints.Enqueue(new Vector3(2f, 0f, 2f));

        pos = wayPoints.Dequeue();
        transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(wayPoints.Count != 0)
        {
            pos = wayPoints.Dequeue();
            transform.position = pos;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

}
