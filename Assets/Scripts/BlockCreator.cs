using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreator : MonoBehaviour
{
    public GameObject block; //Red colored block
    public GameObject block1; //Yellow coored block
    public GameObject parentBlock; //Parent block
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 6; i++)
        {
            int posx = i;
            var obj = Instantiate(block, new Vector3(0f, 3f + posx, 0), Quaternion.identity, transform);
            var obj1 = Instantiate(block1, new Vector3(0.5f, 3f + posx, 0), Quaternion.identity, transform);

            if (0==i%2)
                    {
                obj.transform.Rotate(0f, 90f, 2f, Space.World);
                obj1.transform.Rotate(0f, 90f, 2f, Space.World);
            }
            else
            {
                obj.transform.Rotate(0f, 3f, 2f, Space.World);
                obj1.transform.Rotate(0f, 3f, 2f, Space.World);
            }
            obj.transform.SetParent(parentBlock.transform);
            obj1.transform.SetParent(parentBlock.transform);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
