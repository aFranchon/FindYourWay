using UnityEngine;
using UnityEngine.UI;

public class FloorScr : MonoBehaviour
{
    public int numberOfUse;
    public Text text;

    public bool isClone = false;

    private CreatingObjectScr createSrc;

    // Start is called before the first frame update
    void Start()
    {
        if (isClone)
            return;
        text.text = numberOfUse.ToString();
        createSrc = GameObject.Find("actualCreatedWall").GetComponent<CreatingObjectScr>();
    }

    public bool place()
    {
        if (numberOfUse-- > 0)
        {
            Debug.Log(numberOfUse);
            text.text = numberOfUse.ToString();
            Debug.Log(text.text);
            return true;
        }
        return false;
    }

    public void onButtonClick()
    {
        if (createSrc)
        {
            createSrc.floorScr = gameObject.GetComponent<FloorScr>();
            createSrc.createNew(this.gameObject);
        }
    }
}
