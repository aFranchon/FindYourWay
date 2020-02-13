using UnityEngine;
using UnityEngine.AI;

public class playerScr : MonoBehaviour
{
    public Transform goal;

    public GameObject winUI;

    // Update is called once per frame
    void Update()
    {
        var tmp1 = new Vector2(transform.position.x, transform.position.z);
        var tmp2 = new Vector2(goal.position.x, goal.position.z);


        if (tmp1 == tmp2)
        {
            //WIN THE GAME
            winUI.SetActive(true);
        }
    }

    public void SetGoal()
    {
        var agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}
