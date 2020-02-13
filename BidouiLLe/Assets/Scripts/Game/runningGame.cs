using UnityEngine;
using UnityEngine.AI;


public class runningGame : MonoBehaviour
{
    public GameObject player;

    public GameObject[] surfaces;
    private int actualIndex = 2;

    public void onButtonClick()
    {
        var list = Object.FindObjectsOfType<NavMeshSurface>();

        foreach (var elem in list)
        {
            Debug.Log("Building");
            elem.BuildNavMesh();
        }
        var links = Object.FindObjectsOfType<NavMeshLink>();

        foreach (var elem in links)
        {
            Debug.Log("Building");
            elem.UpdateLink();
        }
        player.GetComponent<playerScr>().SetGoal();

        var tmp = GameObject.FindGameObjectsWithTag("Points");

        foreach (var elem in tmp)
        {
            elem.SetActive(false);
        }
    }

    public void addInList(GameObject toAdd)
    {
        toAdd.GetComponent<FloorScr>().isClone = true;
    }
}
