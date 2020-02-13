using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingObjectScr : MonoBehaviour
{
    private GameObject actualNew;

    public GameObject parent;
    public runningGame runningGameScr;
    public FloorScr floorScr;

    private bool placingDelayed = true;
    
    // Update is called once per frame
    void Update()
    {
        if (actualNew)
        {
            var tmp = Input.mousePosition;
//            tmp.y = 10;
            tmp = Camera.main.ScreenToWorldPoint(tmp);
            actualNew.transform.position = new Vector3(tmp.x, 0, tmp.z);
        }

        if (Input.GetAxis("Cancel") != 0)
        {
            resetActualNew();
        }

        if (Input.GetAxis("Fire1") != 0 && actualNew)
        {
            if (placingDelayed)
                placeActualNew();
        }
    }

    public void createNew(GameObject newPrefab)
    {
        resetActualNew();
        var tmp = Input.mousePosition;
        tmp.z = 0;
        tmp = Camera.main.ScreenToWorldPoint(tmp);
        actualNew = Instantiate(newPrefab, new Vector2(tmp.x, tmp.y), new Quaternion());
    }

    public void resetActualNew()
    {
        if (actualNew)
            Destroy(actualNew);
    }

    private void resetPlacingDelay()
    {
        placingDelayed = true;
    }

    public void placeActualNew()
    {
        if (floorScr.place())
        {
            placingDelayed = false;
            Invoke("resetPlacingDelay", 0.5f);
            runningGameScr.addInList(Instantiate(actualNew, actualNew.transform.position, new Quaternion(), parent.transform));
        }
    }
}
