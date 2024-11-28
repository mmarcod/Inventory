using UnityEngine;

public class SC_PickItem : MonoBehaviour
{
    public string itemName = "Sphere"; //Each item must have an unique name
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
