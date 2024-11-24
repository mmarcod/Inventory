using UnityEngine;

public class SC_PickItem : MonoBehaviour
{
    public string itenName = "Some Item";
    public Texture itemPreview;

    void Start()
    {
        gameObject.tag = "Respawn"; 
    }

    // Update is called once per frame
    public void PickItem()
    {
        Destroy(gameObject);
    }
}
