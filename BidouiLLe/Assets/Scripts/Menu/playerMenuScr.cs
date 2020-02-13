using UnityEngine;
using UnityEngine.AI;

public class playerMenuScr : MonoBehaviour
{
    public Transform start;
    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        var agent = GetComponent<NavMeshAgent>();
        agent.destination = end.position;
    }

    // Update is called once per frame
    void Update()
    {
        var tmp1 = new Vector2(transform.position.x, transform.position.z);
        var tmp2 = new Vector2(end.position.x, end.position.z);
        var tmp3 = new Vector2(start.position.x, start.position.z);

        if (tmp1 == tmp3)
        {
            var agent = GetComponent<NavMeshAgent>();
            agent.destination = end.position;
        }

        if (tmp1 == tmp2)
        {
            var agent = GetComponent<NavMeshAgent>();
            agent.destination = start.position;
        }
    }
}
